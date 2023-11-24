using repair_management_backend.DTOs.RepairCustomerProduct;
using repair_management_backend.DTOs.RepairProduct;

namespace repair_management_backend.Repositories.RepairCustomerProductRepo
{
    public interface IRepairCustomerProductRepository
    {
        Task<ServiceResponse<string>> AddRepairCustomerProduct(List<AddRepairCustomerProductDTO> addRepairCustomerProductDTOs);
    }
}
