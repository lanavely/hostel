namespace Hostel.DataAccess.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public List<BookingEntity> Bookings { get; set; }
    }
}
