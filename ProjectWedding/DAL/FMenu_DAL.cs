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
    public class FMenu_DAL
    {
        FXuLy_DAL xuly = new FXuLy_DAL();


        public List<FMenu_DTO> selectTop1()
        {
            List<FMenu_DTO> listMenu = new List<FMenu_DTO>();
            string query = String.Empty;
            query += "select [Ten] ,[DonGia] ,[MaHD] from [Menu], [MONAN] where [MaMenu]= (select top 1 [MaMenu] from [Menu] ";
            query += " order by [MaMenu] desc)";
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
                                FMenu_DTO db = new FMenu_DTO();
                                db.maHD = int.Parse(reader["MaHD"].ToString());
                                db.tenFake = reader["Ten"].ToString();
                                db.donGiaFake = int.Parse(reader["DonGia"].ToString());
                                listMenu.Add(db);
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
                return listMenu;
            }
        }
    }
}
