﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinkyShopProject.Business.Entities
{
    public class GiaoCa
    {
        public Guid Id { get; set; }

        public DateTime ThoiGianNhanCa { get; set; }

        public DateTime ThoiGianGiaoCa { get; set; }

        public Guid IdNhanVienTrongCa { get; set; }

        public Guid? IdNhanVienCaTiepTheo { get; set; }

        public float TienBanDau { get; set; }

        public float? TongTienTrongCa { get; set; }

        public float? TongTienMat { get; set; }

        public float? TongTienKhac { get; set; }

        public float? TienPhatSinh { get; set; }

        public string? GhiChuPhatSinh { get; set; } = null!;

        public float? TongTienMatCaTruoc { get; set; }

        public DateTime? ThoiGianReset { get; set; }

        public float? TongTienMatRut { get; set; }

        public string? GhiChuRutTien { get; set; } = null!;

        public float? TongTienMatCuoiCa { get; set; }

        public int TrangThai { get; set; }

        public NhanVien NhanVien { get; set; } = null!;
    }
}
