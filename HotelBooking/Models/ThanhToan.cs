using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class ThanhToan
    {
        [Key]
        public int MaTT { get; set; }

        [ForeignKey("DatPhong")]
        public int MaDP { get; set; }
        public DatPhong DatPhong { get; set; }

        public int TongNgayO { get; set; }

        public decimal TienThanhToan { get; set; }

        public string TrangThai { get; set; }
    }
}
