using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class FKhachHang_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public List<FKhachHang_DTO> select()
        {
            List<FKhachHang_DTO> listKhachHang = new List<FKhachHang_DTO>();
            string query = string.Empty;
            query += "select [MaDT],[NgayDT],[Ca], [TenCD], [TenCR], [SoDienThoai]";
            query += "from [DATTIEC],[KHACHHANG]";
            query += "where [DATTIEC.MaKH] = [KHACHHANG.MaKH]";
            using (SqlConnection conn = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                FKhachHang_DTO db = new FKhachHang_DTO();
                                db.tenCD = reader["tenCD"].ToString();
                                db.tenCR = reader["tenCR"].ToString();
                                db.soDT = int.Parse(reader["soDT"].ToString());
                                listKhachHang.Add(db);
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
            return listKhachHang;
        }
    }
}
