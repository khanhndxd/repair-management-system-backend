namespace repair_management_backend.Repositories.AccessoryRepo
{
    public interface IAccessoryRepository
    {
        Task<ServiceResponse<List<Accessory>>> GetAll();
    }
}
