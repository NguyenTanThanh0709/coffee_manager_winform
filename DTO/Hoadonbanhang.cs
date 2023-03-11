using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadonbanhang
    {
        private String ma_hd_bh;
        private String sdt_nv;
        private String sdt_kh;
        private String maban;
        private DateTime ngay_hd_bh;
        private int tongtien;
        private int diemtl;
        private int giamgia;
        private int chiphikhac;
        private String trangthai;

        public Hoadonbanhang()
        {
        }

        public Hoadonbanhang(string ma_hd_bh, string sdt_nv, string sdt_kh, string maban, DateTime ngay_hd_bh, int tongtien, int diemtl, int giamgia, int chiphikhac, string trangthai)
        {
            this.Ma_hd_bh = ma_hd_bh;
            this.Sdt_nv = sdt_nv;
            this.Sdt_kh = sdt_kh;
            this.Maban = maban;
            this.Ngay_hd_bh = ngay_hd_bh;
            this.Tongtien = tongtien;
            this.Diemtl = diemtl;
            this.Giamgia = giamgia;
            this.Chiphikhac = chiphikhac;
            this.Trangthai = trangthai;
        }

        public string Ma_hd_bh { get => ma_hd_bh; set => ma_hd_bh = value; }
        public string Sdt_nv { get => sdt_nv; set => sdt_nv = value; }
        public string Sdt_kh { get => sdt_kh; set => sdt_kh = value; }
        public string Maban { get => maban; set => maban = value; }
        public DateTime Ngay_hd_bh { get => ngay_hd_bh; set => ngay_hd_bh = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
        public int Chiphikhac { get => chiphikhac; set => chiphikhac = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
