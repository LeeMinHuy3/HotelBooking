using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
