using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class RepairType
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public List<RepairOrder>? RepairOrders { get; set; }
    }
}
