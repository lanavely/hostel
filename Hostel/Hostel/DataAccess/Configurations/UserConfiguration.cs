using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Hostel.DataAccess.Entities;

namespace Hostel.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x => x.LastName).HasMaxLength(100);
            builder.Property(x => x.Patronymic).HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Password).HasMaxLength(100);
            builder.Property(x => x.Role).HasMaxLength(50);

            builder.HasMany(x => x.Bookings)
                .WithOne(x => x.User)
                .OnDelete(DeleteBehavior.NoAction)
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.UserId)
                .IsRequired();
        }
    }
}
