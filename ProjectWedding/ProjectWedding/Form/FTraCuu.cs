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
    public partial class FTraCuu : Form
    {
        public FTraCuu()
        {
            InitializeComponent();
        }

        private void bttcReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        FDatTiec_DTO datTiecDTO = new FDatTiec_DTO();
        FDatTiec_BUS datTiecBUS = new FDatTiec_BUS();

        private void btTiemkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string name = String.Empty;
            name = tbName.Text.Trim();
            List<FDatTiec_DTO> list = datTiecBUS.SelectTraCuu(name);

            gridTraCuu.Columns.Clear(); //xóa sạch cột trên datagridview
            gridTraCuu.DataSource = null;

            gridTraCuu.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridTraCuu.DataSource = list;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Khách Hàng";
            clMa.DataPropertyName = "maKH";
            gridTraCuu.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTenCR = new DataGridViewTextBoxColumn();
            clTenCR.Name = "TenCR";
            clTenCR.HeaderText = "Tên Chú Rể";
            clTenCR.DataPropertyName = "tenCRFake";
            gridTraCuu.Columns.Add(clTenCR);

            DataGridViewTextBoxColumn clTenCD = new DataGridViewTextBoxColumn();
            clTenCD.Name = "TenCD";
            clTenCD.HeaderText = "Tên Cô Dâu";
            clTenCD.DataPropertyName = "tenCDFake";
            gridTraCuu.Columns.Add(clTenCD);

            DataGridViewTextBoxColumn clMaSanh = new DataGridViewTextBoxColumn();
            clMaSanh.Name = "maSanh";
            clMaSanh.HeaderText = "Mã Sảnh";
            clMaSanh.DataPropertyName = "maSanh";
            gridTraCuu.Columns.Add(clMaSanh);

            DataGridViewTextBoxColumn clCa = new DataGridViewTextBoxColumn();
            clCa.Name = "ca";
            clCa.HeaderText = "Ca";
            clCa.DataPropertyName = "ca";
            gridTraCuu.Columns.Add(clCa);

            DataGridViewTextBoxColumn clNgayDT = new DataGridViewTextBoxColumn();
            clNgayDT.Name = "NgayDT";
            clNgayDT.HeaderText = "Ngày Đặt Tiệc";
            clNgayDT.DataPropertyName = "ngayDT";
            gridTraCuu.Columns.Add(clNgayDT);

            DataGridViewTextBoxColumn clSLBan = new DataGridViewTextBoxColumn();
            clSLBan.Name = "slBan";
            clSLBan.HeaderText = "Số Lượng Bàn";
            clSLBan.DataPropertyName = "slBan";
            gridTraCuu.Columns.Add(clSLBan);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridTraCuu.DataSource];
            myCurrencyManager.Refresh();

            if(gridTraCuu.Rows.Count==0)
            {
                MessageBox.Show("Không có thông tin khách hàng trong hệ thống ", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
