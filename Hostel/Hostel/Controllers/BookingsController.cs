using Hostel.DataAccess.Repositories;
using Hostel.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Hostel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingsController: ControllerBase
    {
        private readonly BookingRepository _bookingRepository;

        public BookingsController(BookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> GetAsync()
        {
            return await _bookingRepository.GetAsync();
        }
    }
}
