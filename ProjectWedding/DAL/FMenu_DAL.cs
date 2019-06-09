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
        //FXuLy_DAL xuly = new FXuLy_DAL();

        //public List<FMenu_DTO> select()
        //{
        //    List<FMenu_DTO> listMenu = new List<FMenu_DTO>();
        //    string query = String.Empty;
        //    query += "select [MaMenu],[MaHD],[MaMonAn] from [Menu]";
        //    using (SqlConnection con = new SqlConnection(xuly.ConnectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = query;
        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        FMenu_DTO db = new FMenu_DTO();
        //                        db.maMenu = int.Parse(reader["MaMenu"].ToString());
        //                        db.maHD = int.Parse(reader["MaHD"].ToString());
        //                        db.tenMonAn = int.Parse(reader["MaMonAn"].ToString());
        //                        listMenu.Add(db);
        //                    }
        //                }
        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                con.Dispose();
        //            }
        //        }
        //        return listMenu;
        //    }
        //}
    }
}
