﻿namespace Hostel.Domain
{
    public class Booking
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public int UserId { get; set; }

        public int RoomId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
