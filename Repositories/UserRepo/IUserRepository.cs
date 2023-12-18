using repair_management_backend.DTOs.User;

namespace repair_management_backend.Repositories.UserRepo
{
    public interface IUserRepository
    {
        Task<ServiceResponse<List<GetUserWithRolesDTO>>> GetAll();
        Task<ServiceResponse<List<GetRoleDTO>>> GetAllRoles();
        Task<ServiceResponse<string>> ChangePassword(ChangePasswordDTO changePasswordDTO);
        Task<ServiceResponse<string>> ChangeUserRole(ChangeRoleDTO changeRoleDTO);
        Task<ServiceResponse<string>> UpdateUser(UpdateUserDTO updateUserDTO);
        Task<ServiceResponse<string>> DeleteUser(string userId);
    }
}
