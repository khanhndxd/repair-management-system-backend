using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public List<PurchasedProduct>? PurchasedProducts { get; set; }
    }
}
