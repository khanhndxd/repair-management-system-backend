using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.User;
using repair_management_backend.Repositories.UserRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository= userRepository;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
           var result = await _userRepository.GetAll();
            if (result.Success == false)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var result = await _userRepository.GetAllRoles();
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var result = await _userRepository.DeleteUser(id);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDTO updateUserDTO)
        {
            var result = await _userRepository.UpdateUser(updateUserDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            var result = await _userRepository.ChangePassword(changePasswordDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPatch("ChangeRole")]
        public async Task<IActionResult> ChangeUserRole([FromBody] ChangeRoleDTO changeRoleDTO)
        {
            var result = await _userRepository.ChangeUserRole(changeRoleDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
