﻿using System.ComponentModel.DataAnnotations;

namespace HotelBooking.Models
{
    public class NguoiDung
    {
        [Key]
        public int MaND { get; set; }

        public string Ten { get; set; }

        public string VaiTro { get; set; }

        public string Email { get; set; }

        public string SDT { get; set; }

        public string MatKhau { get; set; }

        public List<DatPhong> DatPhongs { get; set; }

        public List<DanhGia> DanhGias { get; set; }
    }
}
