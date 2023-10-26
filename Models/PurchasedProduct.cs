using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.Models
{
    public class PurchasedProduct
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string ProductName { get; set; }
        [MaxLength(255)]
        public string ProductSerial { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int PurchaseOrderId { get; set; }
        public DateTime WarrantyPeriod { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public virtual ICollection<RepairProduct> RepairProducts { get; set; }
    }
}
