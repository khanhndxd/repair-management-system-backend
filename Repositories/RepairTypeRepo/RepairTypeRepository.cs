namespace repair_management_backend.Repositories.RepairTypeRepo
{
    public class RepairTypeRepository : IRepairTypeRepository
    {
        private readonly DataContext _dataContext;
        public RepairTypeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<RepairType>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<RepairType>>();
            serviceResponse.Data = await _dataContext.RepairTypes.ToListAsync();
            return serviceResponse;
        }
    }
}
