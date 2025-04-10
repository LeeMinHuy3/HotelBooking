using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class DatPhongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
