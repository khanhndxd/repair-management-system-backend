using repair_management_backend.Models;

namespace repair_management_backend.Repositories.Auth
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<string>> Register(string userName, string email, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
    }
}
