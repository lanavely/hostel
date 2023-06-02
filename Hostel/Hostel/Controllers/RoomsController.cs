using Hostel.DataAccess.Repositories;
using Hostel.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Hostel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController: Controller
    {
        private readonly RoomRepository _roomRepository;

        public RoomsController(RoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Room>> GetAsync()
        {
            return await _roomRepository.GetAsync();
        }
    }
}
