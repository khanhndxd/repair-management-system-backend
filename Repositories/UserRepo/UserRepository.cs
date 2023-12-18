using Microsoft.AspNetCore.Identity;
using repair_management_backend.DTOs.User;
using repair_management_backend.Models;

namespace repair_management_backend.Repositories.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserRepository(DataContext dataContext , UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _dataContext = dataContext;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<ServiceResponse<string>> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var user = await _userManager.FindByIdAsync(changePasswordDTO.UserId);

                if (user == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Không tìm thấy người dùng";
                    return serviceResponse;
                }

                var changePasswordResult = await _userManager.ChangePasswordAsync(user, changePasswordDTO.OldPassword, changePasswordDTO.NewPassword);

                if (changePasswordResult.Succeeded)
                {
                    serviceResponse.Data = "Đổi mật khẩu thành công";
                }
                else
                {
                    throw new Exception($"Sai thông tin về mật khẩu, thử lại");
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> ChangeUserRole(ChangeRoleDTO changeRoleDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var user = await _userManager.FindByIdAsync(changeRoleDTO.UserId);

                if (user == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Không tìm thấy người dùng";
                    return serviceResponse;
                }

                // Lấy role hiện tại của người dùng
                var currentRole = (await _userManager.GetRolesAsync(user)).SingleOrDefault();

                // Kiểm tra xem role mới có khác với role hiện tại hay không
                if (currentRole != changeRoleDTO.NewRole)
                {
                    // Loại bỏ role hiện tại
                    var removeRoleResult = await _userManager.RemoveFromRolesAsync(user, new List<string> { currentRole.ToLower() });

                    if (!removeRoleResult.Succeeded)
                    {
                        throw new Exception($"Có lỗi khi loại bỏ role '{currentRole}' của người dùng có id '{changeRoleDTO.UserId}'");
                    }

                    if (await _roleManager.RoleExistsAsync(changeRoleDTO.NewRole))
                    {
                        var addRoleResult = await _userManager.AddToRoleAsync(user, changeRoleDTO.NewRole);

                        if (addRoleResult.Succeeded)
                        {
                            serviceResponse.Data = "Thay đổi role thành công";
                        }
                        else
                        {
                            throw new Exception($"Có lỗi khi thay đổi role của người dùng có id '{changeRoleDTO.UserId}'");
                        }
                    }
                    else
                    {
                        throw new Exception($"Role không tồn tại'");
                    }
                }
                else
                {
                    serviceResponse.Data = "Người dùng đã được gán role chỉ định";
                    serviceResponse.Message = "Người dùng đã được gán role chỉ định";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> DeleteUser(string userId)
        {
            var serviceResponse = new ServiceResponse<string>();

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Người dùng không tồn tại";
                return serviceResponse;
            }

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                serviceResponse.Message = "Xóa người dùng thành công";
            }
            else
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"Lỗi khi xóa người dùng: {string.Join(", ", result.Errors.Select(e => e.Description))}";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUserWithRolesDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<GetUserWithRolesDTO>>();
            try
            {
                var users = await _dataContext.Users.ToListAsync();
                var userList = new List<GetUserWithRolesDTO>();

                foreach (var user in users)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    var userDto = new GetUserWithRolesDTO
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        Roles = roles.ToList()
                    };
                    userList.Add(userDto);
                }

                serviceResponse.Data = userList;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRoleDTO>>> GetAllRoles()
        {
            var serviceResponse = new ServiceResponse<List<GetRoleDTO>>();
            try
            {
                // Lấy danh sách tất cả các vai trò
                var roles = await _roleManager.Roles.ToListAsync();

                // Chuyển đổi danh sách vai trò thành danh sách DTO
                var roleDTOs = roles.Select(role => new GetRoleDTO
                {
                    Id = role.Id,
                    Name = role.Name
                }).ToList();

                serviceResponse.Data = roleDTOs;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"Có lỗi khi lấy danh sách vai trò";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> UpdateUser(UpdateUserDTO updateUserDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var user = await _userManager.FindByIdAsync(updateUserDTO.UserId);

                if (user == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Không tìm thấy người dùng";
                    return serviceResponse;
                }

                if (!IsValidEmail(updateUserDTO.Email))
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Sai định dạng email";
                    return serviceResponse;
                }

                // Cập nhật thông tin người dùng
                user.UserName = updateUserDTO.UserName;
                user.Email = updateUserDTO.Email;
                user.PhoneNumber = updateUserDTO.PhoneNumber;

                // Lưu thay đổi vào cơ sở dữ liệu
                IdentityResult updateResult = await _userManager.UpdateAsync(user);

                if (updateResult.Succeeded)
                {
                    serviceResponse.Data = "Cập nhật thông tin người dùng thành công";
                }
                else
                {
                    throw new Exception($"{updateResult.Errors}'");
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
