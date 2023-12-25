using System.Data;

namespace repair_management_backend.Repositories.StatusRepo
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _dataContext;
        public StatusRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<Status>>> GetAll(List<string> roles)
        {
            var serviceResponse = new ServiceResponse<List<Status>>();
            if (roles.Contains("Admin"))
            {
                serviceResponse.Data = await _dataContext.Statuses.ToListAsync();
            }
            else if (roles.Contains("Technician"))
            {
                serviceResponse.Data = await _dataContext.Statuses.Where(t => t.Id >= 6 && t.Id <= 9).ToListAsync();
            } else if (roles.Contains("Receiver"))
            {
                serviceResponse.Data = await _dataContext.Statuses.Where(t => t.Id >= 2 && t.Id <= 5).ToListAsync();
            } else if (roles.Contains("Creator"))
            {
                serviceResponse.Data = await _dataContext.Statuses.Where(t => t.Id >= 10).ToListAsync();
            } else
            {
                serviceResponse.Data = await _dataContext.Statuses.Where(t => t.Id >= 10).ToListAsync();
            }
            return serviceResponse;
        }
    }
}
