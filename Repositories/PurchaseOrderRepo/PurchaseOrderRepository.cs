using AutoMapper;
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
                var result = await  _dataContext.PurchaseOrders.Include(x => x.Customer).Include(x => x.PurchaseProducts).Where(x => x.CustomerId == id).Select(x => _mapper.Map<GetPurchaseOrderDTO>(x)).ToListAsync();
                if(result.Count == 0)
                {
                    throw new Exception($"Không tìm thấy đơn sửa chữa bảo dưỡng nào của khách hàng có id là `{id}`");
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
