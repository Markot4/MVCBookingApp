namespace MVCBookingApp.Models
{
    public class HotelBooking
    {
        public int Id { get; set; }
        public required string GuestName { get; set; }
        public int RoomNumber { get; set; }


        private static int nextId = 1;
        public HotelBooking()
        {
            Id = nextId;
            nextId++;
        }
    }
}
