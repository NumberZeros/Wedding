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
        private string ConnectionString = @"Data Source=DESKTOP-FBKFN4T\SQLEXPRESS;Initial Catalog=NEW;Integrated Security=True";
        //tạo danh sách và đưa dữ liệu vào danh sách

        public List<FSanh_DTO> select()
        {
            List<FSanh_DTO> listSanh = new List<FSanh_DTO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [MaSanh],[TenSanh],[LoaiSanh],[SoLuongMax],[DonGiaMin],[GhiChu]";
            query +=" from [SANH]";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
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
    }
}
