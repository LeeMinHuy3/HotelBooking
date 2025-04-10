using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class ChiTietDichVuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
