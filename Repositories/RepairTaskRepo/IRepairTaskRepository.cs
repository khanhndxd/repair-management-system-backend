using repair_management_backend.DTOs.RepairTask;

namespace repair_management_backend.Repositories.RepairTask
{
    public interface IRepairTaskRepository
    {
        Task<ServiceResponse<string>> AddRepairTask(List<AddRepairTaskDTO> addRepairTaskDTOs);
    }
}
