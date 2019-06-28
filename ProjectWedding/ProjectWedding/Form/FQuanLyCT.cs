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
    public partial class FQuanLyCT : Form
    {
        public FQuanLyCT()
        {
            InitializeComponent();
        }

        private void FQuanLyCT_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FMonAn monan = new FMonAn();
            this.Hide();
            this.Close();
            monan.Show();
        }

        private void btQuayve_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        private void btThongkeDL_Click(object sender, EventArgs e)
        {
            FThongKe thongke = new FThongKe();
            this.Hide();
            this.Close();
            thongke.Show();
        }
    }
}
