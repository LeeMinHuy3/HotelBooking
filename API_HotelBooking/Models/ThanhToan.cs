﻿using System.ComponentModel.DataAnnotations;

namespace API_HotelBooking.Models
{
    public class ThanhToan
    {
        [Key]
        public int MaTT { get; set; }

        public int MaDP { get; set; }
        public DatPhong DatPhong { get; set; }

        public int TongNgayO { get; set; }
        public decimal TienThanhToan { get; set; }
        public string TrangThai { get; set; }
    }
}
