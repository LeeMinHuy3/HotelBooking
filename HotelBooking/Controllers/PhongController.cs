using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class PhongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
