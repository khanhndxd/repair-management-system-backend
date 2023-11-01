using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.Customer;

namespace repair_management_backend.Repositories.CustomerRepo
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CustomerRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<string>> AddCustomer(AddCustomerDTO newCustomer)
        {
            var serviceResponse = new ServiceResponse<string>();
            var customer =_mapper.Map<Customer>(newCustomer);

            _dataContext.Customers.Add(customer);
            await _dataContext.SaveChangesAsync();

            serviceResponse.Data = "Tạo thành công khách hàng";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Customer>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<Customer>>();
            serviceResponse.Data = await _dataContext.Customers.ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCustomerDTO>> GetCustomerById(int id)
        {
            var serviceResponse = new ServiceResponse<GetCustomerDTO>();
            try
            {
                var result = await _dataContext.Customers.Select(c => _mapper.Map<GetCustomerDTO>(c)).FirstOrDefaultAsync(c => c.Id == id);
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
