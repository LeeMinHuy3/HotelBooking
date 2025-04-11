using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class DichVu
    {
        [Key]
        public int MaDV { get; set; }

        public string KieuDichVu { get; set; }

        public decimal Gia { get; set; }

        // Quan hệ 1-n với DatDichVu
        public ICollection<DatDichVu> DatDichVus { get; set; }
    }
}
