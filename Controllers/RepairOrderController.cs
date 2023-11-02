using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.Repositories.RepairOrderRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairOrderController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IRepairOrderRepository _repairOrderRepository;
        public RepairOrderController(DataContext dataContext, IRepairOrderRepository repairOrderRepository)
        {
            _dataContext = dataContext;
            _repairOrderRepository = repairOrderRepository;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetRepairOrderDTO>>>> Get()
        {
            return Ok(await _repairOrderRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetRepairOrderDTO>>> GetSingle(int id)
        {
            var result = await _repairOrderRepository.GetRepairOrderById(id);
            if(result.Data is null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<string>>> AddRepairOrder([FromBody] RepairOrderFullDTO newRepairOrder)
        {
            var result = await _repairOrderRepository.AddRepairOrder(newRepairOrder);
            if (result.Data is null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
