namespace ProjectWedding
{
    partial class FMenu
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
            this.btMenuMonAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenuMonAn
            // 
            this.btMenuMonAn.Location = new System.Drawing.Point(12, 12);
            this.btMenuMonAn.Name = "btMenuMonAn";
            this.btMenuMonAn.Size = new System.Drawing.Size(75, 65);
            this.btMenuMonAn.TabIndex = 0;
            this.btMenuMonAn.Text = "Return ";
            this.btMenuMonAn.UseVisualStyleBackColor = true;
            this.btMenuMonAn.Click += new System.EventHandler(this.btMenuMonAn_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMenuMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMonAn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenuMonAn;
    }
}