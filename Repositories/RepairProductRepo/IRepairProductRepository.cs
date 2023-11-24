using repair_management_backend.DTOs.RepairProduct;

namespace repair_management_backend.Repositories.RepairProductRepo
{
    public interface IRepairProductRepository
    {
        Task<ServiceResponse<string>> AddRepairProduct(List<AddRepairProductDTO> addRepairProductDTOs);
    }
}