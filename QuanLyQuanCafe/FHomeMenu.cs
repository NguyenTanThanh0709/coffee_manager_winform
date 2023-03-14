using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FHomeMenu : Form
    {
        public FHomeMenu()
        {
            InitializeComponent();
        }

        private void btn_douong_Click(object sender, EventArgs e)
        {
            pnl_douong.Visible = true;
            pnl_monan.Visible = false;
        }

        private void btn_monan_Click(object sender, EventArgs e)
        {
            pnl_douong.Visible = false;
            pnl_monan.Visible = true;
        }

        private void FHomeMenu_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void loadProduct()
        {
            List<Hanghoa> list = null;
            list = HangHoaBUS.Instance.getAllProducts();

            if(list == null)
            {
                int count = 0;
                int y = 3;
                int yy = 3;
                int countX = 0;
                int countY = 0;
                for (int i = 0; i < 5; i++)
                {
                    Panel myPanel = new Panel();
                    myPanel.BackColor = Color.Yellow;
                    pnl_listsanpham.Controls.Add(myPanel);
                    myPanel.Parent = pnl_listsanpham;
                    if (count == 0)
                    {
                        
                        myPanel.Location = new Point(3, y + (countX * 204));
                        //myPanel.Name = "panel_" + list[i].Ma_hanghoa.ToString();
                        myPanel.Size = new Size(183, 204);
                        y = y + 210;
                        countX++;
                    }
                    else if(count == 1) 
                    {
                        
                        myPanel.Location = new Point(192, y + (countY * 204));
                        //myPanel.Name = "panel_" + list[i].Ma_hanghoa.ToString();
                        myPanel.Size = new Size(183, 204);
                        yy = yy + 210;
                        countY++;
                    }
                    else
                    {
                        count = 0;
                    }
                    pnl_listsanpham.Controls.Add(myPanel);
                    myPanel.Parent = pnl_listsanpham;

                    count = count + 1;
                }

            }
        }
    }
}
