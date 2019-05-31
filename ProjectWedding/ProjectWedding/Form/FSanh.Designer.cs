namespace ProjectWedding
{
    partial class FSanh
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
            this.btsReturn = new System.Windows.Forms.Button();
            this.gridSanh = new System.Windows.Forms.DataGridView();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.tbSLBan = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btsReturn
            // 
            this.btsReturn.Location = new System.Drawing.Point(12, 12);
            this.btsReturn.Name = "btsReturn";
            this.btsReturn.Size = new System.Drawing.Size(75, 48);
            this.btsReturn.TabIndex = 0;
            this.btsReturn.Text = "Return";
            this.btsReturn.UseVisualStyleBackColor = true;
            this.btsReturn.Click += new System.EventHandler(this.btsReturn_Click);
            // 
            // gridSanh
            // 
            this.gridSanh.AllowUserToOrderColumns = true;
            this.gridSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSanh.Location = new System.Drawing.Point(15, 276);
            this.gridSanh.Name = "gridSanh";
            this.gridSanh.RowTemplate.Height = 24;
            this.gridSanh.Size = new System.Drawing.Size(765, 150);
            this.gridSanh.TabIndex = 21;
            // 
            // btTroGiup
            // 
            this.btTroGiup.Location = new System.Drawing.Point(684, 176);
            this.btTroGiup.Name = "btTroGiup";
            this.btTroGiup.Size = new System.Drawing.Size(100, 50);
            this.btTroGiup.TabIndex = 39;
            this.btTroGiup.Text = "Trợ Giúp";
            this.btTroGiup.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(475, 176);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 50);
            this.btSua.TabIndex = 38;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(250, 176);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 50);
            this.btXoa.TabIndex = 37;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(36, 176);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 50);
            this.btThem.TabIndex = 36;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Đơn giá ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Số Lượng Bàn Tối Đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Loại Sảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên Sảnh";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(109, 129);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(653, 22);
            this.tbGhiChu.TabIndex = 30;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbLoai.Location = new System.Drawing.Point(302, 76);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(48, 24);
            this.cbLoai.TabIndex = 29;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(681, 78);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(100, 22);
            this.tbDonGia.TabIndex = 28;
            // 
            // tbSLBan
            // 
            this.tbSLBan.Location = new System.Drawing.Point(508, 78);
            this.tbSLBan.Name = "tbSLBan";
            this.tbSLBan.Size = new System.Drawing.Size(100, 22);
            this.tbSLBan.TabIndex = 27;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(109, 78);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(100, 22);
            this.tbTen.TabIndex = 26;
            // 
            // FSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.btTroGiup);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.tbSLBan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.gridSanh);
            this.Controls.Add(this.btsReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSanh";
            this.Load += new System.EventHandler(this.FSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsReturn;
        private System.Windows.Forms.DataGridView gridSanh;
        private System.Windows.Forms.Button btTroGiup;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbSLBan;
        private System.Windows.Forms.TextBox tbTen;
    }
}