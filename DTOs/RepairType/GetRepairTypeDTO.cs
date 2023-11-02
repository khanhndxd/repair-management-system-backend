using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.RepairType
{
    public class GetRepairTypeDTO
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
