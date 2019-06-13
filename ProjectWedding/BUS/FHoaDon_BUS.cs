using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

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
    }
}
