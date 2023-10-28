using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.CustomerRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Customer>>>> Get()
        {
            return Ok(await _customerRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Customer>>> GetSingle(int id)
        {
            var result = await _customerRepository.GetCustomerById(id);
            if (result.Data is null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
