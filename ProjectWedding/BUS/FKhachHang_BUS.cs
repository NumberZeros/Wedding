using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class FKhachHang_BUS
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public bool Add(FKhachHang_DTO khachHangDTO)
        {
            string query = String.Empty;
            query += "insert into KHACHHANG(TenCR,TenCD,SoDienThoai) values('" + khachHangDTO.tenCR + "',";
            query += "'" + khachHangDTO.tenCD + "','" + khachHangDTO.soDT + "')";
            bool kq = xuLy.Command(query);
            return kq;
        }
    }
}
