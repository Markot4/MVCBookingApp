using Microsoft.AspNetCore.Mvc;
using MVCBookingApp.Models;


namespace MVCBookingApp.Controllers
{
    public class BookingController : Controller
    {
        private static List<HotelBooking> hotelBookings = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View(hotelBookings);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBooking(HotelBooking hotelBooking)
        {
            hotelBookings.Add(hotelBooking);
            return RedirectToAction("Index");
        }
    }
}
