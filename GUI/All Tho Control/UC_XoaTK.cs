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
    public partial class UC_XoaTK : UserControl
    {
        public UC_XoaTK()
        {
            InitializeComponent();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản không?","Nhắc Nhở",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
