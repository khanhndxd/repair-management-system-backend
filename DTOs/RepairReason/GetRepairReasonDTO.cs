using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairReason
{
    public class GetRepairReasonDTO
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Reason { get; set; }
    }
}
