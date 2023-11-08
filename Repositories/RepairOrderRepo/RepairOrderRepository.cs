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

        public async Task<ServiceResponse<int>> AddRepairOrder(AddRepairOrderDTO newRepairOrder)
        {
            var serviceResponse = new ServiceResponse<int>();
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

            try
            {
                _dataContext.RepairOrders.Add(repairOrder);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            await _dataContext.SaveChangesAsync();
            serviceResponse.Data = repairOrder.Id;
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
                    .ThenInclude(ra => ra.Accessory)
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
                        .ThenInclude(ra => ra.Accessory)
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

        public async Task<ServiceResponse<string>> UpdateRepairOrder(UpdateRepairOrderDTO updateRepairOrderDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var repairOrder = await _dataContext.RepairOrders.FirstOrDefaultAsync(ro => ro.Id == updateRepairOrderDTO.Id);
                if (repairOrder is null)
                {
                    throw new Exception($"Không tìm thấy đơn bảo hành mã '{updateRepairOrderDTO.Id}'");
                }
                _mapper.Map(updateRepairOrderDTO, repairOrder);

                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = "Cập nhật đơn bảo hành thành công";
                serviceResponse.Message = "Cập nhật đơn bảo hành thành công";

            }
            catch (Exception ex)
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
                if (result.RepairedById != updateRepairOrderStatusDTO.RepairedById && result.CreatedById != updateRepairOrderStatusDTO.CreatedById)
                {
                    throw new Exception($"Không thể cập nhật trạng thái vì không phải người tiếp nhận hay người tạo đơn");
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
