using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWedding
{
    public partial class FMain : Form
    {
      
        public FMain()
        {
            InitializeComponent();
        }
       
        private void btReturn_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            this.Hide();
            login.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btDatTiec_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            datTiec.Show();
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            FTraCuu traCuu = new FTraCuu();
            this.Hide();
            traCuu.Show();
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            FHoaDon hoaDon = new FHoaDon();
            this.Hide();
            hoaDon.Show();
        }

        private void btSanh_Click_1(object sender, EventArgs e)
        {
            FSanh sanh = new FSanh();
            this.Hide();
            sanh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyCT quanLyCT = new FQuanLyCT();
            quanLyCT.Show();
        }

        //load text từ FLogin vô cái lblRole ở dưới hình người dùng để biết user hay admin
        private void FMain_Load(object sender, EventArgs e)
        {
            lblRole.Text = FLogin.SelectedText;
        }
    }
}
