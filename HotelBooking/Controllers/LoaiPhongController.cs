using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class LoaiPhongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
