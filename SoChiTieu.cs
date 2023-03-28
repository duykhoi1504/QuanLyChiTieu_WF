﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
    class SoChiTieu
    {
        private string danhMuc;
        private string soTien;
        private string ngayThang;
        private string ghiChu;
        public SoChiTieu() { }
        public SoChiTieu(string danhMuc, string soTien, string ngayThang, string ghiChu)
        {
            this.danhMuc = danhMuc;
            this.soTien = soTien;
            this.ngayThang = ngayThang;
            this.ghiChu = ghiChu;
        }

        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public string SoTien { get => soTien; set => soTien = value; }
        public string NgayThang { get => ngayThang; set => ngayThang = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
