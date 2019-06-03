using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class FDatTiec_BUS
    {
        FXuLy_DAL xuLy = new FXuLy_DAL();
        public bool Add(FDatTiec_DTO datTiecDTO)
        {
            string query = String.Empty;
            query += "insert into DATTIEC(NgayDT,Ca,TienDC,SLBan,MaSanh,MaKH) values('"+datTiecDTO.ngayDT+"',";
            query += "'"+datTiecDTO.ca+"','" + datTiecDTO.tienDC + "','" + datTiecDTO.slBan + "',";
            query += "(select MaSanh from SANH Where LoaiSanh='" + datTiecDTO.loaiSanhFake + "'),";
            query += "(select MaKH from KHACHHANG WHERE TenCR='" + datTiecDTO.tenCRFake + "' and TenCD='" + datTiecDTO.tenCDFake + "'))";
            bool kq= xuLy.Command(query);
            return kq;
        }
    }
}
