using GUI.All_Tho_Control;
using GUI.All_User_Control;
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
    public partial class FrmTHO : Form
    {
        public FrmTHO()
        {
            InitializeComponent();
        }

        private void HideAllUC()
        {
            uC_TaiKhoan1.Visible = false;
            uC_DangBai1.Visible = false;
            uC_LichHen1.Visible = false;
            uC_ThongKe1.Visible = false;
        }

        private void FrmTHO_Load(object sender, EventArgs e)
        {
            // uC_TrangChu1.Visible = false;
            HideAllUC();
            btnDangBai.PerformClick();
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_LichHen1.Visible = true;

        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DangBai1.Visible = true;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_ThongKe1.Visible = true;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_TaiKhoan1.Visible = true;
        }
    }
}
