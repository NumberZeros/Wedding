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
            clLoai.HeaderText = "Tên Sảnh";
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
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            sanhDTO.tenSanh = tbTen.Text;
            sanhDTO.loaiSanh = cbLoai.Text;
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

    }
}
