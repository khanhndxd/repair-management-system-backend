using repair_management_backend.DTOs.Task;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.DTOs.RepairTask
{
    public class GetRepairTaskDTO
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public GetTaskDTO Task { get; set; }
    }
}
