using AutoMapper;
using Hostel.DataAccess.Entities;
using Hostel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hostel.DataAccess.Repositories
{
    public class BookingRepository
    {
        private readonly HostelDbContext _context;
        private readonly IMapper _mapper;

        public BookingRepository(
            HostelDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Booking>> GetAsync(int[] ids = default)
        {
            var bookings = from b in _context.Bookings select b;
         
            if (ids != default)
            {
                bookings = bookings.Where(b => ids.Contains(b.Id));
            }

            return (await bookings.ToListAsync()).Select(_mapper.Map<Booking>);
        }

        public async Task<int> AddAsync(Booking booking)
        {
            if (booking == null) throw new ArgumentNullException(nameof(booking));

            var bookingEntity = _mapper.Map<BookingEntity>(booking);

            await _context.Bookings.AddAsync(bookingEntity);
            await _context.SaveChangesAsync();

            return bookingEntity.Id;
        }
    }
}
