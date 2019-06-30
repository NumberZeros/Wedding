using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class FMonAn_BUS
    {
        FMonAn_DAL monAnDAL = new FMonAn_DAL();
        public List<FMonAn_DTO> select()
        {
            return monAnDAL.select();
        }

        public List<FMonAn_DTO> selectTimkiem(string sKeyword)
        {
            return monAnDAL.selectTimKiem(sKeyword);
        }
    }
}
