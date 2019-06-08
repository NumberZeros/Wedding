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
    public partial class FHoaDon : Form
    {
        public FHoaDon()
        {
            InitializeComponent();
        }

        private void bthdReturn_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            this.Hide();
            this.Close();
            datTiec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDatTiec datTiec = new FDatTiec();
            DialogResult mb;
            mb = MessageBox.Show("Thong Bao ", "Ban co muon thanh toan hoa don khong", MessageBoxButtons.YesNo);
            if(mb== DialogResult.Yes)
            {
                this.Hide();
                this.Close();
                datTiec.Show();
            }
            
        }

        
    }
}
