using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.All_Tho_Control;

namespace GUI
{
    public partial class DatLich : Form
    {
        public int IDBaiDang { get; set; }

        public DatLich(int iDBaiDang)
        {
            InitializeComponent();
            // Thiết lập StartPosition để hiển thị form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            IDBaiDang = iDBaiDang;
            lblIDBaiDang.Text = iDBaiDang.ToString();
        }

        public DatLich()
        {
            InitializeComponent();
            // Thiết lập StartPosition để hiển thị form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void DatLich_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True"))
            {
                // Tạo truy vấn SQL INSERT
                string query = "INSERT INTO CongViec (IDNguoiDat, Ten, SDT, DiaChi, LichThoDen, Gio, MoTaChiTiet, GhiChu, IDBaiDang, TrangThaiCongViecTho, TrangThaiCongViecNguoiDung) " +
                               "VALUES (@IDNguoiDat, @Ten, @SDT, @DiaChi, @LichThoDen, @Gio, @MoTaChiTiet, @GhiChu, @IDBaiDang, @TrangThaiCongViecTho, @TrangThaiCongViecNguoiDung)";

                // Tạo và mở kết nối
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Đặt các tham số cho truy vấn
                    command.Parameters.AddWithValue("@IDNguoiDat", BLL.LoginBLL.IDNguoiDung); // Thay thế idNguoiDat bằng ID của người đặt công việc
                    command.Parameters.AddWithValue("@Ten", txtTen.Text);
                    command.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("@LichThoDen", dtpLichThoDen.Value);
                    command.Parameters.AddWithValue("@Gio", cbGio.Text);
                    command.Parameters.AddWithValue("@MoTaChiTiet", txtMoTaChiTiet.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang); // Thay thế idBaiDang bằng ID của bài đăng tương ứng
                    command.Parameters.AddWithValue("@TrangThaiCongViecTho", "Chờ xác nhận"); // Mặc định trạng thái cho thợ là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@TrangThaiCongViecNguoiDung", "Đã hủy"); // Mặc định trạng thái cho người dùng là "Chờ xác nhận"

                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có dữ liệu được chèn thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã đặt lịch thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch thất bại. Vui lòng thử lại sau!");
                    }
                }
            }

        }
    }
}
