using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Status
{
    public class GetStatusDTO
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
