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
        
        public List<FSanh_DTO> select()
        {
            return sanhDAL.select();
        }

    }
}
