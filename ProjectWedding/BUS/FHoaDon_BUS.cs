using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class FHoaDon_BUS
    {
        FHoaDon_DTO hoadonDTO = new FHoaDon_DTO();
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public void Add(FHoaDon_DTO hoadonDTO)
        {
            string query = String.Empty;
            query += "set dateformat DMY ";
            query += "insert into HOADON(NgayThanhToan,MaSanh,maKH) values('" + hoadonDTO.ngayThanhToan + "',";
            query += "'" + hoadonDTO.loaiSanhFake + "',";
            query += "(select MaKH from KHACHHANG WHERE TenCR='" + hoadonDTO.tenCRFake + "' and TenCD='" + hoadonDTO.tenCDFake + "'))";
             xuLy.Command(query);
        }

        public void AddTongTien(FHoaDon_DTO hoadonDTO)
        {
            string query = String.Empty;
            query += "update HOADON set TongTien='"+hoadonDTO.tongTien+"' where maKH='"+hoadonDTO.maKH+"'";
            xuLy.Command(query);
        }

        public DataTable GroupHoaDon()
        {

            string query = String.Empty;
            query += "select month(ngaythanhtoan) as Thang, COUNT(MaHD) as SoHD from HOADON";
            query += " where YEAR(ngaythanhtoan) = '2019' group by MONTH(ngaythanhtoan)";
            return xuLy.select(query);
        }
    }
}
