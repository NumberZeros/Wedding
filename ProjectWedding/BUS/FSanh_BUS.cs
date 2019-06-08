using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class FSanh_BUS
    {
        FSanh_DAL sanhDAL = new FSanh_DAL();
        FXuLy_DAL xl = new FXuLy_DAL();
        public List<FSanh_DTO> select()
        {
            return sanhDAL.select();
        }

        public bool ADD(FSanh_DTO sanhDTO)
        {
            String query = String.Empty;
            query += "insert into SANH(TenSanh, LoaiSanh, SoLuongMax,DonGiaMin,GhiChu)";
            query += "values('" + sanhDTO.tenSanh + "','" + sanhDTO.loaiSanh + "','" + sanhDTO.soluongMax + "','" + sanhDTO.donGiaMin + "','" + sanhDTO.ghiChu + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool delete(FSanh_DTO sanhDTO)
        {
            string query = "delete from Sanh where MaSanh='" + sanhDTO.maSanh + "'";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Update(FSanh_DTO sanhDTO)
        {
            bool kq = sanhDAL.sua(sanhDTO);
            return kq;
        }
    }
}
