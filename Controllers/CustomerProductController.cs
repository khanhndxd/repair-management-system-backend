using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.CustomerProduct;
using repair_management_backend.Repositories.CustomerProductRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerProductController : ControllerBase
    {
        private readonly ICustomerProductRepository _customerProductRepository;
        public CustomerProductController(ICustomerProductRepository customerProductRepository)
        {
            _customerProductRepository = customerProductRepository;
        }
        [HttpPost]
        [Authorize(Policy = "NotTechnicianPolicy")]
        public async Task<IActionResult> AddCustomerProduct([FromBody] List<AddCustomerProductDTO> addCustomerProductDTOs)
        {
            var result = await _customerProductRepository.AddCustomerProduct(addCustomerProductDTOs);
            if (result.Success == false)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("Customer/{customerId}")]
        [Authorize(Policy = "NotTechnicianPolicy")]
        public async Task<IActionResult> GetCustomerProductByCustomerId(int customerId)
        {
            var result = await _customerProductRepository.GetCustomerProductsByCustomerId(customerId);
            if (result.Success == false)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
