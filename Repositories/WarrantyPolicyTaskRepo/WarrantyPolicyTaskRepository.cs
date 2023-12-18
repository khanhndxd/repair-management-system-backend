using AutoMapper;
using repair_management_backend.DTOs.WarrantyPolicyTask;

namespace repair_management_backend.Repositories.WarrantyPolicyTaskRepo
{
    public class WarrantyPolicyTaskRepository : IWarrantyPolicyTaskRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public WarrantyPolicyTaskRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetWarrantyPolicyTaskDTO>>> GetWarrantyPolicyTasksByPolicyId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetWarrantyPolicyTaskDTO>>();
            try
            {
                var result = await _dataContext.WarrantyPolicyTasks
                    .Include(x => x.Task)
                    .Include(x => x.WarrantyPolicy)
                    .Where(x => x.WarrantyPolicyId == id)
                    .Select(x => _mapper.Map<GetWarrantyPolicyTaskDTO>(x))
                    .ToListAsync();

                if (result.Count() == 0)
                {
                    throw new Exception($"Không tìm thấy chính sách bảo hành có id là '{id}'");
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
