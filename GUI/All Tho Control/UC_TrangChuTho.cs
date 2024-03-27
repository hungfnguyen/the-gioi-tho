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
    public partial class UC_TrangChuTho : UserControl
    {
        public UC_TrangChuTho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(55, 52, 169);
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(55, 52, 169);
            label1.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(55, 52, 169);
            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label5.ForeColor= Color.Black;
        }

        private void UC_TrangChuTho_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(55, 52, 169);
            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
        }
    }
}
