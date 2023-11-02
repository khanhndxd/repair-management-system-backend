using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using repair_management_backend.DTOs.PurchasedProduct;

namespace repair_management_backend.DTOs.RepairProduct
{
    public class GetRepairProductDTO
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        public GetPurchasedProductDTO PurchasedProduct { get; set; }
    }
}
