using AutoMapper;
using repair_management_backend.DTOs.RepairOrder;
using repair_management_backend.Models;
using System.Globalization;

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
                ReceivedById = newRepairOrder.ReceivedById,
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

        public async Task<ServiceResponse<List<GetRepairOrderDTO>>> GetAll(string userId, List<string> roles, string fieldQuery, string timeQuery, string startDateQuery, string endDateQuery)
        {
            var serviceResponse = new ServiceResponse<List<GetRepairOrderDTO>>();
            IQueryable<RepairOrder> result = _dataContext.RepairOrders
                .AsNoTracking()
                .Where(r => r.IsDeleted == false)
                .OrderByDescending(r => r.Id);
            if(!roles.Contains("Admin"))
            {
                if(roles.Contains("Receiver"))
                {
                    result = result.Where(r => r.ReceivedById == userId);

                } else if(roles.Contains("Creator"))
                {
                    result = result.Where(r => r.CreatedById == userId);
                } else if(roles.Contains("Technician"))
                {
                    result = result.Where(r => r.RepairedById == userId);
                }
            } 

            // Query theo field nếu có
            if (!string.IsNullOrEmpty(fieldQuery))
            {
                switch (fieldQuery.ToLower())
                {
                    case "repairtask":
                        result = result
                            .Include(r => r.RepairType)
                            .Include(r => r.RepairTasks)
                                .ThenInclude(ra => ra.Task);
                        break;
                    case "repairtype":
                        result = result
                            .Include(r => r.RepairType);
                        break;
                    case "category":
                        result = result
                            .Include(r => r.RepairType)
                            .Include(r => r.RepairProducts)
                                .ThenInclude(rp => rp.PurchasedProduct)
                                    .ThenInclude(p => p.Category);
                        break;
                    case "totalprice":
                        result = result
                            .Include(r => r.RepairType);
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
                    .Include(r => r.ReceivedBy)
                    .Include(r => r.RepairLogs)
                    .Include(r => r.RepairProducts)
                        .ThenInclude(rp => rp.PurchasedProduct)
                    .Include(r => r.RepairAccessories)
                        .ThenInclude(ra => ra.Accessory)
                    .Include(r => r.RepairTasks)
                        .ThenInclude(ra => ra.Task)
                    .Include(r => r.RepairCustomerProducts)
                        .ThenInclude(ra => ra.CustomerProduct);

            }

            if(!string.IsNullOrEmpty(timeQuery) || (!string.IsNullOrEmpty(startDateQuery) && !string.IsNullOrEmpty(endDateQuery)))
            {
                DateTime currentDate = DateTime.Now;
                DateTime startDate;
                DateTime endDate;

                // Nếu ít nhất một trong hai trường khoảng thời gian không rỗng, sử dụng để lọc dữ liệu
                if (!string.IsNullOrEmpty(startDateQuery) && !string.IsNullOrEmpty(endDateQuery) && timeQuery.ToLower() == "range")
                {
                    if (DateTime.TryParse(startDateQuery, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate) &&
                        DateTime.TryParse(endDateQuery, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
                    {
                        result = result.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
                    }
                    else
                    {
                        // Xử lý khi chuyển đổi ngày không thành công
                        serviceResponse.Success = false;
                        serviceResponse.Message = "Sai định dạng ngày tháng";
                        return serviceResponse;
                    }
                } else
                {
                    switch (timeQuery.ToLower())
                    {
                        case "current-day":
                            startDate = currentDate.Date; // Bắt đầu từ 00:00:00 của ngày hiện tại
                            endDate = currentDate.Date.AddDays(1).AddTicks(-1); // Kết thúc vào 23:59:59 của ngày hiện tại
                            result = result.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
                            break;
                        case "current-week":
                            startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek);
                            endDate = startDate.AddDays(6);
                            // Nếu ngày hiện tại là chủ nhật và startDate là ngày sau chủ nhật, giảm đi 7 ngày để đảm bảo lấy đúng tuần hiện tại
                            if (currentDate.DayOfWeek == DayOfWeek.Sunday && startDate > currentDate)
                            {
                                startDate = startDate.AddDays(-7);
                                endDate = endDate.AddDays(-7);
                            }
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

        public async Task<ServiceResponse<List<RepairCategoryStatsDTO>>> GetRepairCategoryStat()
        {
            var serviceResponse = new ServiceResponse<List<RepairCategoryStatsDTO>>();

            try
            {
                var categoryStats = await _dataContext.Categories
                    .Select(c => new
                    {
                        CategoryId = c.Id,
                        CategoryName = c.Name,
                        RepairTypeStats = _dataContext.RepairTypes
                            .Select(rt => new
                            {
                                RepairTypeId = rt.Id,
                                RepairTypeName = rt.Name,
                                RepairCount = _dataContext.RepairOrders
                                    .Where(ro => ro.IsDeleted == false)
                                    .Where(ro => ro.RepairTypeId == rt.Id)
                                    .SelectMany(ro => ro.RepairProducts.Where(rp => rp.PurchasedProduct.CategoryId == c.Id))
                                    .Count(),
                            })
                            .ToList(),
                    })
                    .ToListAsync();

                var categoryStatsDTO = categoryStats.Select(cs => new RepairCategoryStatsDTO
                {
                    CategoryId = cs.CategoryId,
                    CategoryName = cs.CategoryName,
                    RepairTypeStats = cs.RepairTypeStats.Select(rts => new RepairTypeStatsDTO
                    {
                        RepairTypeId = rts.RepairTypeId,
                        RepairTypeName = rts.RepairTypeName,
                        RepairCount = rts.RepairCount
                    }).ToList()
                })
                .OrderByDescending(catStats => catStats.RepairTypeStats.Sum(rtStats => rtStats.RepairCount))
                .ToList();

                serviceResponse.Data = categoryStatsDTO;
                serviceResponse.Message = "Thống kê thành công";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = $"Có lỗi khi thống kê: {ex.Message}";
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetRepairOrderDTO>> GetRepairOrderById(int id)
        {
            var serviceResponse = new ServiceResponse<GetRepairOrderDTO>();
            try
            {
                var repairOrderQuery = _dataContext.RepairOrders
                    .AsNoTracking()
                    .Where(r => r.Id == id && !r.IsDeleted)
                    .Include(r => r.Customer)
                    .Include(r => r.RepairReason)
                    .Include(r => r.RepairType)
                    .Include(r => r.Status)
                    .Include(r => r.CreatedBy)
                    .Include(r => r.RepairedBy)
                    .Include(r => r.ReceivedBy)
                    .Include(r => r.RepairLogs);

                var repairOrder = await repairOrderQuery.FirstOrDefaultAsync();

                if (repairOrder != null)
                {
                    var repairProductQuery = _dataContext.RepairProducts
                        .Where(rp => rp.RepairOrderId == repairOrder.Id)
                        .Include(rp => rp.PurchasedProduct.Category.WarrantyPolicy);

                    repairOrder.RepairProducts = await repairProductQuery.ToListAsync();

                    var repairAccessoryQuery = _dataContext.RepairAccessories
                        .Where(ra => ra.RepairOrderId == repairOrder.Id)
                        .Include(ra => ra.Accessory);

                    repairOrder.RepairAccessories = await repairAccessoryQuery.ToListAsync();

                    var repairTaskQuery = _dataContext.RepairTasks
                        .Where(rt => rt.RepairOrderId == repairOrder.Id)
                        .Include(rt => rt.Task);

                    repairOrder.RepairTasks = await repairTaskQuery.ToListAsync();

                    var repairCustomerProductQuery = _dataContext.RepairCustomerProducts
                        .Where(rcp => rcp.RepairOrderId == repairOrder.Id)
                        .Include(rcp => rcp.CustomerProduct);

                    repairOrder.RepairCustomerProducts = await repairCustomerProductQuery.ToListAsync();

                    serviceResponse.Data = _mapper.Map<GetRepairOrderDTO>(repairOrder);
                }
                else
                {
                    throw new Exception($"Không tìm thấy đơn sửa chữa có id là `{id}`");
                }

            } catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<int>> GetRepairOrderByStatus(string userId, List<string> roles, int id)
        {
            var serviceResponse = new ServiceResponse<int>();
          
            try
            {
                var result = -1;
                if (id == -1)
                {
                    if (!roles.Contains("Admin"))
                    {
                        if (roles.Contains("Receiver"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.ReceivedById == userId)
                                .CountAsync();

                        }
                        else if (roles.Contains("Creator"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.CreatedById == userId)
                                .CountAsync();
                        }
                        else if (roles.Contains("Technician"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.RepairedById == userId)
                                .CountAsync();
                        }
                    } else
                    {
                        result = await _dataContext.RepairOrders
                        .Where(r => r.IsDeleted == false)
                        .CountAsync();
                    }
                } else
                {
                    if (!roles.Contains("Admin"))
                    {
                        if (roles.Contains("Receiver"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.ReceivedById == userId)
                                .CountAsync(ro => ro.StatusId == id);

                        }
                        else if (roles.Contains("Creator"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.CreatedById == userId)
                                .CountAsync(ro => ro.StatusId == id);
                        }
                        else if (roles.Contains("Technician"))
                        {
                            result = await _dataContext.RepairOrders
                                .Where(r => r.IsDeleted == false)
                                .Where(r => r.RepairedById == userId)
                                .CountAsync(ro => ro.StatusId == id);
                        }
                    } else
                    {
                        result = await _dataContext.RepairOrders
                            .Where(r => r.IsDeleted == false)
                            .CountAsync(ro => ro.StatusId == id);
                    }
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
                if (result.RepairedById != updateRepairOrderStatusDTO.RepairedById && result.CreatedById != updateRepairOrderStatusDTO.CreatedById && result.ReceivedById != updateRepairOrderStatusDTO.ReceivedById)
                {
                    throw new Exception($"Không thể cập nhật trạng thái vì không phải người của đơn");
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

        public async Task<ServiceResponse<string>> UpdateTotalPrice(UpdateTotalPriceDTO updateTotalPriceDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            try
            {
                var result = await _dataContext.RepairOrders.FindAsync(updateTotalPriceDTO.Id);
                if (result is null)
                {
                    throw new Exception($"Không tìm thấy đơn bảo hành có id là `{updateTotalPriceDTO.Id}`");
                }
                result.TotalPrice = updateTotalPriceDTO.TotalPrice;
                await _dataContext.SaveChangesAsync();
                serviceResponse.Data = "Cập nhật thành công tổng tiền cho đơn bảo hành sửa chữa";
            } catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
