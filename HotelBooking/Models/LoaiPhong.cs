using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class LoaiPhong
    {
        [Key]
        public int MaLP { get; set; }

        public string TenLoaiPhong { get; set; }

        public List<Phong> Phongs { get; set; }
    }
}
