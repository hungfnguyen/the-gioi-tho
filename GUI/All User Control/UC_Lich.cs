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

namespace GUI.All_User_Control
{
    public partial class UC_Lich : UserControl
    {
        public UC_Lich()
        {
            InitializeComponent();
        }

        // Constructor với tham số để truyền dữ liệu từ UC_HoatDong
        public UC_Lich(LichHen lichHen)
        {
            InitializeComponent();

            // Thực hiện gán dữ liệu từ lichHen vào các control trong UserControl
            txtLinhVuc.Text = lichHen.LinhVuc;
            txtTenTho.Text = lichHen.Ten;
            txtSDTTho.Text = lichHen.SDT;
            txtLichThoDen.Text = lichHen.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = lichHen.Gio;
            txtMoTaChiTiet.Text = lichHen.MoTaChiTiet;
            txtGhiChu.Text = lichHen.GhiChu;
            txtGiaTien.Text = lichHen.GiaTien.ToString();
        }

        private void UC_Lich_Load(object sender, EventArgs e)
        {

        }
    }
}
