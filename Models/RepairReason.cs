using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class RepairReason
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Reason { get; set; }
        public List<RepairOrder>? RepairOrders { get; set; }
    }
}
