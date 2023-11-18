using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.CustomerProduct
{
    public class GetCustomerProductDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Note { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
    }
}
