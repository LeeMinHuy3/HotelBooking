using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    public class NguoiDungController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
