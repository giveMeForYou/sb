using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace 学生考勤管理系统
{
    class help
    {
        public static SqlConnection conn;
        public static string Lession = ConfigurationManager.ConnectionStrings["coursetable"].ConnectionString;
        public static void OpenConn() {
            conn = new SqlConnection(Lession);
            if (conn.State == System.Data.ConnectionState.Closed) {
                conn.Open();
            }

        }
    }
}
