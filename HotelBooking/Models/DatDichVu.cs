using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class DatDichVu
    {
        [Key]
        public int MaDDV { get; set; }

        [ForeignKey("DatPhong")]
        public int MaDP { get; set; }
        public DatPhong DatPhong { get; set; }

        [ForeignKey("DichVu")]
        public int MaDV { get; set; }
        public DichVu DichVu { get; set; }

        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
    }
}
