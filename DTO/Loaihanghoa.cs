using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loaihanghoa
    {
        private String maloaihang;
        private String tenloaihang;
            private String mota;

        public string Maloaihang { get => maloaihang; set => maloaihang = value; }
        public string Tenloaihang { get => tenloaihang; set => tenloaihang = value; }
        public string Mota { get => mota; set => mota = value; }

        public Loaihanghoa(string maloaihang, string tenloaihang, string mota)
        {
            this.Maloaihang = maloaihang;
            this.Tenloaihang = tenloaihang;
            this.Mota = mota;
        }

        public Loaihanghoa()
        {
        }
    }
}
