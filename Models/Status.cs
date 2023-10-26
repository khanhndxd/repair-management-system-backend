using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class Status
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<RepairOrder>? RepairOrders { get; set; }
    }
}
