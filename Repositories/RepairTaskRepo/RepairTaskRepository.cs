using repair_management_backend.Data;
using repair_management_backend.DTOs.RepairProduct;
using repair_management_backend.DTOs.RepairTask;

namespace repair_management_backend.Repositories.RepairTask
{
    public class RepairTaskRepository : IRepairTaskRepository
    {
        private readonly DataContext _dataContext;
        public RepairTaskRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<string>> AddRepairTask(List<AddRepairTaskDTO> addRepairTaskDTOs)
        {
            var serviceResponse = new ServiceResponse<string>();

            if (addRepairTaskDTOs.Count == 0)
            {
                serviceResponse.Data = "Thêm thành công công việc vào đơn bảo hành";
                return serviceResponse;
            }

            using var transaction = _dataContext.Database.BeginTransaction();

            try
            {
                // Lấy ra danh sách RepairOrderId từ addRepairTaskDTOs
                var repairOrderIds = addRepairTaskDTOs.Select(dto => dto.RepairOrderId).ToList();

                // Xóa dữ liệu trong RepairTask có RepairOrderId nằm trong danh sách trước khi thêm mới
                var repairTasksToDelete = _dataContext.RepairTasks.Where(ra => repairOrderIds.Contains(ra.RepairOrderId));
                _dataContext.RepairTasks.RemoveRange(repairTasksToDelete);

                await _dataContext.SaveChangesAsync();

                // Kiểm tra xem có task nào được thêm không
                if (addRepairTaskDTOs[0].TaskId != -1 && addRepairTaskDTOs.Count >= 1)
                {
                    // Thêm dữ liệu mới
                    for (int i = 0; i < addRepairTaskDTOs.Count; i++)
                    {
                        var repairTask = new Models.RepairTask
                        {
                            TaskId = addRepairTaskDTOs[i].TaskId,
                            RepairOrderId = addRepairTaskDTOs[i].RepairOrderId,
                            Description = addRepairTaskDTOs[i].Description
                        };
                        _dataContext.RepairTasks.Add(repairTask);

                        // cứ thêm 10 data vào bộ nhớ thì sẽ lưu vào database
                        if (i % 10 == 0)
                        {
                            await _dataContext.SaveChangesAsync();
                        }
                    }
                }

                await _dataContext.SaveChangesAsync();
                transaction.Commit();
                serviceResponse.Data = "Thêm thành công công việc vào đơn bảo hành";
                serviceResponse.Message = "Thêm thành công công việc vào đơn bảo hành";
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                serviceResponse.Success = false;
                serviceResponse.Message = "Lỗi trong quá trình thêm dữ liệu vào database, quá trình sẽ được Rollback";
            }
            return serviceResponse;
        }
    }
}
