using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using repair_management_backend.DTOs.RepairLog;
using repair_management_backend.Hubs;

namespace repair_management_backend.Repositories.RepairLogRepo
{
    public class RepairLogRepository : IRepairLogRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotificationHub> _notificationHub;
        public RepairLogRepository(DataContext dataContext, IMapper mapper, IHubContext<NotificationHub> notificationHub)
        {
            _dataContext = dataContext;
            _mapper = mapper;
            _notificationHub = notificationHub;
        }
        public async Task<ServiceResponse<string>> AddRepairLog(AddRepairLogDTO addRepairLogDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            var repairLog = new RepairLog
            {
                RepairOrderId = addRepairLogDTO.RepairOrderId,
                CreatedById = addRepairLogDTO.CreatedById,
                CreatedAt = addRepairLogDTO.CreatedAt,
                Info = addRepairLogDTO.Info,
            };
            try
            {
                _dataContext.RepairLogs.Add(repairLog);
                await _dataContext.SaveChangesAsync();

                await _notificationHub.Clients.Group($"order-{addRepairLogDTO.RepairOrderId}")
                        .SendAsync("receiveNotification", new { id = addRepairLogDTO.RepairOrderId });

                serviceResponse.Data = "Thêm mới lịch sử đơn hàng thành công";
                serviceResponse.Message = "Thêm mới lịch sử đơn hàng thành công";

            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRepairLogDTO>>> GetRepairLogByRepairOrderId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetRepairLogDTO>>();
            try
            {
                var result = await _dataContext.RepairLogs.Where(r => r.RepairOrderId == id)
                    .OrderByDescending(r => r.CreatedAt)
                    .Include(r => r.CreatedBy)
                    .Select(r => _mapper.Map<GetRepairLogDTO>(r))
                    .ToListAsync();

                // không kiểm tra result vì có thể lấy mảng rỗng các log của 1 đơn
                serviceResponse.Data = result;
                serviceResponse.Message = "Lấy danh sách log của đơn thành công";

            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
