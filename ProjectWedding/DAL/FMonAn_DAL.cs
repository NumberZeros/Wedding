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
    public class FMonAn_DAL
    {
        FXuLy_DAL xuly = new FXuLy_DAL();
        public List<FMonAn_DTO> select()
        {
            List<FMonAn_DTO> listMonAn = new List<FMonAn_DTO>();
            string query = String.Empty;
            query += "select [MaMonAn], [Ten],[DonGia] from [MONAN]";
            using (SqlConnection con = new SqlConnection(xuly.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
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
                                FMonAn_DTO db = new FMonAn_DTO();
                                db.maMonAn = int.Parse(reader["MaMonAn"].ToString());
                                db.ten = reader["Ten"].ToString();
                                db.donGia = int.Parse(reader["DonGia"].ToString());
                                listMonAn.Add(db);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                return listMonAn;
            }
        }

        public List<FMonAn_DTO> selectTimKiem(string sKeyword)
        {
            List<FMonAn_DTO> listMonAn = new List<FMonAn_DTO>();
            string query = String.Empty;
            query += "select [MaMonAn], [Ten],[DonGia] from [MONAN]";
            query += " where ([MaMonAn] LIKE CONCAT('%',@sKeyword,'%')) or ([Ten] LIKE CONCAT ('%',@sKeyword,'%'))";
            using (SqlConnection con = new SqlConnection(xuly.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                FMonAn_DTO db = new FMonAn_DTO();
                                db.maMonAn = int.Parse(reader["MaMonAn"].ToString());
                                db.ten = reader["Ten"].ToString();
                                db.donGia = int.Parse(reader["DonGia"].ToString());
                                listMonAn.Add(db);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
                return listMonAn;
            }
        }
    }
}
