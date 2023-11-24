using repair_management_backend.DTOs.CustomerProduct;

namespace repair_management_backend.Repositories.CustomerProductRepo
{
    public interface ICustomerProductRepository
    {
        Task<ServiceResponse<string>> AddCustomerProduct(List<AddCustomerProductDTO> addCustomerProductDTOs);
        Task<ServiceResponse<List<GetCustomerProductDTO>>> GetCustomerProductsByCustomerId(int id);
    }
}
