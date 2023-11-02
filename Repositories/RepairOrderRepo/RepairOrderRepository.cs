using AutoMapper;
using repair_management_backend.DTOs.RepairOrder;

namespace repair_management_backend.Repositories.RepairOrderRepo
{
    public class RepairOrderRepository : IRepairOrderRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public RepairOrderRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<string>> AddRepairOrder(RepairOrderFullDTO newRepairOrder)
        {
            var serviceResponse = new ServiceResponse<string>();
            var repairOrder = new RepairOrder
            {
                CustomerId = newRepairOrder.CustomerId,
                CreatedById = newRepairOrder.CreatedById,
                RepairedById = newRepairOrder.RepairedById,
                CreatedAt = newRepairOrder.CreatedAt,
                ReceiveAt = newRepairOrder.ReceiveAt,
                ReceiveType = newRepairOrder.ReceiveType,
                TotalPrice = newRepairOrder.TotalPrice,
                StatusId = newRepairOrder.StatusId,
                RepairTypeId = newRepairOrder.RepairTypeId,
                RepairReasonId = newRepairOrder.RepairReasonId,
                TaskId = newRepairOrder.TaskId,
                Note = newRepairOrder.Note
            };

            _dataContext.RepairOrders.Add(repairOrder);
            await _dataContext.SaveChangesAsync();

            int repairOrderId = repairOrder.Id;

            var repairProduct = new RepairProduct
            {
                RepairOrderId = repairOrderId,
                PurchasedProductId = newRepairOrder.ProductId,
                Description = newRepairOrder.ProductDescription,
            };

            _dataContext.RepairProducts.Add(repairProduct);
            await _dataContext.SaveChangesAsync();

            serviceResponse.Data = "Tạo thành công đơn bảo hành";
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<GetRepairOrderDTO>>();
            serviceResponse.Data = await _dataContext.RepairOrders
                .Include(r => r.Customer)
                .Include(r => r.RepairReason)
                .Include(r => r.RepairType)
                .Include(r => r.Task)
                .Include(r => r.Status)
                .Include(r => r.CreatedBy)
                .Include(r => r.RepairedBy)
                .Include(r => r.RepairProducts)
                .Include(r => r.RepairAccessories)
                .Select(r => _mapper.Map<GetRepairOrderDTO>(r))
                .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRepairOrderDTO>> GetRepairOrderById(int id)
        {
            var serviceResponse = new ServiceResponse<GetRepairOrderDTO>();
            try
            {
                var result = await _dataContext.RepairOrders
                    .Include(r => r.Customer)
                    .Include(r => r.RepairReason)
                    .Include(r => r.RepairType)
                    .Include(r => r.Task)
                    .Include(r => r.Status)
                    .Include(r => r.CreatedBy)
                    .Include(r => r.RepairedBy)
                    .Include(r => r.RepairProducts)
                    .Include(r => r.RepairAccessories)
                    .Select(r => _mapper.Map<GetRepairOrderDTO>(r))
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (result is null)
                {
                    throw new Exception($"Không tìm thấy đơn sửa chữa có id là `{id}`");
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
