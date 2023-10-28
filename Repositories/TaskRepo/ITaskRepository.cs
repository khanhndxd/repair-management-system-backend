namespace repair_management_backend.Repositories.TaskRepo
{
    public interface ITaskRepository
    {
        Task<ServiceResponse<List<Models.Task>>> GetAll();
    }
}
