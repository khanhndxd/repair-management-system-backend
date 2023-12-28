using repair_management_backend.DTOs.RepairReason;
using repair_management_backend.Models;

namespace repair_management_backend.Repositories.RepairReasonRepo
{
    public class RepairReasonRepository : IRepairReasonRepository
    {
        private readonly DataContext _dataContext;
        public RepairReasonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<string>> AddRepairReason(AddRepairReasonDTO addRepairReasonDTO)
        {
            var serviceResponse = new ServiceResponse<string>();
            var repairReason = new RepairReason
            {
                Reason = addRepairReasonDTO.Reason,
            };
            try
            {
                _dataContext.RepairReasons.Add(repairReason);
                await _dataContext.SaveChangesAsync();

                serviceResponse.Data = "Thêm mới lý do bảo hành thành công";
                serviceResponse.Message = "Thêm mới lý do bảo hành thành công";

            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<string>> DeleteRepairReason(DeleteRepairReasonDTO deleteRepairReasonDTO)
        {
            var serviceResponse = new ServiceResponse<string>();

            try
            {
                var repairReason = await _dataContext.RepairReasons.FindAsync(deleteRepairReasonDTO.Id);

                if (repairReason == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Không tìm thấy lý do bảo hành";
                    return serviceResponse;
                }

                _dataContext.RepairReasons.Remove(repairReason);
                await _dataContext.SaveChangesAsync();

                serviceResponse.Data = "Xóa lý do bảo hành thành công";
                serviceResponse.Message = "Xóa lý do bảo hành thành công";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<RepairReason>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<RepairReason>>();
            serviceResponse.Data = await _dataContext.RepairReasons.ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> UpdateRepairReason(UpdateRepairReasonDTO updateRepairReasonDTO)
        {
            var serviceResponse = new ServiceResponse<string>();

            try
            {
                var repairReason = await _dataContext.RepairReasons.FindAsync(updateRepairReasonDTO.Id);

                if (repairReason == null)
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Không tìm thấy lý do bảo hành";
                    return serviceResponse;
                }

                repairReason.Reason = updateRepairReasonDTO.Reason;

                await _dataContext.SaveChangesAsync();

                serviceResponse.Data = "Cập nhật lý do bảo hành thành công";
                serviceResponse.Message = "Cập nhật lý do bảo hành thành công";
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
