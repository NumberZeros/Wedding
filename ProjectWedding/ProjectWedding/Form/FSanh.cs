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
    public partial class FSanh : Form
    {
        public FSanh()
        {
            InitializeComponent();
        }

        private void btsReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        private FSanh_BUS sanhBUS=new FSanh_BUS();
        private FSanh_DTO sanhDTO = new FSanh_DTO();

        private void LoadSanh()
        {
            List<FSanh_DTO> listSanh = sanhBUS.select();
            if (listSanh == null)
            {
                DialogResult kq = MessageBox.Show("Loi", "Vui long kiem tra lai internet truoc khi load data", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                    Application.Restart();
            }

            gridSanh.Columns.Clear(); //xóa sạch cột trên datagridview
            gridSanh.DataSource = null;

            gridSanh.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridSanh.AllowUserToAddRows = false;  //không cho phép người dụng tự động thêm cột
            gridSanh.DataSource = listSanh;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Sảnh";
            clMa.DataPropertyName = "maSanh"; //kiểu dữ liệu nằm ở lớp DTO
            gridSanh.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên Sảnh";
            clTen.DataPropertyName = "tenSanh";
            gridSanh.Columns.Add(clTen);

            DataGridViewTextBoxColumn clLoai = new DataGridViewTextBoxColumn();
            clLoai.Name = "LoaiSanh";
            clLoai.HeaderText = "Loai Sảnh";
            clLoai.DataPropertyName = "loaiSanh";
            gridSanh.Columns.Add(clLoai);

            DataGridViewTextBoxColumn clSL = new DataGridViewTextBoxColumn();
            clSL.Name = "SLMax";
            clSL.HeaderText = "Số Lượng bàn tối đa";
            clSL.DataPropertyName = "soluongMax";
            gridSanh.Columns.Add(clSL);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DGMin";
            clDonGia.HeaderText = "Đơn giá tối thiểu";
            clDonGia.DataPropertyName = "donGiaMin";
            gridSanh.Columns.Add(clDonGia);

            DataGridViewTextBoxColumn clGhiChu = new DataGridViewTextBoxColumn();
            clGhiChu.Name = "GhiChu";
            clGhiChu.HeaderText = "Ghi Chú";
            clGhiChu.DataPropertyName = "ghiChu";
            gridSanh.Columns.Add(clGhiChu);

            /// ep app cập nhật dữ liệu ngay lập tức lên datagridview  bằng cách binding datasource
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridSanh.DataSource];
            myCurrencyManager.Refresh();
        }
        private void FSanh_Load(object sender, EventArgs e)
        {
            LoadSanh();
            //disable 3 nút
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;

        }


        private void btSua_Click(object sender, EventArgs e)
        {
            sanhDTO.maSanh = int.Parse(label6.Text);
            sanhDTO.tenSanh = tbTen.Text;
            sanhDTO.loaiSanh = tbLoaiSanh.Text;
            sanhDTO.soluongMax = int.Parse(tbSLBan.Text);
            sanhDTO.donGiaMin = int.Parse(tbDonGia.Text);
            sanhDTO.ghiChu = tbGhiChu.Text;
            if (sanhDTO != null)
            {
                bool kq = sanhBUS.Update(sanhDTO);
                if (kq == false)
                    MessageBox.Show("Sửa nội dung thất bại. Vui lòng kiểm tra lại dữ liệu");
                else
                {
                    MessageBox.Show("Sửa nội dung thành công");
                    LoadSanh();
                }
            }
        }

        private void btTroGiup_Click(object sender, EventArgs e)
        {
            //enable 3 nút 
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int currentRowIndex = gridSanh.CurrentCellAddress.Y;
            if (-1 < currentRowIndex && currentRowIndex < gridSanh.RowCount)
            {
                sanhDTO = (FSanh_DTO)gridSanh.Rows[currentRowIndex].DataBoundItem;
                if (sanhDTO != null)
                {
                    bool kq = sanhBUS.delete(sanhDTO);
                    if (kq == false)
                        MessageBox.Show("Xóa kiểu nấu thất bại. Vui lòng kiểm tra lại dũ liệu");
                    else
                    {
                        MessageBox.Show("Xóa Kiểu nấu thành công");
                        LoadSanh();
                    }
                }
            }
        }



        private void btThem_Click(object sender, EventArgs e)
        {
            sanhDTO.tenSanh = tbTen.Text;
            sanhDTO.loaiSanh = tbLoaiSanh.Text;
            sanhDTO.soluongMax = int.Parse(tbSLBan.Text);
            sanhDTO.donGiaMin = int.Parse(tbDonGia.Text);
            sanhDTO.ghiChu = tbGhiChu.Text;
            bool kq = sanhBUS.ADD(sanhDTO);
            if (kq == true)
            {
                MessageBox.Show("Thêm dữ liệu thành công ");
            }
            else
                MessageBox.Show("Thêm dữ liệu thất bại", "Vui lòng kiểm tra lại thông tin");
            LoadSanh();
        }

        // binding dữ liệu lên các mục 
        private void gridSanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;
            indexRow = e.RowIndex;
            DataGridViewRow row = gridSanh.Rows[indexRow];
            label6.Text = row.Cells[0].Value.ToString();
            tbTen.Text = row.Cells[1].Value.ToString();
            tbLoaiSanh.Text = row.Cells[2].Value.ToString();
            tbSLBan.Text = row.Cells[3].Value.ToString();
            tbDonGia.Text = row.Cells[4].Value.ToString();
            tbGhiChu.Text = row.Cells[5].Value.ToString();
        }
    }
}
