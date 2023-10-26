using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairAccessory
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [ForeignKey(nameof(Accessory))]
        public int AccessoryId { get; set; }
        public int Quantity { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public RepairOrder RepairOrder { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public Accessory Accessory { get; set; }
    }
}
