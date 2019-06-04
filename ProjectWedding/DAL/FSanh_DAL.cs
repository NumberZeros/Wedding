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
    public class FSanh_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        //tạo danh sách và đưa dữ liệu vào danh sách

        public List<FSanh_DTO> select()
        {
            List<FSanh_DTO> listSanh = new List<FSanh_DTO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [MaSanh],[TenSanh],[LoaiSanh],[SoLuongMax],[DonGiaMin],[GhiChu]";
            query +=" from [SANH]";
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
                        SqlDataReader reader=null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                FSanh_DTO db = new FSanh_DTO();
                                db.maSanh = int.Parse(reader["MaSanh"].ToString());
                                db.tenSanh = reader["TenSanh"].ToString();
                                db.loaiSanh = reader["LoaiSanh"].ToString();
                                db.soluongMax = int.Parse(reader["SoLuongMax"].ToString());
                                db.donGiaMin = int.Parse(reader["DonGiaMin"].ToString());
                                db.ghiChu = reader["GhiChu"].ToString();
                                listSanh.Add(db);
                            }
                        }
                        conn.Close();
                        conn.Dispose(); // tra lai tat ca tai nguyen da su dung de giai phong bo nho
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
            return listSanh;
        }

        public bool sua(FSanh_DTO sanhDTO)
        {
            string query = String.Empty;
            query += "update sanh set [TenSanh]=@tenSanh, [LoaiSanh]=@loaiSanh, [SoLuongMax]=@soLuongMax, [DonGiaMin]=@donGiaMin,";
            query += "[GhiChu]=@ghiChu where [MaSanh]=@maSanh";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maSanh", sanhDTO.maSanh);
                    cmd.Parameters.AddWithValue("@tenSanh", sanhDTO.tenSanh);
                    cmd.Parameters.AddWithValue("@loaiSanh", sanhDTO.loaiSanh);
                    cmd.Parameters.AddWithValue("@soLuongMax", sanhDTO.soluongMax);
                    cmd.Parameters.AddWithValue("@donGiaMin", sanhDTO.donGiaMin);
                    cmd.Parameters.AddWithValue("@ghiChu", sanhDTO.ghiChu);
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
