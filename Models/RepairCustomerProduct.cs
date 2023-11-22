using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.Models
{
    public class RepairCustomerProduct
    {
        public int Id { get; set; }
        [ForeignKey(nameof(CustomerProduct))]
        public int CustomerProductId { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public CustomerProduct CustomerProduct { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public RepairOrder RepairOrder { get; set; }
    }
}
