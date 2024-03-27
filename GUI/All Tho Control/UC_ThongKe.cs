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
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Set up the DataGridView control
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Ngày";
            dataGridView1.Columns[1].Name = "Số đơn hoàn thành";
            dataGridView1.Columns[2].Name = "Số đơn đã hủy";
            dataGridView1.Columns[3].Name = "Tiền thu";

            // Add some sample data
            string[] row1 = { "Ngày 1 ", "10", "1", "100000 " };
            string[] row2 = { "Ngày 2 ", "15", "0", "20000" };
            string[] row3 = { "Ngày 3 ", "20", "3", "300000"};

            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
        }
    
    private void UC_ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
