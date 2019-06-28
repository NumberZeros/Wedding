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
    public class FThongKe_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public List<FThongKe_DTO> select()
        {
            List<FThongKe_DTO> listThongKe = new List<FThongKe_DTO>();
            string query = string.Empty;
            query += "select [NgayThanhToan],[TenSanh], [SoLuongMax]";
            query += " from [HOADON],[SANH]";
            query += " where [HOADON.MaSanh]=[SANH.MaSanh]";

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
                                FThongKe_DTO db = new FThongKe_DTO();
                                db.ngayTTC = DateTime.Parse(reader["NgayThanhToan"].ToString());
                                db.tenSanhC = reader["TenSanh"].ToString();
                                db.slBanC = int.Parse(reader["SoLuongMax"].ToString());
                                listThongKe.Add(db);
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }

            return listThongKe;
        }
    }
}
