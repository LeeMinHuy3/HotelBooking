using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class DichVu
    {
        [Key]
        public int MaDV { get; set; }

        public string KieuDichVu { get; set; }

        public decimal Gia { get; set; }

        // Quan hệ 1-n với DatDichVu
        public List<DatDichVu> DatDichVus { get; set; }
    }
}
