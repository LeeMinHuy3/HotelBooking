using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class KhuyenMaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
