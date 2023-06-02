using AutoMapper;
using Hostel.DataAccess.Entities;
using Hostel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hostel.DataAccess.Repositories
{
    public class HostelRepository
    {
        private readonly HostelDbContext _context;
        private readonly IMapper _mapper;

        public HostelRepository(
            HostelDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HostelItem>> GetAsync(int[] ids = default)
        {
            var hostels = from b in _context.Hostels select b;

            if (ids != default)
            {
                hostels = hostels.Where(b => ids.Contains(b.Id));
            }

            return (await hostels.ToListAsync()).Select(_mapper.Map<HostelItem>);
        }
         
        public async Task<int> AddAsync(HostelItem hostel)
        {
            if (hostel == null) throw new ArgumentNullException(nameof(hostel));

            var hostelEntity = _mapper.Map<HostelEntity>(hostel);

            await _context.Hostels.AddAsync(hostelEntity);
            await _context.SaveChangesAsync();

            return hostelEntity.Id;
        }
    }
}
