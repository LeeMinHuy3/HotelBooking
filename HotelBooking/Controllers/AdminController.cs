using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
