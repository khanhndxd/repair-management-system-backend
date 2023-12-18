using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<PurchasedProduct>? PurchasedProducts { get; set; }
        public WarrantyPolicy WarrantyPolicy { get; set; }
    }
}
