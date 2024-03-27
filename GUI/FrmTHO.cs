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

/*        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_TrangChu1.Visible = true;
            uC_TrangChu1.BringToFront();
        }
*/
        private void FrmTHO_Load(object sender, EventArgs e)
        {
           // uC_TrangChu1.Visible = false;
            uC_TaiKhoan1.Visible = false;
            uC_DangBai1.Visible = false;
            uC_ThongBao1.Visible = false;
            uC_ThongKe1.Visible = false;
            guna2Button3.PerformClick();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            uC_TaiKhoan1.Visible = true;
            uC_TaiKhoan1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uC_DangBai1.Visible = true;
            uC_DangBai1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_ThongBao1.Visible=true;
            uC_ThongBao1.BringToFront();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            uC_ThongKe1.Visible = true ;
            uC_ThongKe1.BringToFront();
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
