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
    public class FQuanLyHoaDon_DAL
    {
        FXuLy_DAL XuLy = new FXuLy_DAL();
        public List<FQuanLyHoaDon_DTO> select()
        {
            List<FQuanLyHoaDon_DTO> listQuanLyHoaDon = new List<FQuanLyHoaDon_DTO>();
            string query = string.Empty;
            query += "select [maHD], [ngayThanhToan],[maSanh] from [QUANLYHOADON]";

            using (SqlConnection conn = new SqlConnection(XuLy.ConnectionString))
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
                                FQuanLyHoaDon_DTO db = new FQuanLyHoaDon_DTO();
                                db.maSanh = int.Parse(reader["MaSanh"].ToString());
                                db.maHD = int.Parse(reader["MaHD"].ToString());
                                db.ngayThanhToan = DateTime.Parse(reader["NgayThanhToan"].ToString());
                                listQuanLyHoaDon.Add(db);
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
            return listQuanLyHoaDon;
        }

        // xem giúp tui câu lệnh query chỗ điều kiện where
        // có ham Sua trong day ham Xoa thi tui khong thay
        public bool Sua(FQuanLyHoaDon_DTO quanlyhoadonDTO)
        {
            string query = string.Empty;
            query += "update QUANLYHOADON set [MaSanh]=@maSanh, [MaHD]=@maHD, [NgayThanhToan]=@ngayThanhToan";
            query += "where [MaHoaDon]=@maHoaDon";
            using (SqlConnection con = new SqlConnection(XuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maHD", quanlyhoadonDTO.maHD);
                    cmd.Parameters.AddWithValue("@ngayThanhToan", quanlyhoadonDTO.ngayThanhToan);
                    cmd.Parameters.AddWithValue("@maSanh", quanlyhoadonDTO.maSanh);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
