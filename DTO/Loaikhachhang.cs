using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    

    public class LoaiKhachHang
    {
        private string maLoaiKH;
        private string tenLoaiKH;
        private int giamGia;

        



        // Constructor
        public LoaiKhachHang(string maLoaiKH, string tenLoaiKH, int giamGia)
        {
            this.maLoaiKH = maLoaiKH;
            this.tenLoaiKH = tenLoaiKH;
            this.giamGia = giamGia;
        }

        // Default constructor
        public LoaiKhachHang() { }

        // Method to insert a new row into the database

        public string MaLoaiKH { get => maLoaiKH; set => maLoaiKH = value; }
        public string TenLoaiKH { get => tenLoaiKH; set => tenLoaiKH = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }

    }
}
