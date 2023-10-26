namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public class RepairOrderRepository : IRepairOrderRepository
    {
        private readonly DataContext _dataContext;
        public RepairOrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<RepairOrder>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<RepairOrder>>();
            serviceResponse.Data = await _dataContext.RepairOrders.ToListAsync();
            return serviceResponse;
        }
    }
}
