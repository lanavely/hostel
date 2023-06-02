namespace Hostel.DataAccess.Entities
{
    public class BookingEntity
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int UserId { get; set; }

        public UserEntity User { get; set; }

        public int RoomId { get; set; }

        public RoomEntity Room { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
