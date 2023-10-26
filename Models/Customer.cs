using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class Customer
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
        public List<PurchaseOrder>? PurchaseOrders { get; set; }
        public List<RepairOrder>? RepairOrders { get; set; }
    }
}
