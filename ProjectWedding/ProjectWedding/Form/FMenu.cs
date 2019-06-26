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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        FMenu_DTO menuDTO = new FMenu_DTO();
        FHoaDon_DTO hoadonDTO = new FHoaDon_DTO();
        FMonAn_DTO monAnDTO = new FMonAn_DTO();

        FMenu_BUS menuBUS = new FMenu_BUS();
        FMonAn_BUS monAnBUS = new FMonAn_BUS();
        FHoaDon_BUS hoadonBUS = new FHoaDon_BUS();
        FKhachHang_BUS khBus = new FKhachHang_BUS();


        private void btMenuMonAn_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            this.Close();
            datTiec.Show();
        }

        //load dữ liệu lên 1 girdview ẩn và tạo button
        private void LoadGridAn(List<FMonAn_DTO> listMonAn)
        {
            listMonAn = monAnBUS.select();

            if (listMonAn == null)
            {
                MessageBox.Show("co loi");
            }

            gridAn.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAn.DataSource = null;

            gridAn.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAn.DataSource = listMonAn;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Menu";
            clMa.DataPropertyName = "maMonAn";
            gridAn.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên";
            clTen.DataPropertyName = "ten";
            gridAn.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGia";
            clDonGia.HeaderText = "Đơn Giá";
            clDonGia.DataPropertyName = "donGia";
            gridAn.Columns.Add(clDonGia);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridAn.DataSource];
            myCurrencyManager.Refresh();
        }

        // tiến hành load grid lên từng button để thực hiện việc thêm button

        Button bt;
        private void LoadMenu()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < gridAn.Rows.Count; i++)
            {
                bt = new Button();
                bt.Click += Bt_Click;
                bt.Height = 50;
                bt.Width = 200;
                bt.Text = Convert.ToString(gridAn.Rows[i].Cells["ten"].Value);
                bt.Name = i.ToString();
                bt.BackColor = Color.Aqua;
                bt.Font = new Font(FontFamily.GenericSansSerif, 12.0F);
                bt.TextAlign = ContentAlignment.MiddleCenter;
                flowLayoutPanel1.Controls.Add(bt);
            }
        }


        //sự kiện cho button ảo
        private void Bt_Click(object sender, EventArgs e)
        {
            List<FMonAn_DTO> listMenu = new List<FMonAn_DTO>();
            bt = (Button)sender;
            menuDTO.tenMonAn = bt.Text;
            menuDTO.maKHFake = int.Parse(cbMaKH.SelectedValue.ToString());
            menuBUS.Add(menuDTO);
            loadGridMenu();
            bt.Visible = false;
        }

        //load nhung muc co trong ket qua tim kiem len thanh button
        //private void LoadMenuTimKiem()
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    for (int i = 0; i < gridAn.Rows.Count; i++)
        //    {
        //        bt = new Button();
        //        bt.Click += Bt_Click;
        //        bt.Height = 50;
        //        bt.Width = 200;
        //        bt.Text = Convert.ToString(gridAn.Rows[i].Cells["ten"].Value);
        //        bt.Name = i.ToString();
        //        bt.BackColor = Color.Aqua;
        //        bt.Font = new Font(FontFamily.GenericSansSerif, 12.0F);
        //        bt.TextAlign = ContentAlignment.MiddleCenter;
        //        flowLayoutPanel1.Controls.Add(bt);
        //    }
        //}

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string sKeyword = tbTimKiem.Text.Trim(); //trim dung de xoa tat ca ca khoan trong co trong textbox
            if(sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0)
            {
                List<FMonAn_DTO> list = new List<FMonAn_DTO>();
                LoadGridAn(list);
                LoadMenu();
            }
            else
            {
                List<FMonAn_DTO> listTimkiem = monAnBUS.selectTimkiem(sKeyword);
                LoadGridAnTimKiem(listTimkiem);
                LoadMenu();
            }
        }



        private void LoadGridAnTimKiem(List<FMonAn_DTO> listTimkiem)
        {
            gridAn.Columns.Clear(); //xóa sạch cột trên datagridview
            gridAn.DataSource = null;

            gridAn.AutoGenerateColumns = false; //không cho phép tự động tạo cột
            gridAn.DataSource = listTimkiem;

            DataGridViewTextBoxColumn clMa = new DataGridViewTextBoxColumn();
            clMa.Name = "Ma";
            clMa.HeaderText = "Mã Menu";
            clMa.DataPropertyName = "maMonAn";
            gridAn.Columns.Add(clMa);

            DataGridViewTextBoxColumn clTen = new DataGridViewTextBoxColumn();
            clTen.Name = "Ten";
            clTen.HeaderText = "Tên";
            clTen.DataPropertyName = "ten";
            gridAn.Columns.Add(clTen);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGia";
            clDonGia.HeaderText = "Đơn Giá";
            clDonGia.DataPropertyName = "donGia";
            gridAn.Columns.Add(clDonGia);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[gridAn.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            //List<FMonAn_DTO> list = new List<FMonAn_DTO>();
            //LoadGridAn(list);
            LoadMaKhachHang();
            LoadMenu();
           
            
        }

        private void loadGridMenu()
        {
            gridMenu.DataSource= menuBUS.LoadMenu();

        }

        private void LoadMaKhachHang()
        {

            List<FKhachHang_DTO> ListMa = khBus.Makh();
            cbMaKH.DataSource = new BindingSource(ListMa, String.Empty);
            cbMaKH.ValueMember = "MaKH";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cbMaKH.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            menuBUS.delete();
            DialogResult kq;
            kq= MessageBox.Show("Ban co chac chan chua", "Thông Báo", MessageBoxButtons.YesNo);
            if(kq==DialogResult.Yes)
            {
                loadGridMenu();
            }
            
        }
    }
}
