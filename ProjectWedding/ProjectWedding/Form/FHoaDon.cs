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
    public partial class FHoaDon : Form
    {
        public FHoaDon()
        {
            InitializeComponent();
        }

        FKhachHang_BUS khachHangBUS = new FKhachHang_BUS();
        FDatTiec_BUS datTiecBUS = new FDatTiec_BUS();
        FHoaDon_BUS hoaDonBUS = new FHoaDon_BUS();
        FMenu_BUS menuBUS = new FMenu_BUS();

        FKhachHang_DTO khacHangDTO = new FKhachHang_DTO();

        private void bthdReturn_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            this.Close();
            datTiec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            DialogResult mb;
            mb = MessageBox.Show("Bạn đã kiểm tra lại thông tin và thanh toán ", "Thông Báo", MessageBoxButtons.YesNo);
            if(mb== DialogResult.Yes)
            {
                this.Hide();
                this.Close();
                main.Show();
            }            
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            LoadKhachHang();// load thong tin khach hang len bang phu 
            BindingThongTinKhachHang(); // thuc hien binding du lieu tu bang phu len bt va lb
            loadDatTiec(); // load thong tin dat tiec len bang phu
            BindingThongTinDatTiec();// thuc hien binding du lieu tu bang phu len bt va lb
            loadMonAn(); // load thong tin mon an da duoc chon len bang phu 
            loadMenu(); // hiển thị tên lên layoutTen
            BindingTien(); // Tính tổng số tiền của menu và số tiền mà khách hàng phải trả

        }

        private void BindingTien()
        {
            int total = 0;//biến tổng tiền của tất cả món ăn
            for (int i = 0; i < gridAnMonAn.RowCount; i++)
            {
                int gia = int.Parse(gridAnMonAn.Rows[i].Cells["DonGiaFake"].Value.ToString());
                if(gia<1000)
                {
                    int sl = int.Parse(lbSLBan.Text);
                    gia = gia * sl;
                }
                total = total + gia;
            }
            lbTongTien.Text = Convert.ToString(total);// Tổng số tiền khách hàng phải trả 
            lbSoTienConLai.Text = Convert.ToString(total - int.Parse(lbTienDatCoc.Text)); // tổng số tiền còn lại khách hàng phải trả
        }

        private void BindingThongTinKhachHang()
        {
            btMaKhachHang.Text = Convert.ToString(gridAnThongTin.Rows[0].Cells["Ma"].Value);
            lbTenCR.Text= Convert.ToString(gridAnThongTin.Rows[0].Cells["CR"].Value);
            lbTenCD.Text = Convert.ToString(gridAnThongTin.Rows[0].Cells["CD"].Value);
        }

        private void LoadKhachHang()
        {
            List<FKhachHang_DTO> listKhachHang = khachHangBUS.selectListTop1();
            if (listKhachHang == null)
            {
                MessageBox.Show("co loi");
            }

            gridAnThongTin.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAnThongTin.DataSource = null;

            gridAnThongTin.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAnThongTin.DataSource = listKhachHang;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "maKH";
            clMa.DataPropertyName = "maKH";
            gridAnThongTin.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTenCR = new DataGridViewTextBoxColumn();
            clTenCR.Name = "CR";
            clTenCR.HeaderText = "Ten CR";
            clTenCR.DataPropertyName = "tenCR";
            gridAnThongTin.Columns.Add(clTenCR);

            DataGridViewTextBoxColumn cltenCD = new DataGridViewTextBoxColumn();
            cltenCD.Name = "CD";
            cltenCD.HeaderText = "Ten CD";
            cltenCD.DataPropertyName = "tenCD";
            gridAnThongTin.Columns.Add(cltenCD);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridAnThongTin.DataSource];
            myCurrencyManager.Refresh();
        }

        private void BindingThongTinDatTiec()
        {
            lbMaSanh.Text = Convert.ToString(gridAnDatTiec.Rows[0].Cells["MaSanh"].Value);
            dateNgayDT.Value =DateTime.Parse(gridAnDatTiec.Rows[0].Cells["NgayDT"].Value.ToString());
            int buoiDatTiec =int.Parse( gridAnDatTiec.Rows[0].Cells["Ca"].Value.ToString());
            if (buoiDatTiec == 1)
                lbCa.Text = "Sang";
            else
                lbCa.Text = "Chieu";
            lbTienDatCoc.Text = Convert.ToString(gridAnDatTiec.Rows[0].Cells["TienDC"].Value);
            lbSLBan.Text = Convert.ToString(gridAnDatTiec.Rows[0].Cells["SLBan"].Value);
        }

        private void loadDatTiec()
        {
            List<FDatTiec_DTO> listDatTiec = datTiecBUS.SelectTop1();
            if(listDatTiec==null)
            {
                MessageBox.Show("co loi");
            }

            gridAnDatTiec.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAnDatTiec.DataSource = null;

            gridAnDatTiec.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAnDatTiec.DataSource = listDatTiec;

            DataGridViewTextBoxColumn clMaSanh = new DataGridViewTextBoxColumn();
            clMaSanh.Name = "MaSanh";
            clMaSanh.HeaderText = "MaSanh";
            clMaSanh.DataPropertyName = "maSanh";
            gridAnDatTiec.Columns.Add(clMaSanh);

            DataGridViewTextBoxColumn clCa = new DataGridViewTextBoxColumn();
            clCa.Name = "Ca";
            clCa.HeaderText = "Ca";
            clCa.DataPropertyName = "ca";
            gridAnDatTiec.Columns.Add(clCa);

            DataGridViewTextBoxColumn clSLBan = new DataGridViewTextBoxColumn();
            clSLBan.Name = "SLBan";
            clSLBan.HeaderText = "So luong ban";
            clSLBan.DataPropertyName = "slBan";
            gridAnDatTiec.Columns.Add(clSLBan);

            DataGridViewTextBoxColumn clNgayDT = new DataGridViewTextBoxColumn();
            clNgayDT.Name = "NgayDT";
            clNgayDT.HeaderText = "Ngay dat tiec";
            clNgayDT.DataPropertyName = "ngayDT";
            gridAnDatTiec.Columns.Add(clNgayDT);

            DataGridViewTextBoxColumn clTienDC = new DataGridViewTextBoxColumn();
            clTienDC.Name = "TienDC";
            clTienDC.HeaderText = "Tien Dat Coc";
            clTienDC.DataPropertyName = "tienDC";
            gridAnDatTiec.Columns.Add(clTienDC);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridAnDatTiec.DataSource];
            myCurrencyManager.Refresh();

        }

        private void loadMonAn()
        {
            List<FMenu_DTO> listMenu = menuBUS.selectTop1();

            gridAnMonAn.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAnMonAn.DataSource = null;

            gridAnMonAn.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAnMonAn.DataSource = listMenu;

            DataGridViewTextBoxColumn clMaHD = new DataGridViewTextBoxColumn();
            clMaHD.Name = "MaHD";
            clMaHD.HeaderText = "MaHD";
            clMaHD.DataPropertyName = "maHD";
            gridAnMonAn.Columns.Add(clMaHD);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "TenFake";
            clTen.HeaderText = "Ten";
            clTen.DataPropertyName = "tenFake";
            gridAnMonAn.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGiaFake";
            clDonGia.HeaderText = "Don Gia";
            clDonGia.DataPropertyName = "donGiaFake";
            gridAnMonAn.Columns.Add(clDonGia);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridAnMonAn.DataSource];
            myCurrencyManager.Refresh();
        }

        private void loadMenu()
        {
            for (int i = 0; i < gridAnMonAn.RowCount; i++)
            {
                Label lb = new Label();
                lb.AutoSize = false;
                lb.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Height = 40;
                lb.Width = 150;
                lb.Name = i.ToString();
                lb.Text = Convert.ToString(gridAnMonAn.Rows[i].Cells["TenFake"].Value);
                panelTen.Controls.Add(lb);
            }
            for (int i = 0; i < gridAnMonAn.RowCount; i++)
            {
                Label lb = new Label();
                lb.AutoSize = false;
                lb.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Height = 40;
                lb.Width = 150;
                lb.Name = i.ToString();
                lb.Text = Convert.ToString(gridAnMonAn.Rows[i].Cells["DonGiaFake"].Value);
                panelDonGia.Controls.Add(lb);
            }
        }
    }
}
