using repair_management_backend.DTOs.RepairCustomerProduct;
using repair_management_backend.DTOs.RepairTask;

namespace repair_management_backend.Repositories.RepairCustomerProductRepo
{
    public class RepairCustomerProductRepository : IRepairCustomerProductRepository
    {
        private readonly DataContext _dataContext;
        public RepairCustomerProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<string>> AddRepairCustomerProduct(List<AddRepairCustomerProductDTO> addRepairCustomerProductDTOs)
        {
            var serviceResponse = new ServiceResponse<string>();

            if (addRepairCustomerProductDTOs.Count == 0)
            {
                serviceResponse.Data = "Thêm thành công sản phẩm vào đơn bảo hành";
                return serviceResponse;
            }

            using var transaction = _dataContext.Database.BeginTransaction();

            try
            {
                // Lấy ra danh sách RepairOrderId từ addRepairCustomerProductDTOs
                var repairOrderIds = addRepairCustomerProductDTOs.Select(dto => dto.RepairOrderId).ToList();

                // Xóa dữ liệu trong addRepairCustomerProductDTOs có RepairOrderId nằm trong danh sách trước khi thêm mới
                var repairCustomerProductsToDelete = _dataContext.RepairCustomerProducts.Where(ra => repairOrderIds.Contains(ra.RepairOrderId));
                _dataContext.RepairCustomerProducts.RemoveRange(repairCustomerProductsToDelete);

                await _dataContext.SaveChangesAsync();

                // Kiểm tra xem có product nào được thêm không
                if (addRepairCustomerProductDTOs[0].CustomerProductId != -1 && addRepairCustomerProductDTOs.Count >= 1)
                {
                    // Thêm dữ liệu mới
                    for (int i = 0; i < addRepairCustomerProductDTOs.Count; i++)
                    {
                        var repairCustomerProduct = new RepairCustomerProduct
                        {
                            CustomerProductId = addRepairCustomerProductDTOs[i].CustomerProductId,
                            RepairOrderId = addRepairCustomerProductDTOs[i].RepairOrderId,
                            Description = addRepairCustomerProductDTOs[i].Description
                        };
                        _dataContext.RepairCustomerProducts.Add(repairCustomerProduct);

                        // cứ thêm 10 data vào bộ nhớ thì sẽ lưu vào database
                        if (i % 10 == 0)
                        {
                            await _dataContext.SaveChangesAsync();
                        }
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
