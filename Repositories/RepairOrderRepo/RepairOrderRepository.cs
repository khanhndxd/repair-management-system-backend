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

        public async Task<ServiceResponse<string>> DeleteRepairOrder(DeleteRepairOrderDTO deleteRepairOrderDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var result = await _dataContext.RepairOrders.FirstOrDefaultAsync(x => x.Id == deleteRepairOrderDTO.Id);
                if (result == null)
                {
                    throw new Exception($"Không tìm thấy đơn bảo hành sửa chữa có id là {deleteRepairOrderDTO.Id}");
                }
                result.IsDeleted = true;
                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = "Xóa đơn thành công";
                serviceResponse.Message = "Xóa đơn thành công";
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll(string fieldQuery, string timeQuery)
        {
            var serviceResponse = new ServiceResponse<List<GetRepairOrderDTO>>();
            IQueryable<RepairOrder> result = _dataContext.RepairOrders.Where(r => r.IsDeleted == false);

            // Query theo field nếu có
            if (!string.IsNullOrEmpty(fieldQuery))
            {
                switch (fieldQuery.ToLower())
                {
                    case "repairtasks":
                        result = result
                            .Include(r => r.RepairTasks)
                                .ThenInclude(ra => ra.Task);
                        break;
                    case "repairtype":
                        result = result
                            .Include(r => r.RepairType);
                        break;
                    case "repairproducts":
                        result = result
                            .Include(r => r.RepairProducts)
                                .ThenInclude(rp => rp.PurchasedProduct)
                                    .ThenInclude(p => p.Category);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                result = result
                    .Include(r => r.Customer)
                    .Include(r => r.RepairReason)
                    .Include(r => r.RepairType)
                    .Include(r => r.Status)
                    .Include(r => r.CreatedBy)
                    .Include(r => r.RepairedBy)
                    .Include(r => r.RepairProducts)
                        .ThenInclude(rp => rp.PurchasedProduct)
                    .Include(r => r.RepairAccessories)
                        .ThenInclude(ra => ra.Accessory)
                    .Include(r => r.RepairTasks)
                        .ThenInclude(ra => ra.Task)
                    .Include(r => r.RepairCustomerProducts)
                        .ThenInclude(ra => ra.CustomerProduct);
            }

            if(!string.IsNullOrEmpty(timeQuery))
            {
                DateTime currentDate = DateTime.Now;
                DateTime startDate;
                DateTime endDate;

                // Query theo thời gian nếu có
                if (!string.IsNullOrEmpty(timeQuery))
                {
                    switch (timeQuery.ToLower())
                    {
                        case "week":
                            startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek);
                            endDate = startDate.AddDays(6);
                            result = result.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
                            break;
                        case "current-month":
                            startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                            endDate = startDate.AddMonths(1).AddDays(-1);
                            result = result.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
                            break;
                        case "months":
                            startDate = new DateTime(currentDate.Year, 1, 1);
                            endDate = startDate.AddYears(1).AddDays(-1);
                            result = result.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
                            break;
                        default:
                            break;
                    }
                }
            }

            serviceResponse.Data = await result
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
                    .Where(r => r.Id == id && r.IsDeleted == false)
                    .Include(r => r.Customer)
                    .Include(r => r.RepairReason)
                    .Include(r => r.RepairType)
                    .Include(r => r.Status)
                    .Include(r => r.CreatedBy)
                    .Include(r => r.RepairedBy)
                    .Include(r => r.RepairProducts)
                        .ThenInclude(rp => rp.PurchasedProduct)
                    .Include(r => r.RepairAccessories)
                        .ThenInclude(ra => ra.Accessory)
                    .Include(r => r.RepairTasks)
                        .ThenInclude(ra => ra.Task)
                    .Include(r => r.RepairCustomerProducts)
                        .ThenInclude(ra => ra.CustomerProduct)
                    .Select(r => _mapper.Map<GetRepairOrderDTO>(r))
                    .FirstOrDefaultAsync();

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

        public async Task<ServiceResponse<int>> GetRepairOrderByStatus(int id)
        {
            var serviceResponse = new ServiceResponse<int>();
            try
            {
                var result = -1;
                if (id == -1)
                {
                    result = await _dataContext.RepairOrders
                        .Where(r => r.IsDeleted == false)
                        .CountAsync();
                } else
                {
                    result = await _dataContext.RepairOrders
                        .Where(r => r.IsDeleted == false)
                        .CountAsync(ro => ro.StatusId == id);
                }
                serviceResponse.Data = result;


            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<double>> GetTotalPrice()
        {
            var serviceResponse = new ServiceResponse<double>();
            try
            {
                var result = await _dataContext.RepairOrders
                    .Where(r => r.IsDeleted == false)
                    .SumAsync(ro => ro.TotalPrice);
                serviceResponse.Data = result;
            }
            catch (Exception ex)
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
