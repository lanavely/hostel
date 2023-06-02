using AutoMapper;
using Hostel.DataAccess.Entities;
using Hostel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hostel.DataAccess.Repositories
{
    public class UserRepository
    {
        private readonly HostelDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(
            HostelDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAsync(int[] ids = default)
        {
            var users = from b in _context.Users select b;

            if (ids != default)
            {
                users = users.Where(b => ids.Contains(b.Id));
            }

            return (await users.ToListAsync()).Select(_mapper.Map<User>);
        }

        public async Task<int> AddAsync(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            var userEntity = _mapper.Map<UserEntity>(user);

            await _context.Users.AddAsync(userEntity);
            await _context.SaveChangesAsync();

            return userEntity.Id;
        }
    }
}
