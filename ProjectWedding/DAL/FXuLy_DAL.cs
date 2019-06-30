using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Hàm này có chức năng thực hiện các thao tác thêm xóa sửa được truyền vào bằng câu lệnh query
/// </summary>

namespace DAL
{
    public class FXuLy_DAL
    {
        public string ConnectionString = "Data Source=DESKTOP-2E24HCM;Initial Catalog=QuanLyTiecCuoi;Integrated Security=True";

        public bool Command(String sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    con.Close();
                    return false;
                }
                return true;
            }
        }

        public DataTable select(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                return dt;
            }
        }
    }
}
