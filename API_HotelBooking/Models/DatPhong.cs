﻿using System.ComponentModel.DataAnnotations;

namespace API_HotelBooking.Models
{
    public class DatPhong
    {
        [Key]
        public int MaDP { get; set; }

        public int MaND { get; set; }
        public NguoiDung NguoiDung { get; set; }

        public int MaP { get; set; }
        public Phong Phong { get; set; }

        public int? MaKM { get; set; }
        public KhuyenMai KhuyenMai { get; set; }

        public DateTime ThoiGianDat { get; set; }
        public DateTime ThoiGianCheckIn { get; set; }
        public DateTime ThoiGianCheckOut { get; set; }

        public string TrangThai { get; set; }
        public decimal TongTien { get; set; }

        public ICollection<DatDichVu> DatDichVus { get; set; }
        public ThanhToan ThanhToan { get; set; }
    }
}
