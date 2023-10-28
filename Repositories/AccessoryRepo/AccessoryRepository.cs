namespace repair_management_backend.Repositories.AccessoryRepo
{
    public class AccessoryRepository : IAccessoryRepository
    {
        private readonly DataContext _dataContext;
        public AccessoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<Accessory>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Accessory>>();
            serviceResponse.Data = await _dataContext.Accessories.ToListAsync();
            return serviceResponse;
        }
    }
}
