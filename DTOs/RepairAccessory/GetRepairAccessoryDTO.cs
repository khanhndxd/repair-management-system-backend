using repair_management_backend.DTOs.Accessory;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.DTOs.RepairAccessory
{
    public class GetRepairAccessoryDTO
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        public int Quantity { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public GetAccessoryDTO Accessory { get; set; }
    }
}
