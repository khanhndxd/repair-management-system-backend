using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairTask;
using repair_management_backend.Repositories.RepairTask;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairTaskController : ControllerBase
    {
        private readonly IRepairTaskRepository _repairTaskRepository;
        public RepairTaskController(IRepairTaskRepository repairTaskRepository)
        {
            _repairTaskRepository = repairTaskRepository;
        }
        [HttpPost]
        public async Task<IActionResult> AddRepairTask([FromBody] List<AddRepairTaskDTO> addRepairTaskDTOs)
        {
            var result = await _repairTaskRepository.AddRepairTask(addRepairTaskDTOs);
            if(result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
