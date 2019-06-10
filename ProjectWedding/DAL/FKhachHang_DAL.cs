using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class FKhachHang_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public List<FKhachHang_DTO> Top1()
        {
            string query = String.Empty;
            query += "select TOP 1 [MaKH] from [KHACHHANG] order by [MAKH] desc";
            List<FKhachHang_DTO> listkh = new List<FKhachHang_DTO>();

            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                FKhachHang_DTO kn = new FKhachHang_DTO();
                                kn.maKH =int.Parse( reader["MaKH"].ToString());
                                listkh.Add(kn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listkh;
        }

        public List<FKhachHang_DTO> ListTop1()
        {
            string query = String.Empty;
            query += "select [MaKH], [TenCR], [TenCD], [SoDienThoai] from [KHACHHANG]";
            query += " where MaKH= (select TOP 1 [MaKH]  from [KHACHHANG] order by [MaKH] desc)";
            List<FKhachHang_DTO> listkh = new List<FKhachHang_DTO>();

            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                FKhachHang_DTO kn = new FKhachHang_DTO();
                                kn.maKH = int.Parse(reader["MaKH"].ToString());
                                kn.tenCR = reader["TenCR"].ToString();
                                kn.tenCD = reader["TenCD"].ToString();
                                kn.soDT = int.Parse(reader["SoDienThoai"].ToString());
                                listkh.Add(kn);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return listkh;
        }
    }
}
