using AutoMapper;
using Hostel.DataAccess.Entities;
using Hostel.Domain;

namespace Hostel.DataAccess
{
    public class DataAccessMappingProfile: Profile
    {
        public DataAccessMappingProfile()
        {
            CreateMap<Booking, BookingEntity>().ReverseMap();
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<Room, RoomEntity>().ReverseMap();
            CreateMap<HostelItem, HostelEntity>().ReverseMap();
        }
    }
}
