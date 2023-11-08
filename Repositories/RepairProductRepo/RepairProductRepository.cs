using repair_management_backend.Data;
using repair_management_backend.DTOs.RepairAccessory;
using repair_management_backend.DTOs.RepairProduct;

namespace repair_management_backend.Repositories.RepairProductRepo
{
    public class RepairProductRepository : IRepairProductRepository
    {
        private readonly DataContext _dataContext;
        public RepairProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<string>> AddRepairProduct(List<AddRepairProductDTO> addRepairProductDTO)
        {
            var serviceResponse = new ServiceResponse<string>();

            if (addRepairProductDTO.Count == 0)
            {
                serviceResponse.Data = "Thêm thành công sản phẩm vào đơn bảo hành";
                return serviceResponse;
            }

            using var transaction = _dataContext.Database.BeginTransaction();

            try
            {
                // Lấy ra danh sách RepairOrderId từ addRepairAccessoryDTO
                var repairOrderIds = addRepairProductDTO.Select(dto => dto.RepairOrderId).ToList();

                // Xóa dữ liệu trong RepairProduct có RepairOrderId nằm trong danh sách trước khi thêm mới
                var repairProductsToDelete = _dataContext.RepairProducts.Where(ra => repairOrderIds.Contains(ra.RepairOrderId));
                _dataContext.RepairProducts.RemoveRange(repairProductsToDelete);

                await _dataContext.SaveChangesAsync();

                // Thêm dữ liệu mới
                for (int i = 0; i < addRepairProductDTO.Count; i++)
                {
                    var repairProduct = new RepairProduct
                    {
                        PurchasedProductId = addRepairProductDTO[i].PurchasedProductId,
                        RepairOrderId = addRepairProductDTO[i].RepairOrderId,
                        Description = addRepairProductDTO[i].Description
                    };
                    _dataContext.RepairProducts.Add(repairProduct);

                    // cứ thêm 10 sản phẩm vào bộ nhớ thì sẽ lưu vào database
                    if (i % 10 == 0)
                    {
                        await _dataContext.SaveChangesAsync();
                    }
                }

                await _dataContext.SaveChangesAsync();
                transaction.Commit();
                serviceResponse.Data = "Thêm thành công sản phẩm vào đơn bảo hành";
                serviceResponse.Message = "Thêm thành công sản phẩm vào đơn bảo hành";
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi trong quá trình thêm dữ liệu vào database, quá trình sẽ được Rollback";
            }
            return serviceResponse;
        }
    }
}