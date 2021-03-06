﻿using System;
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
    public partial class FLogin : Form
    {
        //thêm cai man hinh SplashScreen (tên là Waitform)
        public FLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());
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
        public static string SelectedText = ""; //khai báo SelectedText để dùng

        private void tbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            if (CheckAccount() == 1)
            {
                SelectedText = tbAccount.Text; //lấy text từ tbAccount truyền vô string SelectedText
                this.Hide();
                main.Show();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error", "Thông tin nhập sai mời bạn thử lại", MessageBoxButtons.OK); //messageBox khi nhập sai
                if (dialog == DialogResult.OK)
                    Application.Restart();
            }
        }

        private void tbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
