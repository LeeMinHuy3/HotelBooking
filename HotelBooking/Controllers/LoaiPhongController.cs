using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
