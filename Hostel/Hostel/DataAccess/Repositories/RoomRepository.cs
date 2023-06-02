using AutoMapper;
using Hostel.DataAccess.Entities;
using Hostel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hostel.DataAccess.Repositories
{
    public class RoomRepository
    {
        private readonly HostelDbContext _context;
        private readonly IMapper _mapper;

        public RoomRepository(
            HostelDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Room>> GetAsync(int[] ids = default)
        {
            var rooms = from b in _context.Rooms select b;

            if (ids != default)
            {
                rooms = rooms.Where(b => ids.Contains(b.Id));
            }

            return (await rooms.ToListAsync()).Select(_mapper.Map<Room>);
        }

        public async Task<int> AddAsync(Room room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));

            var roomEntity = _mapper.Map<RoomEntity>(room);

            await _context.Rooms.AddAsync(roomEntity);
            await _context.SaveChangesAsync();

            return roomEntity.Id;
        }
    }
}
