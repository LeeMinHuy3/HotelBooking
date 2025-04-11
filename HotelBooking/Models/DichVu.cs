using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class DichVu
    {
        [Key]
        public int MaDV { get; set; }

        [Required(ErrorMessage = "Tên dịch vụ không được để trống")]
        public string KieuDichVu { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải là số không âm")]
        public decimal Gia { get; set; }

        // Quan hệ 1-n với DatDichVu
        public ICollection<DatDichVu> DatDichVus { get; set; }
    }
}
