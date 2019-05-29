using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

/// <summary>
/// lớp này dùng để kết nối với SQL và thực hiện 1 số chức năng thay đổi database
/// </summary>
namespace DAL
{
    public class KetNoi_DAL
    {

        /// <summary>
        /// table_Select dùng để đổ dữ liệu vào database 
        /// </summary>
        public DataTable Table_Select(String sql)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2E24HCM;Initial Catalog=QuanLyTiecCuoi;Integrated Security=True"))
            {
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                return dt;
            }
        }

        /// <summary>
        /// table_command dùng để thêm dữ liệu vào database
        /// </summary>
        public void Table_Command(String sql)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2E24HCM;Initial Catalog=QuanLyTiecCuoi;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
