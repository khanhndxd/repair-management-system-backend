using System.Security.Claims;

namespace repair_management_backend.Repositories.TokenRepo
{
    public interface ITokenRepository
    {
        Task<string> GenerateAccessTokenFromUserName(string username);
        string GenerateAccessTokenFromClaims(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
