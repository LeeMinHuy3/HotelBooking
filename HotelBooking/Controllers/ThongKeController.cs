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

        //public async Task<IActionResult> Index(DateTime? ngay)
        //{
        //    var ngayThongKe = ngay ?? DateTime.Today;

        //    // Tính tổng doanh thu từ đặt phòng trong ngày
        //    var tongDoanhThuDatPhong = await _context.DatPhongs
        //        .Where(dp => dp.NgayDat.Date == ngayThongKe.Date)
        //        .SumAsync(dp => (decimal?)dp.TongTien) ?? 0;

        //    // Tính tổng doanh thu từ dịch vụ
        //    var tongDoanhThuDichVu = await _context.DatDichVus
        //        .Where(dv => dv.NgaySuDung.Date == ngayThongKe.Date)
        //        .SumAsync(dv => (decimal?)dv.ThanhTien) ?? 0;

        //    var thongKe = new ThongKe
        //    {
        //        NgayThongKe = ngayThongKe,
        //        TongDoanhThu = tongDoanhThuDatPhong + tongDoanhThuDichVu,
        //        TongSoLuotDatPhong = await _context.DatPhongs.CountAsync(dp => dp.NgayDat.Date == ngayThongKe.Date),
        //        TongSoDichVuSuDung = await _context.DatDichVus.CountAsync(dv => dv.NgaySuDung.Date == ngayThongKe.Date)
        //    };

        //    return View(thongKe);
        //}
    }
}
