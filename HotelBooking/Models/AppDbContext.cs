using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DichVu> DichVus { get; set; }
        public DbSet<DatDichVu> DatDichVus { get; set; }
        public DbSet<DatPhong> DatPhongs { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<DanhGia> DanhGias { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
    }
}
