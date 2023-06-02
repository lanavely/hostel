using Hostel.DataAccess.Configurations;
using Hostel.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Hostel.Domain;

namespace Hostel.DataAccess
{
    public class HostelDbContext: DbContext
    {
        public HostelDbContext(DbContextOptions<HostelDbContext> options)
            : base(options)
        {
        }


        public DbSet<RoomEntity> Rooms { get; set; }

        public DbSet<UserEntity> Users { get;set; }

        public DbSet<BookingEntity> Bookings { get; set; }

        public DbSet<HostelEntity> Hostels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new HostelConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
