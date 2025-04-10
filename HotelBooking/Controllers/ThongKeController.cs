using HotelBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelBooking.Models;

namespace HotelBooking.Controllers
{
    public class ThongKeController : Controller
    {
        private readonly AppDbContext _context;

        public ThongKeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ngayHomNay = DateTime.Today;

            // Tổng số lượt đặt phòng hôm nay
            var soLuotDatPhong = _context.DatPhongs
                .Count(dp => dp.ThoiGianDat.Date == ngayHomNay);

            // Tổng số dịch vụ sử dụng hôm nay
            var soDichVu = _context.DatDichVus
                .Join(_context.DatPhongs,
                      ddv => ddv.MaDP,
                      dp => dp.MaDP,
                      (ddv, dp) => new { ddv, dp })
                .Count(x => x.dp.ThoiGianDat.Date == ngayHomNay);

            // Số lần áp dụng khuyến mãi hôm nay
            var soLanKhuyenMai = _context.DatPhongs
                .Count(dp => dp.ThoiGianDat.Date == ngayHomNay && dp.MaKM != null);

            // Tổng doanh thu hôm nay (từ đặt phòng)
            var doanhThu = _context.DatPhongs
                .Where(dp => dp.ThoiGianDat.Date == ngayHomNay)
                .Sum(dp => (decimal?)dp.TongTien) ?? 0;

            // Gửi dữ liệu sang View bằng ViewBag
            ViewBag.SoLuotDatPhong = soLuotDatPhong;
            ViewBag.SoDichVu = soDichVu;
            ViewBag.SoLanKhuyenMai = soLanKhuyenMai;
            ViewBag.DoanhThu = doanhThu;

            return View();
        }
    }
}
