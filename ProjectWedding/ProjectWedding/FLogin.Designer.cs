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
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(285, 80);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(100, 22);
            this.tbAccount.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(285, 153);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 22);
            this.tbPass.TabIndex = 1;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(285, 243);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 36);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login ";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbExit
            // 
            this.tbExit.Location = new System.Drawing.Point(285, 319);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(75, 23);
            this.tbExit.TabIndex = 3;
            this.tbExit.Text = "Exit";
            this.tbExit.UseVisualStyleBackColor = true;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbAccount);
            this.Name = "FLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button tbExit;
    }
}

