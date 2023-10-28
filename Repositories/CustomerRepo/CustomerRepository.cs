namespace repair_management_backend.Repositories.CustomerRepo
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;
        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<Customer>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Customer>>();
            serviceResponse.Data = await _dataContext.Customers.ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<Customer>> GetCustomerById(int id)
        {
            var serviceResponse = new ServiceResponse<Customer>();
            try
            {
                var result = await _dataContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
                if (result is null)
                {
                    throw new Exception($"Không tìm thấy khách hàng có id là `{id}`");
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
