﻿using System;
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
        FHoaDon_BUS hoaDonBUS = new FHoaDon_BUS();

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

        // load loại sảnh lên bảng đặt tiệc sau đó trả về mã sảnh
        private void LoadLoaiSanh()
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
            

            if (cbSanh.Items.Count > 0)
            {
                cbSanh.SelectedIndex = 0;
            }
        }

        //kiem tra co load duoc sanh hay khong

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
            datTiecDTO.loaiSanhFake = int.Parse(cbSanh.SelectedValue.ToString());
            bool kq=datTiecBUS.Add(datTiecDTO);
            if(kq==true)
            {
                MessageBox.Show("Kiem Tra thanh Cong. Moi ban chon Menu", "Thong Bao",  MessageBoxButtons.OK);
            }
        }

        private void InsertHoadDon()
        {
            hoaDonDTO.ngayThanhToan = DateTime.Parse(ngayTT.Value.ToString());
            hoaDonDTO.tenCRFake = tbTenCR.Text;
            hoaDonDTO.tenCDFake = tbTenCD.Text;
            hoaDonDTO.loaiSanhFake = int.Parse(cbSanh.SelectedValue.ToString());
            hoaDonBUS.Add(hoaDonDTO);
        }

        // insert dữ liệu vào các bảng
        //disable textboxes sau khi kiem tra thanh cong
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if(InsertKhacHang()==true)
                {

                    InsertHoadDon();
                    InsertDatTiec();

                    tbTenCR.Enabled = false;
                    tbTenCD.Enabled = false;
                    tbSlBan.Enabled = false;
                    tbDT.Enabled = false;
                    tbTienCoc.Enabled = false;
                    NgayDT.Enabled = false;
                    cbCa.Enabled = false;
                    cbSanh.Enabled = false;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi", "Co viec gi do sai sai ");
            }

        }

        private void CheckSLMAX()
        {
            try
            {
                if (int.Parse(tbSlBan.Text) < int.Parse(tbMax.Text))
                    MessageBox.Show("Moi ban nhap tiep");
            }
            catch(Exception ex)
            {
                DialogResult re = new DialogResult();
                re=MessageBox.Show("So luong ban phai nho hon so luong ban toi da", tbMax.Text, MessageBoxButtons.OK);
                if(re==DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void BindingSLMax()
        {
            List<FSanh_DTO> list= sanhBUS.selectSLMax(sanhDTO);
            Binding max = new Binding("Text", list, "soluongMax");
            tbMax.DataBindings.Add(max);
        }

        private void FDatTiec_Load(object sender, EventArgs e)
        {
            BindingSLMax();
            LoadLoaiSanh();
        }

        private void btCheckMax_Click(object sender, EventArgs e)
        {
            
            CheckSLMAX();
        }

    }
}
