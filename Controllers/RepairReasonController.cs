using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.RepairReasonRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairReasonController : ControllerBase
    {
        private readonly IRepairReasonRepository _repairReasonRepository;
        public RepairReasonController(IRepairReasonRepository repairReasonRepository)
        {
            _repairReasonRepository = repairReasonRepository;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<RepairReason>>>> Get()
        {
            return Ok(await _repairReasonRepository.GetAll());
        }
    }
}
