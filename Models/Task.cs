using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class Task
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public List<RepairOrder>? RepairOrders { get; set; }
    }
}
