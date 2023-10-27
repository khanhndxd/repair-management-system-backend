namespace repair_management_backend.Repositories.RepairReasonRepo
{
    public class RepairReasonRepository : IRepairReasonRepository
    {
        private readonly DataContext _dataContext;
        public RepairReasonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<RepairReason>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<RepairReason>>();
            serviceResponse.Data = await _dataContext.RepairReasons.ToListAsync();
            return serviceResponse;
        }
    }
}
