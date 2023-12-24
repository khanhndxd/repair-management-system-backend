using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using repair_management_backend.DTOs.RepairLog;
using repair_management_backend.Hubs;
using repair_management_backend.Repositories.RepairLogRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RepairLogController : ControllerBase
    {
        private readonly IRepairLogRepository _repairLogRepository;
        public RepairLogController(IRepairLogRepository repairLogRepository)
        {
            _repairLogRepository = repairLogRepository;
        }
        [HttpGet("RepairOrder/{id}")]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<IActionResult> GetRepairLogByRepairOrderId(int id)
        {
            var result = await _repairLogRepository.GetRepairLogByRepairOrderId(id);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<IActionResult> AddRepairLog(AddRepairLogDTO addRepairLogDTO)
        {
            var result = await _repairLogRepository.AddRepairLog(addRepairLogDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
