using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using repair_management_backend.DTOs.CustomerProduct;

namespace repair_management_backend.DTOs.RepairCustomerProduct
{
    public class GetRepairCustomerProductDTO
    {
        public int Id { get; set; }
        [ForeignKey(nameof(RepairOrder))]
        public int RepairOrderId { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public GetCustomerProductDTO CustomerProduct { get; set; }
    }
}
