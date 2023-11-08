using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairProduct
{
    public class AddRepairProductDTO
    {
        public int RepairOrderId { get; set; }
        public int PurchasedProductId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
    }
}
