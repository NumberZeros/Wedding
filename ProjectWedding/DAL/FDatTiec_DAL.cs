using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FDatTiec_DAL
    {
        FXuLy_DAL xuly = new FXuLy_DAL();
        public List<FDatTiec_DTO> SelectTop1()
        {
            string query = String.Empty;
            query += "select [MaSanh], [Ca], [SLBan],[TienDC],[NgayDT] from [DATTIEC] ";
            query += "where [MaDT]=(select top 1 [MaDT] from [DATTIEC] order by [MADT] desc)";
            List<FDatTiec_DTO> list = new List<FDatTiec_DTO>();
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
                                FDatTiec_DTO db = new FDatTiec_DTO();
                                db.maSanh = int.Parse(reader["MaSanh"].ToString());
                                db.ca = int.Parse( reader["Ca"].ToString());
                                db.tienDC = int.Parse(reader["TienDC"].ToString());
                                db.slBan = int.Parse(reader["SLBan"].ToString());
                                db.ngayDT = DateTime.Parse(reader["NgayDT"].ToString());
                                list.Add(db);
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
                return list;
            }
        }
    }
}
