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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }


        // tạo quyền đăng nhập vào chương trình
        // hàm này sẽ đc khao báo trong class Flogin ở class BUS
        private int CheckAccount()
        {
            List<string> Acount1 = new List<string>();
            Acount1.Add("admin");
            Acount1.Add("1");

            List<string> Acount2 = new List<string>();
            Acount2.Add("user");
            Acount2.Add("2");
            bool checkAcount1 = Acount1.Contains(tbAccount.Text);
            bool checkAcount2 = Acount2.Contains(tbAccount.Text);
            bool checkPass1 = Acount1.Contains(tbPass.Text);
            bool checkPass2 = Acount2.Contains(tbPass.Text);
            if(checkAcount1)
            {
                if(checkPass1)
                {
                    return 1;
                }
            }
            if (checkAcount2)
            {
                if (checkPass2)
                {
                    return 1;
                }
            }
            return 0;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            if(CheckAccount()==1)
            {
                this.Hide();
                main.Show();
            }
            else
            {
                Application.Restart();
            }
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
