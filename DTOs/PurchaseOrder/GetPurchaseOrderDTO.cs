using repair_management_backend.DTOs.Customer;
using repair_management_backend.DTOs.PurchasedProduct;

namespace repair_management_backend.DTOs.PurchaseOrder
{
    public class GetPurchaseOrderDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public GetCustomerDTO Customer { get; set; }
        public List<GetPurchasedProductDTO> PurchaseProducts { get; set; }
    }
}
