using DAL;
using GUI.All_Calendar_Control;
using GUI.All_User_Control;
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

namespace GUI.All_Top_Control
{
    public partial class User_Top : UserControl
    {
        

        public User_Top()
        {
            InitializeComponent();
        }

        private void btnTopDoanhThu_Click(object sender, EventArgs e)
        {
            // Xóa các điều khiển hiện có trong panel1 (nếu có)
            panel1.Controls.Clear();
           


            // Thực hiện truy vấn SQL để lấy danh sách top doanh thu của các thợ
            string query = @"SELECT TOP 10
    tk.IDTho,
    tk.HoTen,
    tk.SoDienThoai,
    tk.DiaChi,
    tk.SoNamKinhNghiem,
    COUNT(bd.IDBaiDang) AS SoLuongBaiDang,
    SUM(bd.GiaTien) AS DoanhThu
FROM
    TaiKhoanTho tk
INNER JOIN
    BaiDang bd ON tk.IDTho = bd.IDTho
INNER JOIN
    CongViec cv ON bd.IDTho = cv.IDTho
WHERE
    cv.TrangThaiCongViecTho = @TrangThai
GROUP BY
    tk.IDTho,
    tk.HoTen,
    tk.SoDienThoai,
    tk.DiaChi,
    tk.SoNamKinhNghiem
ORDER BY
    DoanhThu DESC";

            

            // Thực hiện truy vấn và lấy kết quả
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // Thêm tham 
                    command.Parameters.AddWithValue("@TrangThai", "Đã hoàn thành");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

           

            int xPosition = 0; // Thiết lập vị trí x ban đầu
            foreach (DataRow row in dt.Rows)
            {
                ThongTinTho tho = new ThongTinTho
                {
                    IDTho = Convert.ToInt32(row["IDTho"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SoNamKinhNghiem = Convert.ToInt32(row["SoNamKinhNghiem"])
                };

                UC_ThoYeuThich ucTho = new UC_ThoYeuThich(tho);
                ucTho.ShowDoanhThu = true; // Hiển thị txtDoanhThu

                // Thiết lập vị trí cho UC_ThoYeuThich từ trái sang phải
                ucTho.Location = new Point(xPosition, 0);
                xPosition += ucTho.Width + 10; // Tăng vị trí x cho các UC tiếp theo

                panel1.Controls.Add(ucTho);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTopDanhGia_Click(object sender, EventArgs e)
        {
            // Xóa các UC_ThoYeuThich hiện có trong panel1 (nếu có)
            panel1.Controls.Clear();

            // Thực hiện truy vấn SQL để lấy danh sách top thợ đánh giá cao nhất hoặc thấp nhất
            string query = @"SELECT TOP 10
                            tk.IDTho,
                            tk.HoTen,
                            tk.SoDienThoai,
                            tk.DiaChi,
                            tk.SoNamKinhNghiem,
                            COUNT(dg.IDDanhGia) AS SoLuongDanhGia,
                            AVG(dg.SoSao) AS DiemTrungBinh
                        FROM
                            TaiKhoanTho tk
                        LEFT JOIN
                            CongViec cv ON tk.IDTho = cv.IDTho
                        LEFT JOIN
                            DanhGia dg ON cv.IDCongViec = dg.IDCongViec
                        GROUP BY
                            tk.IDTho,
                            tk.HoTen,
                            tk.SoDienThoai,
                            tk.DiaChi,
                            tk.SoNamKinhNghiem
                        ORDER BY
                            DiemTrungBinh DESC"; // Hoặc ASC nếu bạn muốn top thợ đánh giá thấp nhất

            // Thực hiện truy vấn và lấy kết quả
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            int xPosition = 0; // Thiết lập vị trí x ban đầu
            foreach (DataRow row in dt.Rows)
            {
                ThongTinTho tho = new ThongTinTho
                {
                    IDTho = Convert.ToInt32(row["IDTho"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    SoNamKinhNghiem = Convert.ToInt32(row["SoNamKinhNghiem"])
                };

                UC_ThoYeuThich ucTho = new UC_ThoYeuThich(tho);
                ucTho.ShowDoanhThu = false; // Ẩn hiển thị doanh thu

                // Thiết lập vị trí cho UC_ThoYeuThich
                ucTho.Location = new Point(xPosition, 0);
                xPosition += ucTho.Width + 10; // Tăng vị trí x cho các UC tiếp theo
                ucTho.IsTopDanhGia = true;
                panel1.Controls.Add(ucTho);
            }
        }

        private void btnTopCongViec_Click(object sender, EventArgs e)
        {
            XemTop5CongViecDuocDatNhieuNhatTheoLinhVuc();
        }
        private void XemTop5CongViecDuocDatNhieuNhatTheoLinhVuc()
        {
            // Xóa các điều khiển hiện có trong panel1 (nếu có)
            panel1.Controls.Clear();

            // Thực hiện truy vấn SQL để lấy top 5 công việc được book nhiều nhất theo lĩnh vực
            string query = @"SELECT cv.LinhVuc, COUNT(*) AS SoLanDat
                    FROM CongViec cv
                    GROUP BY cv.LinhVuc
                    ORDER BY SoLanDat DESC
                    OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY";

            // Thực hiện truy vấn và lấy kết quả
            DataTable dt = new DataTable();
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            // Tạo DataGridView để hiển thị kết quả
            DataGridView dgvTop5CongViec = new DataGridView();
            dgvTop5CongViec.AutoGenerateColumns = true;
            dgvTop5CongViec.Dock = DockStyle.Fill;

            // Tạo và thêm cột vào DataGridView
            DataGridViewTextBoxColumn colLinhVuc = new DataGridViewTextBoxColumn();
            colLinhVuc.HeaderText = "Lĩnh Vực";
            colLinhVuc.DataPropertyName = "LinhVuc";
            dgvTop5CongViec.Columns.Add(colLinhVuc);

            DataGridViewTextBoxColumn colSoLanDat = new DataGridViewTextBoxColumn();
            colSoLanDat.HeaderText = "Số Lần Đặt";
            colSoLanDat.DataPropertyName = "SoLanDat";
            dgvTop5CongViec.Columns.Add(colSoLanDat);

            // Gán dữ liệu cho DataGridView
            dgvTop5CongViec.DataSource = dt;

            dgvTop5CongViec.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvTop5CongViec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTop5CongViec.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvTop5CongViec.DefaultCellStyle.BackColor = Color.LightGray;
            dgvTop5CongViec.DefaultCellStyle.ForeColor = Color.Black;
            dgvTop5CongViec.DefaultCellStyle.Font = new Font("Arial", 9);

            dgvTop5CongViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động điều chỉnh kích thước cột để lấp đầy DataGridView
            dgvTop5CongViec.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Tự động điều chỉnh kích thước hàng để vừa với nội dung của cell


            // Thêm DataGridView vào panel1
            panel1.Controls.Add(dgvTop5CongViec);
        }


    }
}
