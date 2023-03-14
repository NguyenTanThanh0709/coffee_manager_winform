using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=LAPTOP-B40M7BKJ\SQLEXPRESS;Initial Catalog=QuanLyCoffeOngBau;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }
        private DataProvider() { }

        public bool InsertAccountKhachHang(string sdt, string name, int diemtl, string pass)
        {
            String loaikhachhang = "1";
            String query = "insert_khachhang @p_sdt , @p_ten_kh , @p_diemtl , @p_password , @p_ma_loaikh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { sdt, name, diemtl, pass, loaikhachhang });
            if (data.Rows.Count != 1)
            {
                return false;
            }
            else
            {
                foreach (DataRow item in data.Rows)
                {
                   
                    String check = item["stt"].ToString();
                    if (check.Equals("done"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public List<Hanghoa> getAllProdcuts()
        {
            String query = "select * from hanghoa";
            List<Hanghoa> listProducts = null;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Hanghoa hh = new Hanghoa(item);
                listProducts.Add(hh);
            }

            return listProducts;
        }

        public Khachhang ecuxeProcedure_getKHACHHANG(String sdt, String pass)
        {
            String query = "usp_Login_KHACHHANG @sdt , @pass";
            List<Khachhang> KhachhangList = new List<Khachhang>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] {sdt,pass});

            if (data.Rows.Count != 1)
            {
                return null;
            }
            else
            {
                foreach (DataRow item in data.Rows)
                {
                    Khachhang kh = new Khachhang(item);
                    KhachhangList.Add(kh);
                }
            }
            return KhachhangList[0];
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        
    }
}
