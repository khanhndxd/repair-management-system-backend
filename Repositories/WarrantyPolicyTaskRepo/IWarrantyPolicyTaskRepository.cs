using repair_management_backend.DTOs.WarrantyPolicyTask;

namespace repair_management_backend.Repositories.WarrantyPolicyTaskRepo
{
    public interface IWarrantyPolicyTaskRepository
    {
        Task<ServiceResponse<List<GetWarrantyPolicyTaskDTO>>> GetWarrantyPolicyTasksByPolicyId(int id);
    }
}
