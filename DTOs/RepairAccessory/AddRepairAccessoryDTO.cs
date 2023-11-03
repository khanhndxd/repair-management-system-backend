using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.DTOs.RepairAccessory
{
    public class AddRepairAccessoryDTO
    {
        public int RepairOrderId { get; set; }
        public int AccessoryId { get; set; }
        public int Quantity { get; set; }
    }
}
