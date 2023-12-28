using repair_management_backend.DTOs.RepairReason;

namespace repair_management_backend.Repositories.RepairReasonRepo
{
    public interface IRepairReasonRepository
    {
        Task<ServiceResponse<List<RepairReason>>> GetAll();
        Task<ServiceResponse<string>> AddRepairReason(AddRepairReasonDTO addRepairReasonDTO);
        Task<ServiceResponse<string>> UpdateRepairReason(UpdateRepairReasonDTO updateRepairReasonDTO);
        Task<ServiceResponse<string>> DeleteRepairReason(DeleteRepairReasonDTO deleteRepairReasonDTO);
    }
}
