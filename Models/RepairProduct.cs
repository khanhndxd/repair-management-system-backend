using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairProduct
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [ForeignKey(nameof(PurchasedProduct))]
        public int PurchasedProductId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public RepairOrder RepairOrder { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)] 
        public PurchasedProduct PurchasedProduct { get; set; }
    }
}
