using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.PurchasedProduct
{
    public class GetPurchasedProductDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string ProductName { get; set; }
        [MaxLength(255)]
        public string ProductSerial { get; set; }
        public double Price { get; set; }
        public DateTime WarrantyPeriod { get; set; }
        public virtual ICollection<RepairProduct> RepairProducts { get; set; }
    }
}
