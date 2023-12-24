using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.WarrantyPolicyTaskRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyPolicyTaskController : ControllerBase
    {
        private readonly IWarrantyPolicyTaskRepository _warrantyPolicyTaskRepository;
        public WarrantyPolicyTaskController(IWarrantyPolicyTaskRepository warrantyPolicyTaskRepository)
        {
            _warrantyPolicyTaskRepository = warrantyPolicyTaskRepository;
        }
        [HttpGet("WarrantyPolicy/{id}")]
        public async Task<IActionResult> GetWarrantyPolicyTasksByPolicyId(int id)
        {
            var result = await _warrantyPolicyTaskRepository.GetWarrantyPolicyTasksByPolicyId(id);
            if (result.Success == false)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
