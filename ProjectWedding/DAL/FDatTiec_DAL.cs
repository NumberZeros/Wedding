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
    public class FDatTiec_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public List<FDatTiec_DTO> select()
        {
            List<FDatTiec_DTO> listDatTiec = new List<FDatTiec_DTO>();
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
                                FDatTiec_DTO db = new FDatTiec_DTO();
                                db.maDT = int.Parse(reader["maDT"].ToString());
                                db.ngayDT = DateTime.Parse(reader["ngayDT"].ToString());
                                db.ca = int.Parse(reader["ca"].ToString());
                                listDatTiec.Add(db);
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
            return listDatTiec;
        }
    }
}
