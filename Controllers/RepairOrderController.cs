using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.Repositories.RepairOrderRepo;
using System.Security.Claims;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class RepairOrderController : ControllerBase
    {
        private readonly IRepairOrderRepository _repairOrderRepository;
        public RepairOrderController(DataContext dataContext, IRepairOrderRepository repairOrderRepository)
        {
            _repairOrderRepository = repairOrderRepository;
        }
        [HttpGet("GetAll")]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<List<GetRepairOrderDTO>>>> Get([FromQuery] string? field, [FromQuery] string? time, [FromQuery] string? startDate, [FromQuery] string? endDate)
        {
            var user = HttpContext.User;

            if (user != null && user.Claims != null)
            {
                var roles = user.Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value)
                    .ToList();

                var userIdClaim = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                    var userId = userIdClaim.Value;
                    return Ok(await _repairOrderRepository.GetAll(userId, roles, field, time, startDate, endDate));
                }
                else
                {
                    return Forbid();
                }

            }
            return Forbid();
        }
        [HttpGet("{id}")]
        //[Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<GetRepairOrderDTO>>> GetSingle(int id)
        {
            var result = await _repairOrderRepository.GetRepairOrderById(id);
            if (result.Data is null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<int>>> AddRepairOrder([FromBody] AddRepairOrderDTO newRepairOrder)
        {
            var result = await _repairOrderRepository.AddRepairOrder(newRepairOrder);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPatch("Status")]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<string>>> UpdateRepairOrderStatus([FromBody] UpdateRepairOrderStatusDTO updateRepairOrderStatusDTO)
        {
            var result = await _repairOrderRepository.UpdateRepairOrderStatus(updateRepairOrderStatusDTO);
            if (result.Data is null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPatch]
        [Authorize(Policy = "ReadWritePolicy")]
        public async Task<ActionResult<ServiceResponse<string>>> UpdateRepairOrder([FromBody] UpdateRepairOrderDTO updateRepairOrderDTO)
        {
            var result = await _repairOrderRepository.UpdateRepairOrder(updateRepairOrderDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("Status/{statusId}")]
        public async Task<IActionResult> GetRepairOrderbyStatus(int statusId)
        {
            var result = await _repairOrderRepository.GetRepairOrderByStatus(statusId);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("Category")]
        public async Task<IActionResult> GetRepairCategoryStats()
        {
            var result = await _repairOrderRepository.GetRepairCategoryStat();
            if (result.Success == false)
            {
                return BadRequest(result);
            } 
            return Ok(result);
        }
        [HttpGet("TotalPrice")]
        public async Task<IActionResult> GetTotalPrice()
        {
            var result = await _repairOrderRepository.GetTotalPrice();
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpDelete()]
        public async Task<IActionResult> DeleteRepairOrder([FromBody] DeleteRepairOrderDTO deleteRepairOrderDTO)
        {
            var result = await _repairOrderRepository.DeleteRepairOrder(deleteRepairOrderDTO);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
