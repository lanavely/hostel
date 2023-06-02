using Hostel.DataAccess.Repositories;
using Hostel.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Hostel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostelsController: Controller
    {
        private readonly HostelRepository _hostelRepository;

        public HostelsController(HostelRepository hostelRepository)
        {
            _hostelRepository = hostelRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<HostelItem>> GetAsync()
        {
            return await _hostelRepository.GetAsync();
        }
    }
}
