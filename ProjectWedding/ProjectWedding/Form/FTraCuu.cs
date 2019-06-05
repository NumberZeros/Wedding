using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

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

        private FDatTiec_BUS dattiecBUS = new FDatTiec_BUS();
        private FDatTiec_DTO dattiecDTO = new FDatTiec_DTO();

        private FKhachHang_BUS khachhangBUS = new FKhachHang_BUS();
        private FKhachHang_DTO khachhangDTO = new FKhachHang_DTO();


        private void LoadFTraCuu()
        {
            List<FDatTiec_DTO> listDatTiec = dattiecBUS.select();
            if (listDatTiec == null)
            {
                DialogResult kq = MessageBox.Show("Loi", "Vui long kiem tra lai internet truoc khi load data", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    Application.Restart();
            }

            List<FKhachHang_DTO> listKhachHang = khachhangBUS.select();
            if (listKhachHang == null)
            {
                DialogResult kq = MessageBox.Show("Loi", "Vui long kiem tra lai internet truoc khi load data", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    Application.Restart();
            }

            gridTraCuu.Columns.Clear();
            gridTraCuu.DataSource = null;


            gridTraCuu.AutoGenerateColumns = false;
            gridTraCuu.AllowUserToAddRows = false;
            gridTraCuu.DataSource = listDatTiec;
            gridTraCuu.DataSource = listKhachHang;

            DataGridViewTextBoxColumn clMaDT = new DataGridViewTextBoxColumn();
            clMaDT.Name = "Ma";
            clMaDT.HeaderText = "Mã đặt tiệc";
            clMaDT.DataPropertyName = "maDT"; //kiểu dữ liệu nằm ở lớp DTO
            gridTraCuu.Columns.Add(clMaDT);

            DataGridViewTextBoxColumn clNgayDT = new DataGridViewTextBoxColumn();
            clNgayDT.Name = "NgayDT";
            clNgayDT.HeaderText = "Ngày đặt tiệc";
            clNgayDT.DataPropertyName = "ngayDT";
            gridTraCuu.Columns.Add(clNgayDT);

            DataGridViewTextBoxColumn clCa = new DataGridViewTextBoxColumn();
            clCa.Name = "Ca";
            clCa.HeaderText = "Ca";
            clCa.DataPropertyName = "ca";
            gridTraCuu.Columns.Add(clCa);

            DataGridViewTextBoxColumn clTenCD = new DataGridViewTextBoxColumn();
            clTenCD.Name = "TenCD";
            clTenCD.HeaderText = "Tên cô dâu";
            clTenCD.DataPropertyName = "tenCD"; //kiểu dữ liệu nằm ở lớp DTO
            gridTraCuu.Columns.Add(clTenCD);

            DataGridViewTextBoxColumn clTenCR = new DataGridViewTextBoxColumn();
            clTenCR.Name = "TenCR";
            clTenCR.HeaderText = "Tên chú rể";
            clTenCR.DataPropertyName = "tenCR";
            gridTraCuu.Columns.Add(clTenCR);

            DataGridViewTextBoxColumn clSDT = new DataGridViewTextBoxColumn();
            clSDT.Name = "SDT";
            clSDT.HeaderText = "Số điện thoại";
            clSDT.DataPropertyName = "soDT";
            gridTraCuu.Columns.Add(clSDT);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridTraCuu.DataSource];
            myCurrencyManager.Refresh();
        }
        private void FTraCuu_Load(object sender, EventArgs e)
        {
            LoadFTraCuu();

        }
    }
}
