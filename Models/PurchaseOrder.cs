using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public Customer Customer { get; set; }
        public List<PurchasedProduct> PurchaseProducts { get; set; }
    } 
}
