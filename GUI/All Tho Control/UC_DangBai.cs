using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI.All_Tho_Control
{
    public partial class UC_DangBai : UserControl
    {
        private ModifyDAL modify = new ModifyDAL();

        private BaiDangBLL baiDangBLL = new BaiDangBLL();

        public UC_DangBai()
        {
            InitializeComponent();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bại có chắc chắn đăng bài không?", "Thông Báo", MessageBoxButtons.YesNo);
            
        }



        private void UC_DangBai_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLinhVuc_Click_1(object sender, EventArgs e)
        {
           
        }


        private void btnDangBai_Click_1(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string hoVaTen = txtHoVaTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            int soNamKinhNghiem = int.Parse(txtSoNamKinhNghiem.Text);
            string moTa = txtMoTa.Text;
            string linhVuc = cbLinhVuc.SelectedItem.ToString();
            int thoiGianThucHien = int.Parse(txtThoiGianThucHienCongViec.Text);
            decimal giaTien = decimal.Parse(txtGiaTien.Text);
            int idTho = LoginBLL.IDTho;
            

            // Gọi phương thức xử lý từ Business Logic Layer
            bool result = baiDangBLL.DangBai(hoVaTen, diaChi, soDienThoai, soNamKinhNghiem, moTa, linhVuc, thoiGianThucHien, giaTien, idTho);

            // Hiển thị kết quả
            if (result)
            {
                MessageBox.Show("Đăng bài thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đăng bài thất bại!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void uC_TrangChu1_Load(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtHoVaTen.Text;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            lblDiaChi.Text = txtDiaChi.Text;
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            lblSoDienThoai.Text = txtSoDienThoai.Text;
        }

        private void txtSoNamKinhNghiem_TextChanged(object sender, EventArgs e)
        {
            lblSoNamKN.Text = txtSoNamKinhNghiem.Text;
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            lblGia.Text = txtGiaTien.Text;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDanhMuc.Text = cbLinhVuc.SelectedItem.ToString();
        }

        private void lblTen_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDanhMuc_Click(object sender, EventArgs e)
        {
            
        }
    }
}
