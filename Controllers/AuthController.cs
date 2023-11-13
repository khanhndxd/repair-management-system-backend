using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using repair_management_backend.DTOs.User;
using repair_management_backend.Models;

namespace repair_management_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAuthRepository _auth;
        private readonly JwtConfig _jwtConfig;
        public AuthController(UserManager<IdentityUser> userManager, IAuthRepository auth, IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _userManager = userManager;
            _auth = auth;
            _jwtConfig = optionsMonitor.CurrentValue;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if(ModelState.IsValid)
            {
                var response = await _auth.Register(user.UserName, user.Email, user.Password);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto user)
        {
            if (ModelState.IsValid)
            {
                var response = await _auth.Login(user.Email, user.Password);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest tokenRequest)
        {
            var result = await _auth.RefreshToken(tokenRequest);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
