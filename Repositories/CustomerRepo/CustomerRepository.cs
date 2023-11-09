using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.DTOs.Customer;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.Models;

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
                var result_1 = await _dataContext.Customers
                    .Include(c => c.PurchaseOrders)
                        .ThenInclude(c => c.PurchaseProducts)
                    .Include(c => c.RepairOrders)
                        .ThenInclude(c => c.RepairProducts)
                    .Include(c => c.RepairOrders)
                        .ThenInclude(c => c.RepairAccessories)
                    .Include(c => c.RepairOrders)
                        .ThenInclude(c => c.CreatedBy)
                    .Include(c => c.RepairOrders)
                        .ThenInclude(c => c.RepairedBy)
                    .Include(c => c.RepairOrders)
                        .ThenInclude(c => c.Status)
                    .Where(r => r.Id == id)
                    .ToListAsync();

                var result = _mapper.Map<GetCustomerDTO>(result_1.FirstOrDefault());

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

        public async Task<ServiceResponse<string>> UpdateCustomer(UpdateCustomerDTO updateCustomerDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var customer = await _dataContext.Customers.FirstOrDefaultAsync(c => c.Id == updateCustomerDTO.Id);
                if (customer is null)
                {
                    throw new Exception($"Không tìm thấy khách hàng có id là '{updateCustomerDTO.Id}'");
                }
                _mapper.Map(updateCustomerDTO, customer);

                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = "Cập nhật thông tin khách hàng thành công";
                serviceResponse.Message = "Cập nhật thông tin khách hàng thành công";

            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
