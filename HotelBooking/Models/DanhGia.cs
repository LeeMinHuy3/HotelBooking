using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class DanhGia
    {
        [Key]
        public int MaDG { get; set; }

        public int MaND { get; set; }
        public NguoiDung NguoiDung { get; set; }

        public string BinhLuan { get; set; }
        public DateTime NgayDanhGia { get; set; }
    }
}
