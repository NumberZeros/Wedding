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
        private FSanh_DTO db=new FSanh_DTO();
        private FSanh_DAL sanhDAL=new FSanh_DAL();
        public DataTable LoadData()
        {
            DataTable kq = sanhDAL.LoadSanh();
            return kq;
        }

    }
}
