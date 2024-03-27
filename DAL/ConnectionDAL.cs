using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionDAL
    {
        private static string conn = @"Data Source=LAPTOP-DTKDJMOS\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(conn);
        }
    }
}
