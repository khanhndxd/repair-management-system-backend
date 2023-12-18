using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairLog
    {
        public int Id { get; set; }
        public int RepairOrderId { get; set; }
        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        [MaxLength(255)]
        public string Info { get; set; }
    }
}
