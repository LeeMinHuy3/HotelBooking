using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class DichVuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
