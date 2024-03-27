using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private readonly string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";
        public string LayMatKhauBangEmail(string email)
        {
            ModifyDAL modify = new ModifyDAL();
            string query = "SELECT * FROM TaiKhoan WHERE Email = '" + email + "'";
            // Sử dụng thể hiện của lớp Modify để gọi phương thức TaiKhoans
            List<TaiKhoan> taiKhoans = modify.TaiKhoans(query);
            if (taiKhoans.Count > 0)
            {
                return taiKhoans[0].MatKhau;
            }
            else
            {
                return null;
            }
        }

        public void Insert(string tenTK, string matKhau, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email) VALUES (@TenTaiKhoan, @MatKhau, @Email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTK);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Email FROM TaiKhoan WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public string GetByTenTaiKhoan(string tenTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public int GetByIDTaiKhoan(string tenTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Trả về -1 nếu không tìm thấy IDTaiKhoan
                }
            }
        }
    }
}
