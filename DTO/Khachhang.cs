using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Khachhang
    {
        private String sdt;
        private String ten_kh;
        private int diemtl;
        private String password;
        private String ma_loaikh;

        public Khachhang(string sdt, string ten_kh, int diemtl, string password, string ma_loaikh)
        {
            this.sdt = sdt;
            this.ten_kh = ten_kh;
            this.diemtl = diemtl;
            this.password = password;
            this.ma_loaikh = ma_loaikh;

        }

        public Khachhang()
        {
        }

        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_kh { get => ten_kh; set => ten_kh = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        public string Password { get => password; set => password = value; }
        public string Ma_loaikh { get => ma_loaikh; set => ma_loaikh = value; }
    }
}
