using repair_management_backend.DTOs.PurchaseOrder;

namespace repair_management_backend.Repositories.PurchaseOrderRepo
{
    public interface IPurchaseOrderRepository
    {
        Task<ServiceResponse<List<GetPurchaseOrderDTO>>> GetPurchaseOrdersByCustomerId(int id);
    }
}
