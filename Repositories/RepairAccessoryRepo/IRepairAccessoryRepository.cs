using repair_management_backend.DTOs.RepairAccessory;

namespace repair_management_backend.Repositories.RepairAccessoryRepo
{
    public interface IRepairAccessoryRepository
    {
        Task<ServiceResponse<List<GetRepairAccessoryDTO>>> GetRepairAccessoryByRepairOrderId(int id);
        Task<ServiceResponse<string>> AddRepairAccessory(List<AddRepairAccessoryDTO> addRepairAccessoryDTO);
    }
}
