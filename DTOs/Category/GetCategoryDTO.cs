using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Category
{
    public class GetCategoryDTO
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public WarrantyPolicy WarrantyPolicy { get; set; }
    }
}
