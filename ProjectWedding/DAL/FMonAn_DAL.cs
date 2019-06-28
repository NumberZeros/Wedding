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
    public class FMonAn_DAL
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public List<FMonAn_DTO> select()
        {
            List<FMonAn_DTO> listMonAn = new List<FMonAn_DTO>();
            string query = string.Empty;
            query += "select [MaMonAn],[Ten],[DonGia]";
            query += " from [MONAN]";
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
                                FMonAn_DTO db = new FMonAn_DTO();
                                db.maMonAn = int.Parse(reader["MaMonAn"].ToString());
                                db.tenMonAn = reader["Ten"].ToString();
                                db.donGia = int.Parse(reader["DonGia"].ToString());
                                listMonAn.Add(db);
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

            return listMonAn;
        }

        public bool Chinhsua(FMonAn_DTO monanDTO)
        {
            string query = String.Empty;
            query += "update MONAN set [Ten]=@tenMonAn, [DonGia]=@donGia";
            query += "where [MaMonAn]=@maMonAn";
            using (SqlConnection con = new SqlConnection(xuLy.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maMonAn", monanDTO.tenMonAn);
                    cmd.Parameters.AddWithValue("@donGia", monanDTO.donGia);

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


