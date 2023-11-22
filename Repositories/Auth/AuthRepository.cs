using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using repair_management_backend.Models;
using repair_management_backend.Repositories.TokenRepo;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace repair_management_backend.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly DataContext _dataContext;
        private readonly ITokenRepository _tokenRepository;
        public AuthRepository(UserManager<IdentityUser> userManager, DataContext dataContext, ITokenRepository tokenRepository)
        {
            _userManager = userManager;
            _dataContext = dataContext;
            _tokenRepository = tokenRepository;
        }
        public async Task<ServiceResponse<TokenResponse>> Login(string email, string password)
        {
            var serviceResponse = new ServiceResponse<TokenResponse>();
            var existingUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Email == email);

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

            var jwtToken = await _tokenRepository.GenerateAccessTokenFromUserName(existingUser.UserName);
            var refreshToken = _tokenRepository.GenerateRefreshToken();

            existingUser.RefreshToken = refreshToken;
            existingUser.RefreshTokenExpiryTime = DateTime.UtcNow.AddMinutes(120);
            await _dataContext.SaveChangesAsync();

            serviceResponse.Data = new TokenResponse() { Token = jwtToken, RefreshToken = refreshToken};
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
                serviceResponse.Data = await _tokenRepository.GenerateAccessTokenFromUserName(newUser.UserName);
                serviceResponse.Message = "Tạo thành công user";
            } else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = isCreated.ToString();
                return serviceResponse;
            }

            return serviceResponse;
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

            var principal = _tokenRepository.GetPrincipalFromExpiredToken(accessToken);
            var email = principal.FindFirst(ClaimTypes.Email);

            if (email == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi khi lấy claim từ token";
                return serviceResponse;
            }

            var user = await _dataContext.Users.FirstOrDefaultAsync(x => x.Email == email.Value);

            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Request không hợp lệ";
                return serviceResponse;
            }

            var newAccessToken = _tokenRepository.GenerateAccessTokenFromClaims(principal.Claims);
            var newRefreshToken = _tokenRepository.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            await _dataContext.SaveChangesAsync();

            serviceResponse.Data = new TokenResponse() { Token = newAccessToken, RefreshToken = newRefreshToken };
            
            return serviceResponse;
        }
    }
}
