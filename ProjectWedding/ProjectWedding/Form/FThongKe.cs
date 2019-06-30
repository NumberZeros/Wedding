using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace ProjectWedding
{
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
        }

        private FDatTiec_DTO dattiecDTO = new FDatTiec_DTO();
        private FDatTiec_BUS dattiecBUS = new FDatTiec_BUS();

        private void btQuayve_Click(object sender, EventArgs e)
        {
            FQuanLyCT quanlyCT = new FQuanLyCT();
            this.Hide();
            this.Close();
            quanlyCT.Show();
        }

        private void LoadThongKe()
        {
            List<FDatTiec_DTO> listThongKe = dattiecBUS.groupbyThongke();
            //if (listThongKe == null)
            //{
            //    DialogResult kq = MessageBox.Show("Lỗi", "Đã xảy ra lỗi trong qua trình tải dữ liệu, kiểm tra lại kết nối mạng", MessageBoxButtons.YesNo);
            //    if (kq == DialogResult.Yes)
            //        Application.Restart();

            //}

            gridThongke.Columns.Clear();
            gridThongke.DataSource = null;

            gridThongke.AutoGenerateColumns = false;
            gridThongke.AllowUserToAddRows = false;
            gridThongke.DataSource = listThongKe;

            DataGridViewTextBoxColumn clNgayDT = new DataGridViewTextBoxColumn();
            clNgayDT.Name = "NgayDT";
            clNgayDT.HeaderText = "Ngày đặt tiệc";
            clNgayDT.DataPropertyName = "ngayDT";
            gridThongke.Columns.Add(clNgayDT);

            DataGridViewTextBoxColumn clTenSanh = new DataGridViewTextBoxColumn();
            clTenSanh.Name = "TenSanh";
            clTenSanh.HeaderText = "Tên sảnh";
            clTenSanh.DataPropertyName = "tenSanhFake";
            gridThongke.Columns.Add(clTenSanh);

            DataGridViewTextBoxColumn clTongHD = new DataGridViewTextBoxColumn();
            clTongHD.Name = "TongHoaDon";
            clTongHD.HeaderText = "Tổng số hoá đơn";
            clTongHD.DataPropertyName = "tongHD";
            gridThongke.Columns.Add(clTongHD);


            DataGridViewTextBoxColumn clTongTien = new DataGridViewTextBoxColumn();
            clTongTien.Name = "TongTien";
            clTongTien.HeaderText = "Tổng số tiền";
            clTongTien.DataPropertyName = "tongTien";
            gridThongke.Columns.Add(clTongTien);


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridThongke.DataSource];
            myCurrencyManager.Refresh();

        }

        private void FThongKe_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }
    }
}
