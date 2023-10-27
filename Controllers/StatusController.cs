using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repair_management_backend.Repositories.StatusRepo;

namespace repair_management_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusRepository _statusRepository;
        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Status>>>> Get()
        {
            return Ok(await _statusRepository.GetAll());
        }
    }
}
