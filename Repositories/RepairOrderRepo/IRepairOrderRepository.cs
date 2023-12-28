using repair_management_backend.DTOs.RepairOrder;

namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public interface IRepairOrderRepository
    {
        Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll(string userId, List<string> roles, string fieldQuery, string timeQuery, string startDateQuery, string endDateQuery);
        Task<ServiceResponse<GetRepairOrderDTO>> GetRepairOrderById(int id);
        Task<ServiceResponse<int>> GetRepairOrderByStatus(string userId, List<string> roles, int id);
        Task<ServiceResponse<double>> GetTotalPrice();
        Task<ServiceResponse<List<RepairCategoryStatsDTO>>> GetRepairCategoryStat();
        Task<ServiceResponse<int>> AddRepairOrder(AddRepairOrderDTO newRepairOrder);
        Task<ServiceResponse<string>> UpdateRepairOrderStatus(UpdateRepairOrderStatusDTO updateRepairOrderStatusDTO);
        Task<ServiceResponse<string>> UpdateRepairOrder(UpdateRepairOrderDTO updateRepairOrderDTO);
        Task<ServiceResponse<string>> DeleteRepairOrder(DeleteRepairOrderDTO deleteRepairOrderDTO);
        Task<ServiceResponse<string>> UpdateTotalPrice(UpdateTotalPriceDTO updateTotalPriceDTO);
    }
}
