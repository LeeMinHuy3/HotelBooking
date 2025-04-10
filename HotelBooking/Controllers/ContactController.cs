using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
