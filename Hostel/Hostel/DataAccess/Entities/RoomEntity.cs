namespace Hostel.DataAccess.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Capacity { get; set; }

        public decimal Square { get; set; }

        public int HostelId { get; set; }

        public HostelEntity Hostel { get; set; }

        public List<BookingEntity> Bookings { get; set; }
    }
}
