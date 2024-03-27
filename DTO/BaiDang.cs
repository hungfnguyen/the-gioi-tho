using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaiDang
    {
        // Thuộc tính của bài đăng
        public int IDBaiDang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int SoNamKinhNghiem { get; set; }
        public string MoTa { get; set; }
        public string LinhVuc { get; set; }
        public int ThoiGianThucHien { get; set; }
        public decimal GiaTien { get; set; }

        public int IDTho { get; set; }

        // Constructor mặc định
        public BaiDang()
        {
        }

        // Constructor với tham số
        public BaiDang(int id, string hoTen, string diaChi, string soDienThoai, int soNamKinhNghiem, string moTa, string linhVuc, int thoiGianThucHien, decimal giaTien, int iDTho)
        {
            IDBaiDang = id;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            SoNamKinhNghiem = soNamKinhNghiem;
            MoTa = moTa;
            LinhVuc = linhVuc;
            ThoiGianThucHien = thoiGianThucHien;
            GiaTien = giaTien;
            IDTho = iDTho;
        }

        public class BaiDangRepository
        {
            private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

            public List<BaiDang> LayDanhSachBaiDang()
            {
                List<BaiDang> danhSachBaiDang = new List<BaiDang>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDBaiDang, HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, LinhVuc, ThoiGianThucHien, GiaTien FROM BaiDang";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDang baiDang = new BaiDang();
                        baiDang.IDBaiDang = Convert.ToInt32(reader["IDBaiDang"]);
                        baiDang.HoTen = reader["HoVaTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.LinhVuc = reader["LinhVuc"].ToString();
                        baiDang.ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                        baiDang.GiaTien = Convert.ToDecimal(reader["GiaTien"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }

                return danhSachBaiDang;
            }

            public List<BaiDang> LayBaiDangTheoLinhVuc(string tenLinhVuc)
            {
                List<BaiDang> danhSachBaiDang = new List<BaiDang>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDBaiDang, HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, ThoiGianThucHien, GiaTien FROM BaiDang WHERE LinhVuc = @TenLinhVuc";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenLinhVuc", tenLinhVuc);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDang baiDang = new BaiDang();
                        baiDang.IDBaiDang = Convert.ToInt32(reader["IDBaiDang"]);
                        baiDang.HoTen = reader["HoVaTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.LinhVuc = tenLinhVuc.Trim();
                        baiDang.ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                        baiDang.GiaTien = Convert.ToDecimal(reader["GiaTien"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }

                return danhSachBaiDang;
            }
        }
    }

}
