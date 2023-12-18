using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using repair_management_backend.DTOs.User;

namespace repair_management_backend.DTOs.RepairLog
{
    public class GetRepairLogDTO
    {
        public int Id { get; set; }
        public int RepairOrderId { get; set; }
        public virtual GetUserDTO CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        [MaxLength(255)]
        public string Info { get; set; }
    }
}
