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

        public async Task<ServiceResponse<RepairOrder>> GetRepairOrderById(int id)
        {
            var serviceResponse = new ServiceResponse<RepairOrder>();
            try
            {
                var result = await _dataContext.RepairOrders.FirstOrDefaultAsync(x => x.Id == id);
                if (result is null)
                {
                    throw new Exception($"Không tìm thấy đơn sửa chữa có id là `{id}`");
                }
                serviceResponse.Data = result;

            } catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
