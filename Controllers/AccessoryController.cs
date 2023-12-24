using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.AccessoryRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccessoryController : ControllerBase
    {
        private readonly IAccessoryRepository _accessoryRepository;
        public AccessoryController(IAccessoryRepository accessoryRepository)
        {
            _accessoryRepository = accessoryRepository;
        }
        [HttpGet("GetAll")]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<List<Accessory>>>> Get()
        {
            return Ok(await _accessoryRepository.GetAll());
        }
    }
}
