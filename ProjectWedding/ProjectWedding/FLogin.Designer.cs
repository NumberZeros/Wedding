namespace ProjectWedding
{
    partial class FLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbExit
            // 
            this.tbExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbExit.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tbExit.Image = global::ProjectWedding.Properties.Resources.login_square_arrow_button_outline;
            this.tbExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbExit.Location = new System.Drawing.Point(425, 11);
            this.tbExit.Margin = new System.Windows.Forms.Padding(2);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(83, 39);
            this.tbExit.TabIndex = 3;
            this.tbExit.Text = "Exit";
            this.tbExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbExit.UseVisualStyleBackColor = false;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.tbAccount);
            this.panel1.Location = new System.Drawing.Point(98, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 120);
            this.panel1.TabIndex = 15;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btLogin.Location = new System.Drawing.Point(196, 230);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(140, 38);
            this.btLogin.TabIndex = 21;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ProjectWedding.Properties.Resources._lock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(32, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjectWedding.Properties.Resources.user_1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbPass.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbPass.Location = new System.Drawing.Point(70, 72);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(214, 29);
            this.tbPass.TabIndex = 21;
            this.tbPass.Tag = "";
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tbAccount
            // 
            this.tbAccount.CausesValidation = false;
            this.tbAccount.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbAccount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbAccount.Location = new System.Drawing.Point(70, 21);
            this.tbAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(214, 29);
            this.tbAccount.TabIndex = 20;
            this.tbAccount.Tag = "";
            this.tbAccount.WordWrap = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.pinkWeddingHall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 312);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbAccount;
    }
}

