using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitietluongnhanvien
    {
        private String ma_clv;
        private String sdt_nv;
        private int tongcalamviectrongthang;
        private int thanhtien;
        private int kyluong;

        public Chitietluongnhanvien()
        {
        }

        public Chitietluongnhanvien(string ma_clv, string sdt_nv, int tongcalamviectrongthang, int thanhtien, int kyluong)
        {
            this.Ma_clv = ma_clv;
            this.Sdt_nv = sdt_nv;
            this.Tongcalamviectrongthang = tongcalamviectrongthang;
            this.Thanhtien = thanhtien;
            this.Kyluong = kyluong;
        }

        public string Ma_clv { get => ma_clv; set => ma_clv = value; }
        public string Sdt_nv { get => sdt_nv; set => sdt_nv = value; }
        public int Tongcalamviectrongthang { get => tongcalamviectrongthang; set => tongcalamviectrongthang = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int Kyluong { get => kyluong; set => kyluong = value; }
    }
}
