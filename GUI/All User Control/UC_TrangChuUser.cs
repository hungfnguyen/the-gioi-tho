using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class uC_TrangChuUser : UserControl
    {
        public uC_TrangChuUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính cho dialog
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "File ảnh (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp

            // Hiển thị dialog và kiểm tra nếu người dùng đã chọn tệp
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp đã chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị đường dẫn hoặc thực hiện các thao tác khác với tệp ảnh tại đây
                // Ví dụ: hiển thị ảnh trên một control PictureBox
                pbAnh.Image = Image.FromFile(filePath);
            }
        }

        private void cbGio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pbAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
