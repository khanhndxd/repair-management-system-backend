using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairTask
{
    public class AddRepairTaskDTO
    {
        public int RepairOrderId { get; set; }
        public int TaskId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
    }
}
