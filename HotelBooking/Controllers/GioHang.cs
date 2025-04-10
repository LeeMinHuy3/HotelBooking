using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class GioHang : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
