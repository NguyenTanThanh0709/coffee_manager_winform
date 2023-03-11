using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Calamviec
    {
        private String ma_clv;
        private String ten_clv;
        private DateTime giobatdau;
        private DateTime gioketthuc;
        private int sotien;

        public Calamviec()
        {
        }

        public Calamviec(string ma_clv, string ten_clv, DateTime giobatdau, DateTime gioketthuc, int sotien)
        {
            this.Ma_clv = ma_clv;
            this.Ten_clv = ten_clv;
            this.Giobatdau = giobatdau;
            this.Gioketthuc = gioketthuc;
            this.Sotien = sotien;
        }

        public string Ma_clv { get => ma_clv; set => ma_clv = value; }
        public string Ten_clv { get => ten_clv; set => ten_clv = value; }
        public DateTime Giobatdau { get => giobatdau; set => giobatdau = value; }
        public DateTime Gioketthuc { get => gioketthuc; set => gioketthuc = value; }
        public int Sotien { get => sotien; set => sotien = value; }
    }
}
