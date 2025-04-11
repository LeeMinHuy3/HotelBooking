using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class LoaiPhong
    {
        [Key]
        public int MaLP { get; set; }
        public string LoaiPhongName { get; set; }

        public ICollection<Phong> Phongs { get; set; }
    }
}
