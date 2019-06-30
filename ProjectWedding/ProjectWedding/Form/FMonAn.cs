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
    public partial class FMonAn : Form
    {
        public FMonAn()
        {
            InitializeComponent();
        }

        private FMonAn_BUS monanBUS = new FMonAn_BUS();
        private FMonAn_DTO monanDTO = new FMonAn_DTO();


        private void btThem_Click(object sender, EventArgs e)
        {

            monanDTO.maMonAn = int.Parse(tbMaMon.Text);
            monanDTO.ten = tbTenMon.Text;
            monanDTO.donGia = int.Parse(tbGia.Text);
            if (monanDTO != null)
            {
                bool kq = monanBUS.Them(monanDTO);
                if (kq == true)
                {
                    LoadMonAn();
                    MessageBox.Show("Thêm món ăn thành công");
                }
                else
                    MessageBox.Show("Thêm món ăn thất bại!");
            }
        }

        private void LoadMonAn()
        {

            FMonAn monan = new FMonAn();
            List<FMonAn_DTO> listMonAn = monanBUS.select();
            if (listMonAn == null)
            {
                DialogResult kq = MessageBox.Show("Lỗi", "Kiểm tra lại kết nối  mạng", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    monan.Refresh();
            }

            gridMon.Columns.Clear();
            gridMon.DataSource = null;

            gridMon.AutoGenerateColumns = false;
            gridMon.AllowUserToAddRows = false;
            gridMon.DataSource = listMonAn;

            DataGridViewTextBoxColumn clMaMon = new DataGridViewTextBoxColumn();
            clMaMon.Name = "MaMon";
            clMaMon.HeaderText = "Mã món ăn";
            clMaMon.DataPropertyName = "maMonAn";
            gridMon.Columns.Add(clMaMon);

            DataGridViewTextBoxColumn clTenMon = new DataGridViewTextBoxColumn();
            clTenMon.Name = "TenMon";
            clTenMon.HeaderText = "Tên món ăn";
            clTenMon.DataPropertyName = "ten";
            gridMon.Columns.Add(clTenMon);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGia";
            clDonGia.HeaderText = "Giá thành";
            clDonGia.DataPropertyName = "donGia";
            gridMon.Columns.Add(clDonGia);

            // có warning chỗ này tui không biết sửa sao
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridMon.DataSource];
            myCurrencyManager.Refresh();

        }

        private void btThaydoi_Click(object sender, EventArgs e)
        {
            monanDTO.maMonAn = int.Parse(tbMaMon.Text);
            monanDTO.ten = tbTenMon.Text;
            monanDTO.donGia = int.Parse(tbGia.Text);
            bool kq = monanBUS.Thaydoi(monanDTO);
            if (kq == true)
            {
                LoadMonAn();
                MessageBox.Show("Thay đổi món ăn thành công");
            }
            else
                MessageBox.Show("Thay đổu món ăn thất bại!");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = gridMon.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < gridMon.RowCount)
            {
                monanDTO = (FMonAn_DTO)gridMon.Rows[currentRowIndex].DataBoundItem;
                if (monanDTO != null)
                {
                    bool kq = monanBUS.Xoa(monanDTO);
                    if (kq == true)
                    {
                        LoadMonAn();
                        MessageBox.Show("Xóa món ăn thành công");
                    }
                    else
                        MessageBox.Show("Xóa món ăn thất bại");
                }
            }
        }

        private void gridMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = gridMon.Rows[indexRow];
            tbMaMon.Text = row.Cells[0].Value.ToString();
            tbTenMon.Text = row.Cells[1].Value.ToString();
            tbGia.Text = row.Cells[2].Value.ToString();
        }

        private void btQuayve_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        private void FMonAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
        }
    }
}
