using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.RepairCustomerProduct;
using repair_management_backend.Repositories.RepairCustomerProductRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairCustomerProductController : ControllerBase
    {
        private readonly IRepairCustomerProductRepository _repairCustomerProductRepository;
        public RepairCustomerProductController(IRepairCustomerProductRepository repairCustomerProductRepository)
        {
            _repairCustomerProductRepository = repairCustomerProductRepository;
        }
        [HttpPost]
        public async Task<IActionResult> AddRepairCustomerProduct([FromBody] List<AddRepairCustomerProductDTO> addRepairCustomerProductDTOs)
        {
            var result = await _repairCustomerProductRepository.AddRepairCustomerProduct(addRepairCustomerProductDTOs);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
