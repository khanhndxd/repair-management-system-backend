using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairLog
{
    public class AddRepairLogDTO
    {
        public int RepairOrderId { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        [MaxLength(255)]
        public string Info { get; set; }
    }
}
