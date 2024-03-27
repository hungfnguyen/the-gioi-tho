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

namespace GUI.All_Tho_Control
{
    public partial class UC_BaiDangTho : UserControl
    {
        public int IDBaiDang { get; set; }

        public UC_BaiDangTho(BaiDang baiDang)
        {
            InitializeComponent();
            
            lblIDBaiDang.Text = baiDang.IDBaiDang.ToString();
            lblTen.Text = baiDang.HoTen;
            lblDiaChi.Text = baiDang.DiaChi;
            lblSoDienThoai.Text = baiDang.SoDienThoai;
            lblSoNamKN.Text = baiDang.SoNamKinhNghiem.ToString();
            lblGia.Text = baiDang.GiaTien.ToString();
            lblLinhVuc.Text = baiDang.LinhVuc.ToString();

            IDBaiDang = int.Parse(lblIDBaiDang.Text);
        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form Đặt Lịch
            DatLich formDatLich = new DatLich(IDBaiDang);
            formDatLich.ShowDialog();  // Sử dụng ShowDialog để form hiển thị ở chế độ modal
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmXemThoChiTiet frmXemThoChiTiet = new FrmXemThoChiTiet();
            frmXemThoChiTiet.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void UC_BaiDangTho_Load(object sender, EventArgs e)
        {

        }
    }
}
