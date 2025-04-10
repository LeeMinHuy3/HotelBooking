using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class KhuyenMai
    {
        [Key]
        public int MaKM { get; set; }

        public string TenKM { get; set; }

        public decimal PhanTramKM { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public string TrangThai { get; set; }

        public List<DatPhong> DatPhongs { get; set; }
    }
}
