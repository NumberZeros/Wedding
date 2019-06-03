using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ProjectWedding
{
    public partial class FDatTiec : Form
    {
        public FDatTiec()
        {
            InitializeComponent();
        }

        FDatTiec_DTO datTiecDTO = new FDatTiec_DTO();
        FKhachHang_DTO khachHangDTO = new FKhachHang_DTO();
        FHoaDon_DTO hoaDonDTO = new FHoaDon_DTO();
        FSanh_DTO sanhDTO = new FSanh_DTO();
        FSanh_BUS sanhBUS = new FSanh_BUS();
        FKhachHang_BUS khachHangBUS = new FKhachHang_BUS();
        FDatTiec_BUS datTiecBUS = new FDatTiec_BUS();


        private void btdtReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        //button chọn Menu trong menu se có món ăn và dịch vụ 
        private void button3_Click(object sender, EventArgs e)
        {
            FMenu menu = new FMenu();
            this.Hide();
            this.Close();
            menu.Show();
        }

        //xem lại những yêu cầu cụ thể của khách hàng và số tiền tổng thể mà khách hàng phải trả cho bữa tiệc
        private void button1_Click(object sender, EventArgs e)
        {
            FHoaDon hoaDon = new FHoaDon();
            this.Hide();
            this.Close();
            hoaDon.Show();
        }

        // kiểm tra lại những thông tin của khách hàng có hợp lệ hay không 
        // khi thông tin đã hoàn toàn hợp lệ sẽ chuyển sang bước chọn menu

        private void btDatTiec_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            MessageBox.Show("Dat tiec thanh cong");
            this.Hide();
            this.Close();
            main.Show();
        }

        // load loại sảnh lên bảng đặt tiệc sau đó trả về mã sảnh
        private int LoadLoaiSanh()
        {
            List<FSanh_DTO> listLoadSanh = sanhBUS.select();
            if(listLoadSanh==null)
            {
                MessageBox.Show("Loi", "Co loi xay ra trong qua trinh load sanh");
            }
            cbSanh.DataSource= new BindingSource(listLoadSanh, String.Empty);
            cbSanh.DisplayMember = "loaiSanh";
            cbSanh.ValueMember = "maSanh";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbSanh.DataSource];
            myCurrencyManager.Refresh();
            return sanhDTO.maSanh;
        }

        //kiem tra co load duoc sanh hay khong
        private bool CheckMaSanh()
        {
            bool kq = false;
            if(LoadLoaiSanh() != null)
            {
                kq = true;
            }
            return kq;
        }

        // them khach hang vao truoc khi an nut Kiem tra
        private bool InsertKhacHang()
        {

            khachHangDTO.tenCR = tbTenCR.Text;
            khachHangDTO.tenCD = tbTenCD.Text;
            khachHangDTO.soDT = int.Parse(tbDT.Text);
            bool kq = khachHangBUS.Add(khachHangDTO);
            return kq;
        }

        // thêm dữ liệu vào bảng đặt tiệc
        private void InsertDatTiec()
        {
            datTiecDTO.ngayDT = DateTime.Parse(NgayDT.Value.ToString());
            datTiecDTO.ca = int.Parse(cbCa.Text);
            datTiecDTO.tienDC = int.Parse(tbTienCoc.Text);
            datTiecDTO.slBan = int.Parse(tbSlBan.Text);
            datTiecDTO.tenCRFake = tbTenCR.Text;
            datTiecDTO.tenCDFake = tbTenCD.Text;
            datTiecDTO.loaiSanhFake = cbSanh.Text;
            bool kq=datTiecBUS.Add(datTiecDTO);
            if(kq==true)
            {
                MessageBox.Show("Kiem Tra thanh Cong. Moi ban chon Menu", "Thong Bao",  MessageBoxButtons.OK);
            }
        }

        // insert dữ liệu vào các bảng
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if(InsertKhacHang()==true)
                {
                    if(CheckMaSanh()==true)
                    {
                        InsertDatTiec();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi", "Co viec gi do sai sai ");
            }

        }

        private void FDatTiec_Load(object sender, EventArgs e)
        {
            LoadLoaiSanh();
        }

    }
}
