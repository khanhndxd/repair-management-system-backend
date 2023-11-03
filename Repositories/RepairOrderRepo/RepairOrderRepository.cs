using AutoMapper;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.Models;

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
                    .ThenInclude(rp => rp.PurchasedProduct)
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
                var result_1 = await _dataContext.RepairOrders
                    .Include(r => r.Customer)
                    .Include(r => r.RepairReason)
                    .Include(r => r.RepairType)
                    .Include(r => r.Task)
                    .Include(r => r.Status)
                    .Include(r => r.CreatedBy)
                    .Include(r => r.RepairedBy)
                    .Include(r => r.RepairProducts)
                        .ThenInclude(rp => rp.PurchasedProduct)
                    .Include(r => r.RepairAccessories)
                    .Where(r => r.Id == id)
                    .ToListAsync();

                var result = _mapper.Map<GetRepairOrderDTO>(result_1.FirstOrDefault());

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

        public async Task<ServiceResponse<string>> UpdateRepairOrderStatus(UpdateRepairOrderStatusDTO updateRepairOrderStatusDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var result = await _dataContext.RepairOrders.FirstOrDefaultAsync(r => r.Id == updateRepairOrderStatusDTO.Id);
                if (result is null)
                {
                    throw new Exception($"Không tìm thấy đơn bảo hành có id là `{updateRepairOrderStatusDTO.Id}`");
                }
                result.StatusId = updateRepairOrderStatusDTO.StatusId;
                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = "Cập nhật thành công trạng thái đơn bảo hành";
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
