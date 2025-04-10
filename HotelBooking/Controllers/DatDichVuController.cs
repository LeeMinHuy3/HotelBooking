using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class DatDichVuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
