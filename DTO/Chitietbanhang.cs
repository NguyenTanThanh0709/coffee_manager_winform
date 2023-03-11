using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitietbanhang
    {
        private String ma_hd_bh;
        private String ma_hanghoa;
        private int soluong;

        public Chitietbanhang()
        {
        }

        public Chitietbanhang(string ma_hd_bh, string ma_hanghoa, int soluong)
        {
            this.Ma_hd_bh = ma_hd_bh;
            this.Ma_hanghoa = ma_hanghoa;
            this.Soluong = soluong;
        }

        public string Ma_hd_bh { get => ma_hd_bh; set => ma_hd_bh = value; }
        public string Ma_hanghoa { get => ma_hanghoa; set => ma_hanghoa = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
