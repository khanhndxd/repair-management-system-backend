using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }
        [ForeignKey("RepairedBy")]
        public string RepairedById { get; set; }
        public virtual User RepairedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReceiveAt { get; set; }
        [MaxLength(255)]
        public string ReceiveType { get; set; }
        public double TotalPrice { get; set; }
        public int StatusId { get; set; }
        public int RepairTypeId { get; set; }
        public int RepairReasonId { get; set; }
        public int TaskId { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        public Customer Customer { get; set; }
        public Status Status { get; set; }
        public RepairType RepairType { get; set; }
        public RepairReason RepairReason { get; set; }
        public Task Task { get; set; }
        public virtual ICollection<RepairProduct> RepairProducts { get; set; }
        public virtual ICollection<RepairAccessory> RepairAccessories { get; set; }
    }
}
