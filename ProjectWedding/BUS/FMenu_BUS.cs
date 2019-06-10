using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class FMenu_BUS
    {
        FMenu_DAL menuDAL = new FMenu_DAL();
        FXuLy_DAL xuly = new FXuLy_DAL();

        public void Add(FMenu_DTO menuDTO)
        {
            string query = String.Empty;
            query += "insert into Menu(MaHD,MaMonAn) values((select MaHD from HOADON where maKH='"+menuDTO.maKHFake+"'),";
            query += "(select MaMonAn from MONAN where Ten='" + menuDTO.tenMonAn + "'))";
            xuly.Command(query);
        }

        public DataTable LoadMenu()
        {
            string query = String.Empty;
            query += "select ten,DonGia from MONAN, Menu where(MaHD = (select top 1 MaHD from Menu order by MaHD desc)";
            query += "and Menu.MaMonAn = MONAN.MaMonAn)";
            return xuly.select(query);
        }

        public void delete()
        {
            string query = String.Empty;
            query += "delete from Menu where MaMenu=(select top 1 MaMenu from Menu order by MaMenu desc)";
            xuly.Command(query);
        }

        public List<FMenu_DTO> selectTop1()
        {
           return menuDAL.selectTop1();
        }
    }
}
