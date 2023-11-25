using repair_management_backend.DTOs.RepairOrder;

namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public interface IRepairOrderRepository
    {
        Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll(string fieldQuery, string timeQuery);
        Task<ServiceResponse<GetRepairOrderDTO>> GetRepairOrderById(int id);
        Task<ServiceResponse<int>> GetRepairOrderByStatus(int id);
        Task<ServiceResponse<double>> GetTotalPrice();
        Task<ServiceResponse<int>> AddRepairOrder(AddRepairOrderDTO newRepairOrder);
        Task<ServiceResponse<string>> UpdateRepairOrderStatus(UpdateRepairOrderStatusDTO updateRepairOrderStatusDTO);
        Task<ServiceResponse<string>> UpdateRepairOrder(UpdateRepairOrderDTO updateRepairOrderDTO);
        Task<ServiceResponse<string>> DeleteRepairOrder(DeleteRepairOrderDTO deleteRepairOrderDTO);
    }
}
