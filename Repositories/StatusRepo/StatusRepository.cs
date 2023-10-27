namespace repair_management_backend.Repositories.StatusRepo
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _dataContext;
        public StatusRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<Status>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Status>>();
            serviceResponse.Data = await _dataContext.Statuses.ToListAsync();
            return serviceResponse;
        }
    }
}
