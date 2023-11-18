using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repair_management_backend.DTOs.CustomerProduct
{
    public class AddCustomerProductDTO
    {
        public string Name { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
    }
}
