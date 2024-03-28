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

namespace GUI.All_User_Control
{
    public partial class UC_HoatDong : UserControl
    {
        public UC_HoatDong()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void UC_HoatDong_Load(object sender, EventArgs e)
        {

        }

        private void dgvHoatDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeDataGridView()
        {

            // Thêm dữ liệu mẫu
            AddSampleDataToDataGridView();
        }

        private void AddSampleDataToDataGridView()
        {
            // Lấy danh sách mẫu của các lịch hẹn từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHen();

            // Duyệt qua danh sách lịch hẹn và thêm từng lịch hẹn vào pnlLichHen
            foreach (LichHen lichHen in danhSachLichHen)
            {
                UC_Lich ucLich = new UC_Lich(lichHen); // Khởi tạo UC_Lich với dữ liệu tương ứng
                ucLich.Dock = DockStyle.Top; // Đặt DockStyle của UC_Lich thành Top để chúng được thêm vào pnlLichHen từ trên xuống
                pnlXemLichHen.Controls.Add(ucLich); // Thêm UC_Lich vào pnlLichHen

            }
        }

        private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

        public List<LichHen> GetDanhSachLichHen()
        {
            List<LichHen> danhSachLichHen = new List<LichHen>();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy thông tin từ các bảng liên quan
                    string query = @"SELECT cv.IDCongViec, bd.LinhVuc, cv.LichThoDen, cv.Gio, cv.MoTaChiTiet, cv.GhiChu, bd.GiaTien,
                                     tk.HoTen AS TenTho, tk.SoDienThoai AS SDTTho, cv.TrangThaiCongViecTho, cv.TrangThaiCongViecNguoiDung
                                     FROM CongViec cv
                                     INNER JOIN BaiDang bd ON cv.IDBaiDang = bd.IDBaiDang
                                     INNER JOIN TaiKhoanTho tk ON bd.IDTho = tk.IDTho";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ kết quả truy vấn và chuyển đổi sang đối tượng LichHen
                            LichHen lichHen = new LichHen
                            {
                                IDLichHen = reader.GetInt32(reader.GetOrdinal("IDCongViec")),
                                LinhVuc = reader["LinhVuc"].ToString(),
                                Ten = reader["TenTho"].ToString(),
                                SDT = reader["SDTTho"].ToString(),
                                LichHenDen = Convert.ToDateTime(reader["LichThoDen"]),
                                Gio = reader["Gio"].ToString(),
                                MoTaChiTiet = reader["MoTaChiTiet"].ToString(),
                                GhiChu = reader["GhiChu"].ToString(),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThaiCongViecTho = reader["TrangThaiCongViecTho"].ToString(),
                                TrangThaiCongViecNguoiDung = reader["TrangThaiCongViecNguoiDung"].ToString()
                            };

                            danhSachLichHen.Add(lichHen);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }

        private List<LichHen> GetDanhSachLichHenTheoTrangThai(string trangThai)
        {
            List<LichHen> danhSachLichHen = new List<LichHen>();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy thông tin từ các bảng liên quan
                    string query = @"SELECT cv.IDCongViec, bd.LinhVuc, cv.LichThoDen, cv.Gio, cv.MoTaChiTiet, cv.GhiChu, bd.GiaTien,
                             tk.HoTen AS TenTho, tk.SoDienThoai AS SDTTho, cv.TrangThaiCongViecTho, cv.TrangThaiCongViecNguoiDung
                             FROM CongViec cv
                             INNER JOIN BaiDang bd ON cv.IDBaiDang = bd.IDBaiDang
                             INNER JOIN TaiKhoanTho tk ON bd.IDTho = tk.IDTho
                             WHERE cv.TrangThaiCongViecNguoiDung = @TrangThai";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrangThai", trangThai);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ kết quả truy vấn và chuyển đổi sang đối tượng LichHen
                            LichHen lichHen = new LichHen
                            {
                                IDLichHen = reader.GetInt32(reader.GetOrdinal("IDCongViec")),
                                LinhVuc = reader["LinhVuc"].ToString(),
                                Ten = reader["TenTho"].ToString(),
                                SDT = reader["SDTTho"].ToString(),
                                LichHenDen = Convert.ToDateTime(reader["LichThoDen"]),
                                Gio = reader["Gio"].ToString(),
                                MoTaChiTiet = reader["MoTaChiTiet"].ToString(),
                                GhiChu = reader["GhiChu"].ToString(),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThaiCongViecTho = reader["TrangThaiCongViecTho"].ToString(),
                                TrangThaiCongViecNguoiDung = reader["TrangThaiCongViecNguoiDung"].ToString()
                            };

                            danhSachLichHen.Add(lichHen);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }

        private void HienThiDanhSachLichHen(List<LichHen> danhSachLichHen)
        {
            // Xóa tất cả các lịch hẹn đang hiển thị trên giao diện
            pnlXemLichHen.Controls.Clear();

            // Duyệt qua danh sách lịch hẹn và hiển thị lên giao diện
            foreach (LichHen lichHen in danhSachLichHen)
            {


                UC_Lich ucLich = new UC_Lich(lichHen); // Khởi tạo UC_Lich với dữ liệu tương ứng

                // ẩn các nút theo các mục
                if (lichHen.TrangThaiCongViecNguoiDung == "Đã hủy")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }

                if (lichHen.TrangThaiCongViecNguoiDung == "Hoàn tất")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }

                if (lichHen.TrangThaiCongViecNguoiDung == "Đã xác nhận")
                {
                    //ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }

                ucLich.Dock = DockStyle.Top; // Đặt DockStyle của UC_Lich thành Top để chúng được thêm vào pnlLichHen từ trên xuống
                pnlXemLichHen.Controls.Add(ucLich); // Thêm UC_Lich vào pnlLichHen

                // Kiểm tra trạng thái của lịch hẹn và ẩn/hiển thị các nút tương ứng
                
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLichHen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlXemLichHen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangChoThoXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn đang chờ thợ xác nhận từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đang chờ thợ xác nhận");

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnYeuCauDoiLich_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Yêu cầu dời lịch");

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnDaXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đã xác nhận");

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Hoàn tất");

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnDaHuy_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đã hủy");

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

    }
}
