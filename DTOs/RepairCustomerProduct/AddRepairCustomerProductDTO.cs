using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairCustomerProduct
{
    public class AddRepairCustomerProductDTO
    {
        public int RepairOrderId { get; set; }
        public int CustomerProductId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
    }
}
