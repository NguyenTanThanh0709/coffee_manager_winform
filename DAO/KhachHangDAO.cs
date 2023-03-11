using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }

        }

        private KhachHangDAO()
        {

        }

        public Khachhang getAccountKhachHang(String sdt, String pass)
        {
            Khachhang khachhang = null;
            khachhang = DataProvider.Instance.ecuxeProcedure_getKHACHHANG(sdt, pass);
            return khachhang;
        }
    }
}
