﻿using AutoMapper;
using repair_management_backend.DTOs.RepairAccessory;

namespace repair_management_backend.Repositories.RepairAccessoryRepo
{
    public class RepairAccessoryRepository : IRepairAccessoryRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public RepairAccessoryRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<string>> AddRepairAccessory(List<AddRepairAccessoryDTO> addRepairAccessoryDTO)
        {
            var serviceResponse = new ServiceResponse<string>();

            using var transaction = _dataContext.Database.BeginTransaction();

            try
            {
                for (int i = 0; i < addRepairAccessoryDTO.Count; i++)
                {
                    var repairAccessory = new RepairAccessory
                    {
                        AccessoryId = addRepairAccessoryDTO[i].AccessoryId,
                        RepairOrderId = addRepairAccessoryDTO[i].RepairOrderId,
                        Quantity = addRepairAccessoryDTO[i].Quantity
                    };
                    _dataContext.RepairAccessories.Add(repairAccessory);

                    // kiểm tra nếu đã thêm 10 sản phẩm thì sẽ lưu vào database
                    if (i % 10 == 0)
                    {
                        await _dataContext.SaveChangesAsync();
                    }
                }
                await _dataContext.SaveChangesAsync();
                transaction.Commit();
                serviceResponse.Data = "Thêm thành công linh kiện vào đơn bảo hành";
            }
            catch (Exception)
            {
                transaction.Rollback();
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi trong quá trình thêm dữ liệu vào database, quá trình sẽ được Rollback";
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetRepairAccessoryDTO>>> GetRepairAccessoryByRepairOrderId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetRepairAccessoryDTO>>();
            try
            {
                var result = await _dataContext.RepairAccessories
                    .Include(r => r.Accessory)
                    .Where(r => r.RepairOrderId == id)
                    .Select(r => _mapper.Map<GetRepairAccessoryDTO>(r))
                    .ToListAsync();
                if (result.Count() == 0)
                {
                    throw new Exception("Không tìm thấy linh kiện nào!");
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
