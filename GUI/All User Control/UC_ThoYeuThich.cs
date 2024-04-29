using DAL;
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
using static DAL.ThongTinTho;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI.All_User_Control
{
    public partial class UC_ThoYeuThich : UserControl
    {
        public bool ShowDoanhThu
        {
            get { return txtDoanhThu.Visible; }
            set { txtDoanhThu.Visible = value; }
        }

        private bool isTopDanhGia;

        public bool IsTopDanhGia
        {
            get { return isTopDanhGia; }
            set
            {
                isTopDanhGia = value;
                UpdateSoSao(); // Gọi phương thức cập nhật số sao khi chế độ thay đổi
            }
        }



        public int IDTho; // Chuyển IDTho thành biến instance để sử dụng trong phương thức btnHuyYeuThich_Click
        public event EventHandler<int> XemBaiDangClicked;
        public UC_ThoYeuThich(ThongTinTho tho)
        {
            InitializeComponent();
            txtHoVaTen.Text = tho.HoTen;
            txtSoDienThoai.Text = tho.SoDienThoai;
            txtDiaChi.Text = tho.DiaChi;
            txtSoNamKinhNghiem.Text = tho.SoNamKinhNghiem.ToString();
            IDTho = tho.IDTho;
            if(tho.GioiTinh == "Nữ")
            {
                ptbNu.Visible = true;
            }
            lblIDTho.Text = IDTho.ToString();

            UpdateDoanhThu();
            UpdateSoSao();
        }

        // Phương thức để cập nhật doanh thu
        /* private void UpdateDoanhThu()
         {
             // Thực hiện truy vấn SQL để lấy tổng doanh thu của thợ
             string query = @"SELECT SUM(bd.GiaTien) AS TongDoanhThu
                              FROM BaiDang bd
                              INNER JOIN
                              CongViec cv ON bd.IDTho = cv.IDTho
                              WHERE bd.IDTho = @IDTho AND cv.TrangThaiCongViecTho = @TrangThai";

             // Thực hiện truy vấn và lấy kết quả
             decimal tongDoanhThu = 0;
             using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
             {
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@IDTho", IDTho);
                     command.Parameters.AddWithValue("@TrangThai", "Đã hoàn thành");
                     connection.Open();
                     object result = command.ExecuteScalar();
                     if (result != DBNull.Value)
                     {
                         tongDoanhThu = Convert.ToDecimal(result);
                     }
                 }
             }

             // Hiển thị tổng doanh thu lên txtDoanhThu
             txtDoanhThu.Text = tongDoanhThu.ToString("C0");
         }*/

        private void UpdateDoanhThu()
        {
            // Thực hiện truy vấn SQL để lấy tổng doanh thu của thợ từ bảng CongViec
            string query = @"SELECT SUM(cv.GiaTien) AS TongDoanhThu
                     FROM CongViec cv
                     WHERE cv.IDTho = @IDTho AND cv.TrangThaiCongViecTho = @TrangThai";

            // Thực hiện truy vấn và lấy kết quả
            decimal tongDoanhThu = 0;
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDTho", IDTho);
                    command.Parameters.AddWithValue("@TrangThai", "Đã hoàn thành");
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        tongDoanhThu = Convert.ToDecimal(result);
                    }
                }
            }

            // Hiển thị tổng doanh thu lên txtDoanhThu
            txtDoanhThu.Text = tongDoanhThu.ToString("C0");
        }


        public Guna2Button GetBtnHuyYeuThich()
        {
            return btnHuyYeuThich;
        }
        private void btnXemBaiDang_Click(object sender, EventArgs e)
        {
            // Khi người dùng nhấn nút XemBaiDang, gửi sự kiện với IDTho tới form cha
            XemBaiDangClicked?.Invoke(this, IDTho);
        }
       
        private void btnHuyYeuThich_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy yêu thích thợ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ThoYeuThichRepository repository = new ThoYeuThichRepository();
                    repository.XoaThoYeuThich(BLL.LoginBLL.IDNguoiDung, IDTho); // Sử dụng IDTho từ biến instance
                    MessageBox.Show("Đã xóa thông tin thợ yêu thích thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thông tin thợ yêu thích: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_ThoYeuThich_Load(object sender, EventArgs e)
        {

        }

        private void ptbNu_Click(object sender, EventArgs e)
        {

        }

        private void txtDoanhThu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoSao_TextChanged(object sender, EventArgs e)
        {

        }

        // Phương thức để cập nhật số sao đánh giá
        private void UpdateSoSao()
        {
            if (!isTopDanhGia) // Kiểm tra xem UC có ở chế độ Top đánh giá hay không
            {
                txtSoSao.Visible = false; // Ẩn control txtSoSao nếu không ở chế độ Top đánh giá
                return;
            }

            // Thực hiện truy vấn SQL để lấy số sao đánh giá của thợ
            string query = @"SELECT AVG(SoSao) AS DiemTrungBinh
                     FROM DanhGia
                     WHERE IDCongViec IN (SELECT IDCongViec FROM CongViec WHERE IDTho = @IDTho)";

            // Thực hiện truy vấn và lấy kết quả
            double diemTrungBinh = 0;
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDTho", IDTho);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        diemTrungBinh = Convert.ToDouble(result);
                    }
                }
            }

            // Hiển thị số sao đánh giá lên txtSoSao
            txtSoSao.Text = diemTrungBinh.ToString("0.0");
            txtSoSao.Visible = true; // Hiển thị control txtSoSao khi ở chế độ Top đánh giá
        }
    }
}
