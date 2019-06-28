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
    public class FThongke_BUS
    {
        FThongKe_DAL thongkeDAL = new FThongKe_DAL();
        private FXuLy_DAL xuly = new FXuLy_DAL();

        public List<FThongKe_DTO> select()
        {
            return thongkeDAL.select();
        }

    }
}
