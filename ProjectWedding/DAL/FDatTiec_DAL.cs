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

  

        public List<FDatTiec_DTO> SelectTraCuu(string name)
        {
            List<FDatTiec_DTO> list = new List<FDatTiec_DTO>();
            string query = String.Empty;
            query += "select DATTIEC.[MaKH], [TenCD], [TenCR],[MaSanh], [NgayDT], [Ca],[SLBan] from [DATTIEC], [KHACHHANG] ";
            query += " where (DATTIEC.[MaKH]=KHACHHANG.[MaKH]) AND";
            query+=" (( [TenCD] LIKE CONCAT ('%',@name,'%')) OR ([TenCR] LIKE CONCAT ('%',@name,'%'))) ";
            using (SqlConnection con = new SqlConnection(xuly.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@name", name);
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
                                db.maKH = int.Parse(reader["MaKH"].ToString());
                                db.tenCRFake = reader["TenCR"].ToString();
                                db.tenCDFake = reader["TenCD"].ToString();
                                db.maSanh = int.Parse(reader["MaSanh"].ToString());
                                db.ngayDT =DateTime.Parse( reader["NgayDT"].ToString());
                                db.ca = int.Parse(reader["Ca"].ToString());
                                db.slBan = int.Parse(reader["SLBan"].ToString());
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

        public List<FDatTiec_DTO> groupbyThongke()
        {
            List<FDatTiec_DTO> listDatTiec = new List<FDatTiec_DTO>();
            string query = string.Empty;
            query += "select [TenSanh],[NgayThanhToan],count([MaHD]) as [TongHD], sum([TongTien]) as [TongTien]";
            query += " from [DATTIEC],[SANH],[HOADON]";
            query += " where ([DATTIEC.MaSanh] = [SANH.MaSanh]) AND ([SANH.MaSanh]=[HOADON.MaSanh])";

            using (SqlConnection conn = new SqlConnection(xuly.ConnectionString))
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
                                db.tenSanhFake= reader["TenSanh"].ToString();  // db.maDT la ten bien DTO con ["MaDT"] la cai minh goi tren query
                                db.ngayDT = DateTime.Parse(reader["NgayThanhToan"].ToString());
                                db.tongHD = int.Parse(reader["TongHD"].ToString());
                                db.tongTien = int.Parse(reader["TongTien"].ToString());
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
