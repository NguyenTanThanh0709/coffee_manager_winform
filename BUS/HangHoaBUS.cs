using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class HangHoaBUS
    {
        private static HangHoaBUS instance;
        public static HangHoaBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HangHoaBUS();
                }
                return instance;
            }

        }

        public HangHoaBUS()
        {

        }

        public List<Hanghoa> getAllProducts()
        {
            List<Hanghoa> lists = null;
            lists = SanPhamDAO.Instance.getAllProducts();
            return lists;
        }
    }
}
