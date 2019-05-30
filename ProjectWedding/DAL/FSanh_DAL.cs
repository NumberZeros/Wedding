using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public class FSanh_DAL
    {
        FXuLy con = new FXuLy();
        FSanh_DTO sanhDTO = new FSanh_DTO();
        public DataTable LoadSanh()
        {
            return con.Table_Select("select * from SANH");
        }
    }
}
