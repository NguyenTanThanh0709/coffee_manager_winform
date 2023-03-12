namespace QuanLyQuanCafe
{
    partial class FHome_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_home_user = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_home_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_home_user
            // 
            this.menuStrip_home_user.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_home_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngToolStripMenuItem});
            this.menuStrip_home_user.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_home_user.Name = "menuStrip_home_user";
            this.menuStrip_home_user.Size = new System.Drawing.Size(1269, 33);
            this.menuStrip_home_user.TabIndex = 0;
            this.menuStrip_home_user.Text = "menustrip_info";
            this.menuStrip_home_user.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(471, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 1;
            // 
            // thôngToolStripMenuItem
            // 
            this.thôngToolStripMenuItem.Name = "thôngToolStripMenuItem";
            this.thôngToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // FHome_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip_home_user);
            this.MainMenuStrip = this.menuStrip_home_user;
            this.Name = "FHome_User";
            this.Text = "FHome_User";
            this.menuStrip_home_user.ResumeLayout(false);
            this.menuStrip_home_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip_home_user;
        private Panel panel1;
        private ToolStripMenuItem thôngToolStripMenuItem;
    }
}