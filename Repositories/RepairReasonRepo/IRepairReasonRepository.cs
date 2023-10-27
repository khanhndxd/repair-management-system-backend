namespace repair_management_backend.Repositories.RepairReasonRepo
{
    public interface IRepairReasonRepository
    {
        Task<ServiceResponse<List<RepairReason>>> GetAll();
    }
}
