using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<ServiceResponse<List<RepairOrder>>>> Get()
        {
            return Ok(await _repairOrderRepository.GetAll());
        }
    }
}
