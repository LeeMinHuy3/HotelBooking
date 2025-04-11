using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class Phong
    {
        [Key]
        public int MaP { get; set; }

        public int MaLP { get; set; }
        public LoaiPhong LoaiPhong { get; set; }

        public decimal GiaPhong { get; set; }
        public string TrangThai { get; set; }

        public ICollection<DatPhong> DatPhongs { get; set; }
    }
}
