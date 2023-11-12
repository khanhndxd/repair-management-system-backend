using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using repair_management_backend.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace repair_management_backend.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataContext _dataContext;
        private readonly JwtConfig _jwtConfig;
        public AuthRepository(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IOptionsMonitor<JwtConfig> optionsMonitor, DataContext dataContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<string>> Login(string email, string password)
        {
            var serviceResponse = new ServiceResponse<string>();
            var existingUser = await _userManager.FindByEmailAsync(email);

            if (existingUser == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Không tồn tại người dùng";
                return serviceResponse;
            }
            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, password);

            if(!isCorrect)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Sai mật khẩu, vui lòng nhập lại";
                return serviceResponse;
            }

            var jwtToken = await GenerateJwtToken(existingUser.UserName);
            serviceResponse.Data = jwtToken;
            serviceResponse.Message = "Đăng nhập thành công";

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> Register(string userName, string email, string password)
        {
            var serviceResponse = new ServiceResponse<string>();
            var existingUser = await _userManager.FindByEmailAsync(email);

            if(existingUser != null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Tài khoản đã tồn tại";
                return serviceResponse;
            }

            var newUser = new User() { Email = email, UserName = userName };
            var isCreated = await _userManager.CreateAsync(newUser, password);
            if(isCreated.Succeeded)
            {
                serviceResponse.Data = await GenerateJwtToken(newUser.UserName);
                serviceResponse.Message = "Tạo thành công user";
            } else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = isCreated.ToString();
                return serviceResponse;
            }

            return serviceResponse;
        }
        private async Task<string> GenerateJwtToken(string username)
        {
            var claims = await GetClaims(username);
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtConfig.Secret);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            );

            var jwtToken = jwtTokenHandler.WriteToken(securityToken);

            return jwtToken;
        }
        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var key = Encoding.UTF8.GetBytes(_jwtConfig.Secret);

            var tokeOptions = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

            return tokenString;
        }
        private async Task<List<Claim>> GetClaims(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            var claims = new List<Claim>() { new Claim(ClaimTypes.Name, user.Email) };
            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var key = Encoding.UTF8.GetBytes(_jwtConfig.Secret);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateLifetime = true,
                RequireExpirationTime = true
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256Signature, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }

        public async Task<ServiceResponse<TokenResponse>> RefreshToken(TokenRequest tokenRequest)
        {
            var serviceResponse = new ServiceResponse<TokenResponse>();
            if (tokenRequest is null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Token không hợp lệ";
            }

            string accessToken = tokenRequest.AccessToken;
            string refreshToken = tokenRequest.RefreshToken;

            var principal = GetPrincipalFromExpiredToken(accessToken);
            var email = principal.Identity.Name; //this is mapped to the Name claim by default

            //var user = await _userManager.FindByEmailAsync(email);

            var user = await _dataContext.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Request không hợp lệ";
            }

            var newAccessToken = GenerateAccessToken(principal.Claims);
            var newRefreshToken = GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            await _dataContext.SaveChangesAsync();

            serviceResponse.Data = new TokenResponse() { Token = newAccessToken, RefreshToken = newRefreshToken };
            
            return serviceResponse;
        }
    }
}
