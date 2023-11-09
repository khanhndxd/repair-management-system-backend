using repair_management_backend.DTOs.PurchaseOrder;
using repair_management_backend.DTOs.RepairOrder;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Customer
{
    public class GetCustomerDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Phone { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Note { get; set; } = string.Empty;
        public List<GetPurchaseOrderNoCustomerDTO>? PurchaseOrders { get; set; }
        public List<GetRepairOrderNoCustomerDTO>? RepairOrders { get; set; }
    }
}
