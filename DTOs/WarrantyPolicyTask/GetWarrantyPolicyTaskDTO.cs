using repair_management_backend.DTOs.Task;

namespace repair_management_backend.DTOs.WarrantyPolicyTask
{
    public class GetWarrantyPolicyTaskDTO
    {
        public int Id { get; set; }
        public WarrantyPolicy WarrantyPolicy { get; set; }
        public GetTaskDTO Task { get; set; }
    }
}
