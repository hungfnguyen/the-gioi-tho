namespace GUI.All_Tho_Control
{
    partial class UC_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            this.btnVi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.uC_XoaTK1 = new GUI.All_Tho_Control.UC_XoaTK();
            this.uC_DoiMK1 = new GUI.All_Tho_Control.UC_DoiMK();
            this.uC_ThongTinCaNhan1 = new GUI.All_Tho_Control.UC_ThongTinCaNhan();
            this.uC_Vi1 = new GUI.All_Login_Control.UC_Vi();
            this.uC_TaiKhoanNganHang1 = new GUI.All_Tho_Control.UC_TaiKhoanNganHang();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(106, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Name";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel1.Controls.Add(this.btnDangXuat);
            this.gunaPanel1.Controls.Add(this.btnXoaTaiKhoan);
            this.gunaPanel1.Controls.Add(this.btnDoiMatKhau);
            this.gunaPanel1.Controls.Add(this.btnVi);
            this.gunaPanel1.Controls.Add(this.btnTaiKhoan);
            this.gunaPanel1.Controls.Add(this.btnThongTin);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(4, 3);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(300, 543);
            this.gunaPanel1.TabIndex = 11;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDangXuat.BorderThickness = 1;
            this.btnDangXuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.White;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDangXuat.Location = new System.Drawing.Point(34, 454);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(237, 42);
            this.btnDangXuat.TabIndex = 15;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnXoaTaiKhoan.BorderThickness = 1;
            this.btnXoaTaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnXoaTaiKhoan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTaiKhoan.FillColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTaiKhoan.Image")));
            this.btnXoaTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaTaiKhoan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(34, 384);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(237, 42);
            this.btnXoaTaiKhoan.TabIndex = 14;
            this.btnXoaTaiKhoan.Text = "Xóa Tài Khoản";
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDoiMatKhau.BorderThickness = 1;
            this.btnDoiMatKhau.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDoiMatKhau.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDoiMatKhau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoiMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMatKhau.FillColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMatKhau.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(34, 316);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(237, 42);
            this.btnDoiMatKhau.TabIndex = 13;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnVi
            // 
            this.btnVi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnVi.BorderThickness = 1;
            this.btnVi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnVi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnVi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVi.FillColor = System.Drawing.Color.White;
            this.btnVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnVi.ForeColor = System.Drawing.Color.Black;
            this.btnVi.Image = ((System.Drawing.Image)(resources.GetObject("btnVi.Image")));
            this.btnVi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVi.ImageSize = new System.Drawing.Size(25, 25);
            this.btnVi.Location = new System.Drawing.Point(34, 248);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(237, 42);
            this.btnVi.TabIndex = 12;
            this.btnVi.Text = "Ví";
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTaiKhoan.BorderThickness = 1;
            this.btnTaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTaiKhoan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoan.FillColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaiKhoan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTaiKhoan.Location = new System.Drawing.Point(34, 179);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(237, 42);
            this.btnTaiKhoan.TabIndex = 11;
            this.btnTaiKhoan.Text = "    Tài Khoản Ngân Hàng";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThongTin.BorderThickness = 1;
            this.btnThongTin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTin.FillColor = System.Drawing.Color.White;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongTin.ForeColor = System.Drawing.Color.Black;
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTin.ImageSize = new System.Drawing.Size(25, 25);
            this.btnThongTin.Location = new System.Drawing.Point(34, 112);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.PressedDepth = 3;
            this.btnThongTin.Size = new System.Drawing.Size(237, 42);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông Tin Cá Nhân";
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click_1);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPanel2.Controls.Add(this.uC_XoaTK1);
            this.gunaPanel2.Controls.Add(this.uC_DoiMK1);
            this.gunaPanel2.Controls.Add(this.uC_ThongTinCaNhan1);
            this.gunaPanel2.Controls.Add(this.uC_Vi1);
            this.gunaPanel2.Controls.Add(this.uC_TaiKhoanNganHang1);
            this.gunaPanel2.Location = new System.Drawing.Point(310, 5);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(772, 541);
            this.gunaPanel2.TabIndex = 12;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // uC_XoaTK1
            // 
            this.uC_XoaTK1.BackColor = System.Drawing.Color.White;
            this.uC_XoaTK1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_XoaTK1.Location = new System.Drawing.Point(201, 110);
            this.uC_XoaTK1.Name = "uC_XoaTK1";
            this.uC_XoaTK1.Size = new System.Drawing.Size(378, 261);
            this.uC_XoaTK1.TabIndex = 4;
            // 
            // uC_DoiMK1
            // 
            this.uC_DoiMK1.BackColor = System.Drawing.Color.White;
            this.uC_DoiMK1.Location = new System.Drawing.Point(1, 0);
            this.uC_DoiMK1.Name = "uC_DoiMK1";
            this.uC_DoiMK1.Size = new System.Drawing.Size(770, 540);
            this.uC_DoiMK1.TabIndex = 3;
            this.uC_DoiMK1.Load += new System.EventHandler(this.uC_DoiMK1_Load);
            // 
            // uC_ThongTinCaNhan1
            // 
            this.uC_ThongTinCaNhan1.BackColor = System.Drawing.Color.White;
            this.uC_ThongTinCaNhan1.Location = new System.Drawing.Point(1, -1);
            this.uC_ThongTinCaNhan1.Name = "uC_ThongTinCaNhan1";
            this.uC_ThongTinCaNhan1.Size = new System.Drawing.Size(770, 540);
            this.uC_ThongTinCaNhan1.TabIndex = 2;
            // 
            // uC_Vi1
            // 
            this.uC_Vi1.BackColor = System.Drawing.Color.White;
            this.uC_Vi1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Vi1.Name = "uC_Vi1";
            this.uC_Vi1.Size = new System.Drawing.Size(770, 540);
            this.uC_Vi1.TabIndex = 1;
            // 
            // uC_TaiKhoanNganHang1
            // 
            this.uC_TaiKhoanNganHang1.Location = new System.Drawing.Point(-1, 0);
            this.uC_TaiKhoanNganHang1.Name = "uC_TaiKhoanNganHang1";
            this.uC_TaiKhoanNganHang1.Size = new System.Drawing.Size(770, 540);
            this.uC_TaiKhoanNganHang1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(1085, 549);
            this.Load += new System.EventHandler(this.UC_TaiKhoan_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private UC_ThongTinCaNhan uC_ThongTinCaNhan1;
        private All_Login_Control.UC_Vi uC_Vi1;
        private UC_TaiKhoanNganHang uC_TaiKhoanNganHang1;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnXoaTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnVi;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private UC_DoiMK uC_DoiMK1;
        private UC_XoaTK uC_XoaTK1;
    }
}
