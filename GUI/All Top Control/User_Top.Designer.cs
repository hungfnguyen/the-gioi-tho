namespace GUI.All_Top_Control
{
    partial class User_Top
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnTopDoanhThu = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTopDanhGia = new Guna.UI2.WinForms.Guna2Button();
            this.btnTopCongViec = new Guna.UI2.WinForms.Guna2Button();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Controls.Add(this.btnTopCongViec);
            this.panel11.Controls.Add(this.btnTopDanhGia);
            this.panel11.Controls.Add(this.btnTopDoanhThu);
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1052, 83);
            this.panel11.TabIndex = 0;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // btnTopDoanhThu
            // 
            this.btnTopDoanhThu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopDoanhThu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopDoanhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopDoanhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnTopDoanhThu.Location = new System.Drawing.Point(42, 19);
            this.btnTopDoanhThu.Name = "btnTopDoanhThu";
            this.btnTopDoanhThu.Size = new System.Drawing.Size(180, 45);
            this.btnTopDoanhThu.TabIndex = 0;
            this.btnTopDoanhThu.Text = "Top Doanh Thu Thợ";
            this.btnTopDoanhThu.Click += new System.EventHandler(this.btnTopDoanhThu_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(20, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 414);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTopDanhGia
            // 
            this.btnTopDanhGia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopDanhGia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopDanhGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopDanhGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopDanhGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnTopDanhGia.Location = new System.Drawing.Point(288, 18);
            this.btnTopDanhGia.Name = "btnTopDanhGia";
            this.btnTopDanhGia.Size = new System.Drawing.Size(180, 45);
            this.btnTopDanhGia.TabIndex = 1;
            this.btnTopDanhGia.Text = "Top Đánh Giá Thợ";
            this.btnTopDanhGia.Click += new System.EventHandler(this.btnTopDanhGia_Click);
            // 
            // btnTopCongViec
            // 
            this.btnTopCongViec.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopCongViec.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopCongViec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopCongViec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopCongViec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTopCongViec.ForeColor = System.Drawing.Color.White;
            this.btnTopCongViec.Location = new System.Drawing.Point(515, 18);
            this.btnTopCongViec.Name = "btnTopCongViec";
            this.btnTopCongViec.Size = new System.Drawing.Size(180, 45);
            this.btnTopCongViec.TabIndex = 8;
            this.btnTopCongViec.Text = "Top Công Việc Book Nhiều";
            this.btnTopCongViec.Click += new System.EventHandler(this.btnTopCongViec_Click);
            // 
            // User_Top
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel11);
            this.Name = "User_Top";
            this.Size = new System.Drawing.Size(1052, 555);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2Button btnTopDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTopDanhGia;
        private Guna.UI2.WinForms.Guna2Button btnTopCongViec;
    }
}
