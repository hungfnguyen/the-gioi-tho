using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmXemThoChiTiet : Form
    {
        public FrmXemThoChiTiet()
        {
            InitializeComponent();
            uC_XemChiTietDanhGia1.Visible = false;
        }

        private void FrmXemThoChiTiet_Load(object sender, EventArgs e)
        {

        }

        private void btnXemChiTietDanhGia_Click(object sender, EventArgs e)
        {
            uC_XemChiTietDanhGia1.Visible = true;
            uC_XemChiTietDanhGia1.BringToFront();
        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form Đặt Lịch
            DatLich formDatLich = new DatLich();
            formDatLich.ShowDialog();  // Sử dụng ShowDialog để form hiển thị ở chế độ modal
        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
