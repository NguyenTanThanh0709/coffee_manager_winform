using BUS;
using DTO;
namespace QuanLyQuanCafe
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_sdt.ForeColor = Color.White;
                lb_err_sdt.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_sdt.ForeColor = Color.White;
                lb_err_pass.Visible = false;
            }
            catch
            {

            }
        }

        private void tb_sdt_Click(object sender, EventArgs e)
        {
            tb_sdt.SelectAll();
        }

        private void tb_password_Click(object sender, EventArgs e)
        {
            tb_password.SelectAll();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            if (tb_sdt.Text == "" || tb_sdt.Text == "Enter  phone number")
            {
                lb_err_sdt.Visible = true;

                tb_sdt.Focus();
                return;
            }
            else if (tb_password.Text == "" || tb_password.Text == "")
            {
                lb_err_pass.Visible = true;
                tb_password.Focus();
                return;
            }
            else
            {
                String sdt = tb_sdt.Text.ToString();
                String pass = tb_password.Text.ToString();
                Khachhang khachhang= null;
                khachhang = KhachHangBUS.Instance.getAccountKhachHang(sdt, pass);
                if(khachhang != null)
                {
                    MessageBox.Show("ok");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            }

        private void linklb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRegister register= new FRegister();
            this.Hide();
            register.ShowDialog();
            this.Show();
            
        }

       
    }
}