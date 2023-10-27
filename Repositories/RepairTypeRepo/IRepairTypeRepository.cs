namespace repair_management_backend.Repositories.RepairTypeRepo
{
    public interface IRepairTypeRepository
    {
        Task<ServiceResponse<List<RepairType>>> GetAll();
    }
}
