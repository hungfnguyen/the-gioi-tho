using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanThoDAL
    {
        private readonly string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

        public void Insert(string tenTK, string matKhau, string email, string hoTen, string gioiTinh, string soDT, int soNamKN, string diaChi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoanTho (TenTaiKhoan, MatKhau, Email, HoTen, GioiTinh, SoDienThoai, SoNamKinhNghiem, DiaChi) " +
                               "VALUES (@TenTaiKhoan, @MatKhau, @Email, @HoTen, @GioiTinh, @SoDienThoai, @SoNamKinhNghiem, @DiaChi)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTK);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@SoDienThoai", soDT);
                    command.Parameters.AddWithValue("@SoNamKinhNghiem", soNamKN);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public string GetByEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Email FROM TaiKhoanTho WHERE Email = @Email";
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
                string query = "SELECT TenTaiKhoan FROM TaiKhoanTho WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public int GetByIDTho(string tenTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IDTho FROM TaiKhoanTho WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Trả về -1 nếu không tìm thấy IDTho
                }
            }
        }
    }
}

