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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void btMenuMonAn_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            this.Close();
            datTiec.Show();
        }
    }
}
