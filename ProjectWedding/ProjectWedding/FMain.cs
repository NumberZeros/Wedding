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
        //them cai man hinh SplashScreen (ten ban dau la Waitform) vo day vi hinh nhu bo Flogin r phai hom?
        public FMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
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

        private void btBaoCao_Click(object sender, EventArgs e)
        {
            FBaoCao baoCao = new FBaoCao();
            this.Hide();
            baoCao.Show();
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

    }
}
