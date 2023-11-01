using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.PurchaseOrder;
using repair_management_backend.Repositories.PurchaseOrderRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderRepository _purchaseOrderRepository;
        public PurchaseOrderController(IPurchaseOrderRepository purchaseOrderRepository)
        {
            _purchaseOrderRepository = purchaseOrderRepository;
        }
        [HttpGet("Customer/{customerId}")]
        public async Task<ActionResult<ServiceResponse<List<GetPurchaseOrderDTO>>>> GetPurchaseOrderByCustomerId(int customerId)
        {
            var result = await _purchaseOrderRepository.GetPurchaseOrdersByCustomerId(customerId);
            if (result.Data is null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }
    }
}
