using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairTask
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [ForeignKey(nameof(Task))]
        public int TaskId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public RepairOrder RepairOrder { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Task Task { get; set; }
    }
}
