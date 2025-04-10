using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class DatPhong
    {
        [Key]
        public int MaDP { get; set; }

        [ForeignKey("NguoiDung")]
        public int MaND { get; set; }
        public NguoiDung NguoiDung { get; set; }

        [ForeignKey("Phong")]
        public int MaP { get; set; }
        public Phong Phong { get; set; }

        [ForeignKey("KhuyenMai")]
        public int? MaKM { get; set; }
        public KhuyenMai KhuyenMai { get; set; }

        public DateTime ThoiGianDat { get; set; }

        public DateTime ThoiGianCheckIn { get; set; }

        public DateTime ThoiGianCheckOut { get; set; }

        public string TrangThai { get; set; }

        public decimal TongTien { get; set; }
    }
}
