using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
                }
                return instance;
            }

        }

        public SanPhamDAO()
        {
        }

        public List<Hanghoa> getAllProducts()
        {

            List < Hanghoa > listProducts =  null;

            listProducts = DataProvider.Instance.getAllProdcuts();
            return listProducts;

        }
    }
}
