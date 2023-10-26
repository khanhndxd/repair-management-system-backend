namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public interface IRepairOrderRepository
    {
        Task<ServiceResponse<List<RepairOrder>>> GetAll();
    }
}
