using repair_management_backend.DTOs.RepairAccessory;

namespace repair_management_backend.Repositories.RepairAccessoryRepo
{
    public class RepairAccessoryRepository : IRepairAccessoryRepository
    {
        public Task<ServiceResponse<string>> AddRepairAccessory(AddRepairAccessoryDTO addRepairAccessoryDTO)
        {
            var serviceResponse = new ServiceResponse<string>();

        }

        public Task<ServiceResponse<List<GetRepairAccessoryDTO>>> GetRepairAccessoryByRepairOrderId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetRepairAccessoryDTO>>();
        }
    }
}
