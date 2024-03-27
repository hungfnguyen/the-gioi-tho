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
    public partial class UC_Lich : UserControl
    {
        public UC_Lich()
        {
            InitializeComponent();
        }
        // Constructor với tham số để truyền dữ liệu từ UC_HoatDong
        public UC_Lich(LichHenTho lichHenTho)
        {
            InitializeComponent();

            // Thực hiện gán dữ liệu từ lichHen vào các control trong UserControl
            lblID.Text = lichHenTho.ID.ToString();
            txtLinhVuc.Text = lichHenTho.LinhVuc;
            txtTenKhachHang.Text = lichHenTho.Ten;
            txtSoDienThoai.Text = lichHenTho.SDT;
            txtLichThoDen.Text = lichHenTho.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = lichHenTho.Gio;
            txtDiaChi.Text = lichHenTho.DiaChi;
            txtGhiChu.Text = lichHenTho.GhiChu;
            txtGia.Text = lichHenTho.GiaTien.ToString();
        }

        private void UC_Lich_Load(object sender, EventArgs e)
        {

        }
    }
}
