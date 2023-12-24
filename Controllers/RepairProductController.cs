using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairProduct;
using repair_management_backend.Repositories.RepairProductRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairProductController : ControllerBase
    {
        private readonly IRepairProductRepository _repairProductRepository;
        public RepairProductController(IRepairProductRepository repairProductRepository)
        {
            _repairProductRepository = repairProductRepository;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<string>>> AddRepairProduct([FromBody] List<AddRepairProductDTO> addRepairProductDTO)
        {
            var result = await _repairProductRepository.AddRepairProduct(addRepairProductDTO);
            if (result.Data is null)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
