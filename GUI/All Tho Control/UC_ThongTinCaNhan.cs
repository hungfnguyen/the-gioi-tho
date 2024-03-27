using GUI.All_Login_Control;
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
    public partial class UC_ThongTinCaNhan : UserControl
    {
        public UC_ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void UC_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            uC_ChinhSuaHoSo1.BackClicked += UC_Thongtin_BackClicked;
            uC_ChinhSuaHoSo1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChinhSuaHoSo_Click(object sender, EventArgs e)
        {
            uC_ChinhSuaHoSo1.Visible = true;
        }
        private void UC_Thongtin_BackClicked(object sender, EventArgs e)
        {
            uC_ChinhSuaHoSo1.Visible = false;
            // uC_DangNhap1.BringToFront();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void uC_ChinhSuaHoSo1_Load(object sender, EventArgs e)
        {

        }
    }
}
