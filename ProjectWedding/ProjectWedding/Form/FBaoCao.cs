using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace ProjectWedding
{
    public partial class FBaoCao : Form
    {
        public FBaoCao()
        {
            InitializeComponent();
        }

        FHoaDon_BUS hoaDonBUS = new FHoaDon_BUS();
        FHoaDon_DTO hoaDonDTO = new FHoaDon_DTO();

        private void btbcReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadChart()
        {
            ChartControl chart = new ChartControl();

        }

        private void FBaoCao_Load(object sender, EventArgs e)
        {
            radioHoaDon.Checked = true;
            LoadTongHoaDon();               // load chart hien thi thong tin cac cot la so luong hoa don
            if(radioDoanhThu.Checked==true)
            {
                LoadDoanhThu();             // load chart hien thi thong tin cac cot la tong tien
            }
        }

        private void LoadTongHoaDon()
        {
            DataTable grid = hoaDonBUS.GroupHoaDon();
            gridAn.DataSource = grid ;
            ChartControl chart = new ChartControl();
            chartControl1.DataSource = grid;
            //Series cot = new Series("Side-by-Side Bar Series 1", ViewType.Bar);
            //for (int i = 0; i < gridAn.RowCount; i++)
            //{
            //    Series hang = Equals(gridAn.Rows[i].Cells["Thang"].Value);
            //    int sl = int.Parse(gridAn.Rows[i].Cells["SoHD"].Value.ToString());

            //    cot.Points.Add(new SeriesPoint("Thang",thang, sl));
            //}
            //chartControl.

        }



        private void LoadDoanhThu()
        {
            throw new NotImplementedException();
        }


    }
}
