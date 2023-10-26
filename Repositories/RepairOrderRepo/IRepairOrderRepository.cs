namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public interface IRepairOrderRepository
    {
        Task<ServiceResponse<List<RepairOrder>>> GetAll();
        Task<ServiceResponse<RepairOrder>> GetRepairOrderById(int id);
    }
}
