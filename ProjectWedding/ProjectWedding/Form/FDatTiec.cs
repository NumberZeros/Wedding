using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWedding
{
    public partial class FDatTiec : Form
    {
        public FDatTiec()
        {
            InitializeComponent();
        }

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
            this.Hide();
            this.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            //
        }

        private void btDatTiec_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            MessageBox.Show("Dat tiec thanh cong");
            this.Hide();
            this.Close();
            main.Show();
        }

       
    }
}
