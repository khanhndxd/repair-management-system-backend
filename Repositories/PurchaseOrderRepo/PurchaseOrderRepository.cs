using AutoMapper;
using repair_management_backend.DTOs.PurchasedProduct;
using repair_management_backend.DTOs.PurchaseOrder;

namespace repair_management_backend.Repositories.PurchaseOrderRepo
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public PurchaseOrderRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetPurchaseOrderDTO>>> GetPurchaseOrdersByCustomerId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetPurchaseOrderDTO>>();
            try
            {
                var result = await _dataContext.PurchaseOrders
                    .Include(x => x.Customer)
                    .Include(x => x.PurchaseProducts)
                        .ThenInclude(x => x.Category).ThenInclude(x => x.WarrantyPolicy)
                    .Where(x => x.CustomerId == id)
                    .ToListAsync();

                if (result.Count == 0)
                {
                    throw new Exception($"Không tìm thấy đơn sửa chữa bảo dưỡng nào của khách hàng có id là `{id}`");
                }

                // Lấy danh sách tên sản phẩm từ tất cả các đơn hàng
                var purchasedProductNames = result.SelectMany(po => po.PurchaseProducts.Select(pp => pp.ProductName)).ToList();

                // Truy vấn bảng Accessory để lấy giá gốc
                var accessoryPrices = await _dataContext.Accessories
                    .Where(a => purchasedProductNames.Contains(a.Name))
                    .ToDictionaryAsync(a => a.Name, a => a.Price);

                // Tạo danh sách DTO từ danh sách đơn hàng
                var dtos = result.Select(po =>
                {
                    var purchaseProducts = po.PurchaseProducts.Select(pp =>
                    {
                        var purchasedProductDto = _mapper.Map<GetPurchasedProductDTO>(pp);
                        var priceKeyValuePair = accessoryPrices.FirstOrDefault(kv =>
                            string.Equals(kv.Key, pp.ProductName, StringComparison.OrdinalIgnoreCase));

                        // Thêm trường giá gốc
                        if (!string.IsNullOrEmpty(priceKeyValuePair.Key))
                        {
                            purchasedProductDto.OriginalPrice = priceKeyValuePair.Value;
                        }
                        else
                        {
                            // Xử lý trường hợp không tìm thấy giá gốc cho sản phẩm
                            purchasedProductDto.OriginalPrice = 0;
                        }
                        // Kiểm tra trạng thái hết hạn bảo hành
                        purchasedProductDto.IsWarrantyExpired = DateTime.UtcNow > pp.WarrantyPeriod;

                        // Tính số ngày còn lại trong bảo hành
                        purchasedProductDto.DaysLeftInWarranty = (int)(pp.WarrantyPeriod - DateTime.UtcNow).TotalDays;
                        return purchasedProductDto;
                    }).ToList();

                    var dto = _mapper.Map<GetPurchaseOrderDTO>(po);
                    // Thêm danh sách PurchaseProducts với giá gốc vào DTO
                    dto.PurchaseProducts = purchaseProducts;

                    return dto;
                }).ToList();

                serviceResponse.Data = dtos;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
