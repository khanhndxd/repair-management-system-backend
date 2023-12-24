using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairAccessory;
using repair_management_backend.Repositories.RepairAccessoryRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairAccessoryController : ControllerBase
    {
        private readonly IRepairAccessoryRepository _repairAccessoryRepository;
        public RepairAccessoryController(IRepairAccessoryRepository repairAccessoryRepository)
        {
            _repairAccessoryRepository = repairAccessoryRepository;
        }
        [HttpGet("/RepairOrder/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetRepairAccessoryDTO>>>> GetRepairAccessoryByRepairOrderId(int id)
        {
            var result = await _repairAccessoryRepository.GetRepairAccessoryByRepairOrderId(id);
            if (result.Data is null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<string>>> AddRepairAccessory([FromBody] List<AddRepairAccessoryDTO> addRepairAccessoryDTO)
        {
            var result = await _repairAccessoryRepository.AddRepairAccessory(addRepairAccessoryDTO);
            if(result.Data is null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
