using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairReason;
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
        [HttpPost]
        public async Task<IActionResult> AddRepairReason([FromBody] AddRepairReasonDTO addRepairReasonDTO)
        {
            var result = await _repairReasonRepository.AddRepairReason(addRepairReasonDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPatch]
        public async Task<IActionResult> UpdateRepairReason([FromBody] UpdateRepairReasonDTO updateRepairReasonDTO)
        {
            var result = await _repairReasonRepository.UpdateRepairReason(updateRepairReasonDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRepairReason([FromBody] DeleteRepairReasonDTO deleteRepairReasonDTO)
        {
            var result = await _repairReasonRepository.DeleteRepairReason(deleteRepairReasonDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
