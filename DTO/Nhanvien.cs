using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        private String sdt;
        private String ten_nv;
        private bool gioitinh;
        private String chucvu;
        private DateTime ngayvaolam;
        private String diachi;
        private bool trangthai;
        private bool phanquen;
        private String matkhau;

        public Nhanvien( string sdt, string ten_nv, bool gioitinh, string chucvu, DateTime ngayvaolam, string diachi, bool trangthai, bool phanquen, string matkhau)
        {
            this.sdt = sdt;
            this.ten_nv = ten_nv;
            this.gioitinh = gioitinh;
            this.chucvu = chucvu;
            this.ngayvaolam = ngayvaolam;
            this.diachi = diachi;
            this.trangthai = trangthai;
            this.phanquen = phanquen;
            this.matkhau = matkhau;
        }

        public Nhanvien()
        {

        }



        public string Sdt { get => sdt; set => sdt = value; }
        public string Ten_nv { get => ten_nv; set => ten_nv = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Trangthai { get => trangthai; set => trangthai = value; }
        public bool Phanquen { get => phanquen; set => phanquen = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }


    }
}
