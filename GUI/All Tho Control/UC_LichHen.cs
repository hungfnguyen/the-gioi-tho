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
using static DTO.BaiDang;
using static DTO.LichHenTho;

namespace GUI.All_Tho_Control
{
    public partial class UC_LichHen : UserControl
    {
        private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

        public UC_LichHen()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load danh sách lịch hẹn khi UserControl được khởi tạo
            HienThiDanhSachLichHen(GetDanhSachLichHenTho());
        }

        private List<LichHenTho> GetDanhSachLichHenTho()
        {
            List<LichHenTho> danhSachLichHen = new List<LichHenTho>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT T.IDCongViec, T.Ten, T.SDT, T.DiaChi, T.LichThoDen, T.Gio, T.MoTaChiTiet, T.GhiChu, T.TrangThaiCongViecTho, Q.GiaTien, Q.LinhVuc " +
                                   "FROM CongViec T INNER JOIN BaiDang Q ON T.IDBaiDang = Q.IDBaiDang";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        LichHenTho lichhen = new LichHenTho();
                        lichhen.ID = Convert.ToInt32(reader["IDCongViec"]);
                        lichhen.Ten = reader["Ten"].ToString();
                        lichhen.DiaChi = reader["DiaChi"].ToString();
                        lichhen.SDT = reader["SDT"].ToString();
                        lichhen.LichHenDen = (DateTime)reader["LichThoDen"];
                        lichhen.MoTaChiTiet = reader["MoTaChiTiet"].ToString();
                        lichhen.GhiChu = reader["GhiChu"].ToString();
                        lichhen.TrangThaiCongVietTho = reader["TrangThaiCongViecTho"].ToString();
                        lichhen.GiaTien = Convert.ToDecimal(reader["GiaTien"]);
                        lichhen.Gio = reader["Gio"].ToString();
                        lichhen.LinhVuc = reader["LinhVuc"].ToString();

                        danhSachLichHen.Add(lichhen);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }

        private void HienThiDanhSachLichHen(List<LichHenTho> danhSach)
        {
            pnlxemhen.Controls.Clear();

            foreach (LichHenTho lichHen in danhSach)
            {
                UC_Lich ucLich = new UC_Lich(lichHen);
                ucLich.Dock = DockStyle.Top;
                pnlxemhen.Controls.Add(ucLich);
            }
        }

        private void UpdateDanhSachLichHen(string trangThai)
        {
            List<LichHenTho> danhSachLichHen = GetDanhSachLichHenThoTheoTrangThai(trangThai);
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private List<LichHenTho> GetDanhSachLichHenThoTheoTrangThai(string trangThai)
        {
            List<LichHenTho> danhSachLichHen = new List<LichHenTho>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT T.IDCongViec, T.Ten, T.SDT, T.DiaChi, T.LichThoDen, T.Gio, T.MoTaChiTiet, T.GhiChu, T.TrangThaiCongViecTho, Q.GiaTien, Q.LinhVuc " +
                                   "FROM CongViec T INNER JOIN BaiDang Q ON T.IDBaiDang = Q.IDBaiDang " +
                                   "WHERE T.TrangThaiCongViecTho = @TrangThai";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        LichHenTho lichhen = new LichHenTho();
                        lichhen.ID = Convert.ToInt32(reader["IDCongViec"]);
                        lichhen.Ten = reader["Ten"].ToString();
                        lichhen.DiaChi = reader["DiaChi"].ToString();
                        lichhen.SDT = reader["SDT"].ToString();
                        lichhen.LichHenDen = (DateTime)reader["LichThoDen"];
                        lichhen.MoTaChiTiet = reader["MoTaChiTiet"].ToString();
                        lichhen.GhiChu = reader["GhiChu"].ToString();
                        lichhen.TrangThaiCongVietTho = reader["TrangThaiCongViecTho"].ToString();
                        lichhen.GiaTien = Convert.ToDecimal(reader["GiaTien"]);
                        lichhen.Gio = reader["Gio"].ToString();
                        lichhen.LinhVuc = reader["LinhVuc"].ToString();

                        danhSachLichHen.Add(lichhen);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }

        private void btnChuaxuly_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Chưa xử lý");
        }

        private void btnchapnhan_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã chấp nhận");
        }

        private void bttuchoi_Click(object sender, EventArgs e)
        {
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Từ Chối");
        }

        private void btnHoanthanh_Click(object sender, EventArgs e)
        {
            // Xử lý logic khi người dùng nhấn nút "Hoàn thành"
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã hoàn thành");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xử lý logic
            pnlxemhen.Controls.Clear();
            UpdateDanhSachLichHen("Đã hủy");
        }
    }
}
