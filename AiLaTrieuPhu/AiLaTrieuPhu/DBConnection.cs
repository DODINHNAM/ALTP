using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AiLaTrieuPhu
{
    class DBConnection
    {
        public SqlConnection GetConnection()
        {
            String connString = @"Data Source=DESKTOP-HRM91B1\SQLEXPRESS;Initial Catalog=ALTP;Integrated Security=True";
            return new SqlConnection(connString);
        }
        public DataTable GetDataTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
