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
    public partial class UC_ChinhSuaHoSo : UserControl
    {
        public event EventHandler BackClicked;
        public UC_ChinhSuaHoSo()
        {
            InitializeComponent();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thông tin thành công!");
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UC_ChinhSuaHoSo_Load(object sender, EventArgs e)
        {

        }
    }
}
