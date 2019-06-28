 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FDatTiec_DTO
    {

        // Thay doi
        public int maDT { get; set; }
        public DateTime ngayDT { get; set; }
        public int ca { get; set; }
        public int tienDC { get; set; }
        public int slBan { get; set; }
        public int soBanDuTru { get; set; }
        public int maSanh { get; set; }
        public int maKH { get; set; }
        // thêm biến tạm để truyền tên khach hàng và mã sảnh
        public string tenCRFake { get; set; }
        public string tenCDFake { get; set; }
        public string loaiSanhFake { get; set; }
    }
}
