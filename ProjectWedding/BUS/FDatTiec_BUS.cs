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
        FDatTiec_DAL datTiecDAL = new FDatTiec_DAL();
        public bool Add(FDatTiec_DTO datTiecDTO)
        {
            string query = String.Empty;
            query += "set dateformat DMY ";
            query += "insert into DATTIEC(NgayDT,Ca,TienDC,SLBan,MaSanh,MaKH) values('"+datTiecDTO.ngayDT+"',";
            query += "'"+datTiecDTO.ca+"','" + datTiecDTO.tienDC + "','" + datTiecDTO.slBan + "',";
            query += "'" + datTiecDTO.loaiSanhFake + "',";
            query += "(select MaKH from KHACHHANG WHERE TenCR='" + datTiecDTO.tenCRFake + "' and TenCD='" + datTiecDTO.tenCDFake + "'))";
            bool kq= xuLy.Command(query);
            return kq;
        }

        public List<FDatTiec_DTO> groupbyThongke()
        {
            return datTiecDAL.groupbyThongke();
        }

        public List<FDatTiec_DTO> SelectTop1()
        {
            return datTiecDAL.SelectTop1();
        }

        public List<FDatTiec_DTO> SelectTraCuu(string name)
        {
            return datTiecDAL.SelectTraCuu(name);
        }
    }
}
