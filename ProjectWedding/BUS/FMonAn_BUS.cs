using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class FMonAn_BUS
    {
        FMonAn_DAL monanDAL = new FMonAn_DAL();
        private FXuLy_DAL xl = new FXuLy_DAL();
        public List<FMonAn_DTO> select()
        {
            return monanDAL.select();
        }

        public bool Them(FMonAn_DTO monanDTO)
        {
            String query = String.Empty;
            query += "insert into MONAN(MaMonAn,Ten, DonGia)";
            query += "values('"+ monanDTO.maMonAn +"', '" + monanDTO.tenMonAn + "','" + monanDTO.donGia + "')";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Xoa(FMonAn_DTO monanDTO)
        {
            string query = "delete from MONAN where MaMonAn='" + monanDTO.maMonAn + "'";
            bool kq = xl.Command(query);
            return kq;
        }

        public bool Thaydoi(FMonAn_DTO monanDTO)
        {
            bool kq = monanDAL.Chinhsua(monanDTO);
            return kq;
        }
    }
}
