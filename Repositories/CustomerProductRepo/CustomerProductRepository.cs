using AutoMapper;
using repair_management_backend.DTOs.CustomerProduct;
using repair_management_backend.DTOs.PurchaseOrder;

namespace repair_management_backend.Repositories.CustomerProductRepo
{
    public class CustomerProductRepository : ICustomerProductRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public CustomerProductRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<string>> AddCustomerProduct(List<AddCustomerProductDTO> addCustomerProductDTOs)
        {
            var serviceResponse = new ServiceResponse<string>();

            if (addCustomerProductDTOs.Count == 0)
            {
                serviceResponse.Data = "Thêm thành công sản phẩm cho khách hàng";
                return serviceResponse;
            }

            using var transaction = _dataContext.Database.BeginTransaction();

            try
            {
                // Thêm dữ liệu mới
                for (int i = 0; i < addCustomerProductDTOs.Count; i++)
                {
                    var customerProduct = new CustomerProduct
                    {
                        CustomerId = addCustomerProductDTOs[i].CustomerId,
                        Name = addCustomerProductDTOs[i].Name,
                        Note = addCustomerProductDTOs[i].Note,

                    };
                    _dataContext.CustomerProducts.Add(customerProduct);

                    // cứ thêm 10 data vào bộ nhớ thì sẽ lưu vào database
                    if (i % 10 == 0)
                    {
                        await _dataContext.SaveChangesAsync();
                    }
                }

                await _dataContext.SaveChangesAsync();
                transaction.Commit();
                serviceResponse.Data = "Thêm thành công sản phẩm cho khách hàng";
                serviceResponse.Message = "Thêm thành công sản phẩm cho khách hàng";
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi trong quá trình thêm dữ liệu vào database, quá trình sẽ được Rollback";
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCustomerProductDTO>>> GetCustomerProductsByCustomerId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCustomerProductDTO>>();
            try
            {
                var result = await _dataContext.CustomerProducts.Where(x => x.CustomerId == id).Select(x => _mapper.Map<GetCustomerProductDTO>(x)).ToListAsync();
                if (result.Count == 0)
                {
                    throw new Exception($"Không tìm thấy sản phẩm nào của khách hàng có id là `{id}`");
                }
                serviceResponse.Data = result;
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
