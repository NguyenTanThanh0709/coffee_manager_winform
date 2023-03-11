namespace QuanLyQuanCafe
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.linklb_register = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_err_pass = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_err_sdt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Gold;
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1245, 61);
            this.pnl_header.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_logo.Location = new System.Drawing.Point(0, 61);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(414, 619);
            this.pnl_logo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÔNG BẦU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnl_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_login.Controls.Add(this.linklb_register);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.panel3);
            this.pnl_login.Controls.Add(this.label2);
            this.pnl_login.Controls.Add(this.panel1);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_login.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_login.Location = new System.Drawing.Point(414, 61);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(831, 619);
            this.pnl_login.TabIndex = 2;
            // 
            // linklb_register
            // 
            this.linklb_register.AutoSize = true;
            this.linklb_register.Location = new System.Drawing.Point(330, 451);
            this.linklb_register.Name = "linklb_register";
            this.linklb_register.Size = new System.Drawing.Size(166, 25);
            this.linklb_register.TabIndex = 7;
            this.linklb_register.TabStop = true;
            this.linklb_register.Text = "Create new account";
            this.linklb_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_register_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(313, 374);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(189, 57);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_err_pass);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.tb_password);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(63, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 94);
            this.panel3.TabIndex = 5;
            // 
            // lb_err_pass
            // 
            this.lb_err_pass.AutoSize = true;
            this.lb_err_pass.ForeColor = System.Drawing.Color.Red;
            this.lb_err_pass.Location = new System.Drawing.Point(250, 62);
            this.lb_err_pass.Name = "lb_err_pass";
            this.lb_err_pass.Size = new System.Drawing.Size(230, 25);
            this.lb_err_pass.TabIndex = 4;
            this.lb_err_pass.Text = "Invalid password! try again!";
            this.lb_err_pass.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(250, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 1);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.ForeColor = System.Drawing.Color.Gray;
            this.tb_password.Location = new System.Drawing.Point(250, 14);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(364, 38);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(330, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_err_sdt);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(63, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 94);
            this.panel1.TabIndex = 0;
            // 
            // lb_err_sdt
            // 
            this.lb_err_sdt.AutoSize = true;
            this.lb_err_sdt.ForeColor = System.Drawing.Color.Red;
            this.lb_err_sdt.Location = new System.Drawing.Point(250, 62);
            this.lb_err_sdt.Name = "lb_err_sdt";
            this.lb_err_sdt.Size = new System.Drawing.Size(271, 25);
            this.lb_err_sdt.TabIndex = 4;
            this.lb_err_sdt.Text = "Invalid phone number! try again!";
            this.lb_err_sdt.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(250, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 1);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.ForeColor = System.Drawing.Color.Gray;
            this.tb_sdt.Location = new System.Drawing.Point(250, 14);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(364, 38);
            this.tb_sdt.TabIndex = 1;
            this.tb_sdt.Text = "Enter  phone number";
            this.tb_sdt.Click += new System.EventHandler(this.tb_sdt_Click);
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone number";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 680);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_header;
        private Panel pnl_logo;
        private Panel pnl_login;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox tb_sdt;
        private Label label3;
        private Label lb_err_sdt;
        private Panel panel3;
        private Label lb_err_pass;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox tb_password;
        private Label label5;
        private Button btn_login;
        private LinkLabel linklb_register;
        private PictureBox pictureBox4;
    }
}