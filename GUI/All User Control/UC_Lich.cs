using DTO;
using Guna.UI2.WinForms;
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

namespace GUI.All_User_Control
{
    public partial class UC_Lich : UserControl
    {
        private LichHen _lichHen; // Đối tượng LichHen được truyền vào UserControl

        // Khai báo các phương thức hoặc thuộc tính để truy cập từ bên ngoài
        public Guna2Button GetBtnHuyLichHen() { return btnHuyLichHen; }
        public Guna2Button GetBtnYeuCauDoiLich() { return btnYeuCauDoiLich; }

        public Guna2Button GetBtnChapNhan() { return btnChapNhan; }

        public UC_Lich()
        {
            InitializeComponent();
        }

        // Constructor với tham số để truyền dữ liệu từ UC_HoatDong
        public UC_Lich(LichHen lichHen)
        {
            InitializeComponent();

            

            _lichHen = lichHen; // Lưu đối tượng LichHen được truyền vào

            UpdateData();

            /*// Thực hiện gán dữ liệu từ lichHen vào các control trong UserControl
            txtLinhVuc.Text = lichHen.LinhVuc;
            txtTenTho.Text = lichHen.Ten;
            txtSDTTho.Text = lichHen.SDT;
            txtLichThoDen.Text = lichHen.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = lichHen.Gio;
            txtMoTaChiTiet.Text = lichHen.MoTaChiTiet;
            txtGhiChu.Text = lichHen.GhiChu;
            txtGiaTien.Text = lichHen.GiaTien.ToString();*/
        }

        // Phương thức cập nhật dữ liệu hiển thị trên giao diện từ đối tượng LichHen
        private void UpdateData()
        {
            txtLinhVuc.Text = _lichHen.LinhVuc;
            txtTenTho.Text = _lichHen.Ten;
            txtSDTTho.Text = _lichHen.SDT;
            txtLichThoDen.Text = _lichHen.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = _lichHen.Gio;
            txtMoTaChiTiet.Text = _lichHen.MoTaChiTiet;
            txtGhiChu.Text = _lichHen.GhiChu;
            txtGiaTien.Text = _lichHen.GiaTien.ToString();

        }

        private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";
        private void UpdateDatabase(int lichHenID, string trangThaiCongViecNguoiDung, string trangThaiCongViecTho)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu lệnh SQL để cập nhật giá trị của hai thuộc tính trong bảng Công việc
                    string query = "UPDATE CongViec SET TrangThaiCongViecTho = @TrangThaiTho, TrangThaiCongViecNguoiDung = @TrangThaiNguoiDung WHERE IDCongViec = @IDLichHen";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@TrangThaiTho", trangThaiCongViecTho); // Đặt giá trị mới cho hai thuộc tính
                        command.Parameters.AddWithValue("@TrangThaiNguoiDung", trangThaiCongViecNguoiDung);
                        command.Parameters.AddWithValue("@IDLichHen", lichHenID);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bao nhiêu dòng dữ liệu đã được ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Đã cập nhật thành công trong cơ sở dữ liệu!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật dữ liệu trong cơ sở dữ liệu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu trong cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void UC_Lich_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyLichHen_Click(object sender, EventArgs e)
        {
            // Cập nhật giá trị của TrangThaiCongViecTho và TrangThaiCongViecNguoiDung khi nhấn vào nút Hủy
            /*            _lichHen.TrangThaiCongViecTho = "Đã hủy";
                        _lichHen.TrangThaiCongViecNguoiDung = "Đã hủy";*/

            UpdateDatabase(_lichHen.IDLichHen, "Đã hủy", "Đã hủy");
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            this.Dispose();
            MessageBox.Show("Đã hủy lịch hẹn!");
        }

        private void btnYeuCauDoiLich_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form thay đổi ngày và giờ
            FormThayDoiNgayGio formThayDoiNgayGio = new FormThayDoiNgayGio(_lichHen.IDLichHen);

            // Hiển thị form
            formThayDoiNgayGio.ShowDialog();

            // Kiểm tra xem form có đóng hay không
            if (formThayDoiNgayGio.DialogResult == DialogResult.OK)
            {

                UpdateDatabase(_lichHen.IDLichHen, "Đang chờ thợ xác nhận", "Chưa xử lý");


                this.Dispose();
                // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
                MessageBox.Show("Đã yêu cầu dời lịch hẹn!");
            }

            
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            UpdateDatabase(_lichHen.IDLichHen, "Đã xác nhận", "Đã chấp nhận");
            this.Dispose();
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            MessageBox.Show("Đã chấp nhận công việc!");
        }
    }
}
