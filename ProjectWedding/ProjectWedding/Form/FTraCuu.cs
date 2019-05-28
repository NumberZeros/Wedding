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
    public partial class FTraCuu : Form
    {
        public FTraCuu()
        {
            InitializeComponent();
        }

        private void bttcReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }
    }
}
