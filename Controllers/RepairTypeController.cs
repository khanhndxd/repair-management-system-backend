using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.RepairTypeRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairTypeController : ControllerBase
    {
        private readonly IRepairTypeRepository _repairTypeRepository;
        public RepairTypeController(IRepairTypeRepository repairTypeRepository)
        {
            _repairTypeRepository = repairTypeRepository;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<RepairType>>>> Get()
        {
            return Ok(await _repairTypeRepository.GetAll());
        }
    }
}
