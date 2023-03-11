using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangBUS();
                }
                return instance;
            }

        }

        private KhachHangBUS()
        {

        }
        public Khachhang getAccountKhachHang(String sdt, String password)
        {
            Khachhang khachhang = null;
            khachhang = DAO.KhachHangDAO.Instance.getAccountKhachHang(sdt, password);
            return khachhang;
        }
    }
}
