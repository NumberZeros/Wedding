﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FHoaDon_DTO
    {
        public DateTime ngayDTFacke;

        public int maHD { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public int maSanh { get; set; }
        //Them thuoc tinh tong tien
        public int tongTien { get; set; }
        public int maKH { get; set; }
        public string tenCRFake { get; set; }
        public string tenCDFake { get; set; }
        public int loaiSanhFake { get; set; }
    }
}
