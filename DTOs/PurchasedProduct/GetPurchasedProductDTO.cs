using repair_management_backend.DTOs.Category;
using repair_management_backend.DTOs.Manufacturer;
using repair_management_backend.DTOs.RepairProduct;
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
        public GetCategoryDTO Category { get; set; }
        public GetManufacturerDTO Manufacturer { get; set; }
    }
}
