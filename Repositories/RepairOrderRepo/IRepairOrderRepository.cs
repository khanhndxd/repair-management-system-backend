using repair_management_backend.DTOs.RepairOrder;

namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public interface IRepairOrderRepository
    {
        Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll();
        Task<ServiceResponse<GetRepairOrderDTO>> GetRepairOrderById(int id);
        Task<ServiceResponse<int>> AddRepairOrder(AddRepairOrderDTO newRepairOrder);
        Task<ServiceResponse<string>> UpdateRepairOrderStatus(UpdateRepairOrderStatusDTO updateRepairOrderStatusDTO);
        Task<ServiceResponse<string>> UpdateRepairOrder(UpdateRepairOrderDTO updateRepairOrderDTO);
    }
}
