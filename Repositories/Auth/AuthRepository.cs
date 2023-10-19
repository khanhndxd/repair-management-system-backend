using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace repair_management_backend.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        public AuthRepository(UserManager<IdentityUser> userManager, IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
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

            var jwtToken = GenerateJwtToken(existingUser);
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

            var newUser = new IdentityUser() { Email = email, UserName = userName };
            var isCreated = await _userManager.CreateAsync(newUser, password);
            if(isCreated.Succeeded)
            {
                serviceResponse.Data = GenerateJwtToken(newUser);
                serviceResponse.Message = "Tạo thành công user";
            } else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi không thể tạo user";
                return serviceResponse;
            }

            return serviceResponse;
        }
        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}
