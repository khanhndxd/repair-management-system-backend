using repair_management_backend.DTOs.RepairLog;

namespace repair_management_backend.Repositories.RepairLogRepo
{
    public interface IRepairLogRepository
    {
        Task<ServiceResponse<List<GetRepairLogDTO>>> GetRepairLogByRepairOrderId(int id);
        Task<ServiceResponse<string>> AddRepairLog(AddRepairLogDTO addRepairLogDTO);
    }
}
