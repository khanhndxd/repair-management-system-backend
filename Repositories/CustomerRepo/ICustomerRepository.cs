using repair_management_backend.DTOs.Customer;

namespace repair_management_backend.Repositories.CustomerRepo
{
    public interface ICustomerRepository
    {
        Task<ServiceResponse<List<Customer>>> GetAll();
        Task<ServiceResponse<Customer>> GetCustomerById(int id);
        Task<ServiceResponse<string>> AddCustomer(AddCustomerDTO newCustomer);
    }
}
