using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class DanhGiaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
