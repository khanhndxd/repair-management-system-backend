using System.ComponentModel.DataAnnotations;

namespace repair_management_backend.DTOs.Task
{
    public class GetTaskDTO
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
