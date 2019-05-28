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

        private void ptTraCuu_Click(object sender, EventArgs e)
        {
            FTraCuu traCuu = new FTraCuu();
            this.Hide();
            traCuu.Show();

        }

        private void ptSanh_Click(object sender, EventArgs e)
        {
            FSanh sanh = new FSanh();
            this.Hide();
            sanh.Show();
        }

        private void ptDacTiec_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            datTiec.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FHoaDon hoaDon = new FHoaDon();
            this.Hide();
            hoaDon.Show();
        }

        private void ptBaoCao_Click(object sender, EventArgs e)
        {
            FBaoCao baoCao = new FBaoCao();
            this.Hide();
            baoCao.Show();
        }
    }
}
