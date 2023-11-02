using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Manufacturer
{
    public class GetManufacturerDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
