namespace repair_management_backend.Repositories.TaskRepo
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _dataContext;
        public TaskRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<Models.Task>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Models.Task>>();
            serviceResponse.Data = await _dataContext.Tasks.ToListAsync();
            return serviceResponse;
        }
    }
}
