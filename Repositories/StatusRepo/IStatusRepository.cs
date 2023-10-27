namespace repair_management_backend.Repositories.StatusRepo
{
    public interface IStatusRepository
    {
        Task<ServiceResponse<List<Status>>> GetAll();
    }
}
