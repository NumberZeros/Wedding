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
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btsReturn
            // 
            this.btsReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btsReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsReturn.Location = new System.Drawing.Point(9, 10);
            this.btsReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btsReturn.Name = "btsReturn";
            this.btsReturn.Size = new System.Drawing.Size(75, 26);
            this.btsReturn.TabIndex = 0;
            this.btsReturn.Text = "Return";
            this.btsReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsReturn.UseVisualStyleBackColor = false;
            this.btsReturn.Click += new System.EventHandler(this.btsReturn_Click);
            // 
            // gridSanh
            // 
            this.gridSanh.AllowUserToOrderColumns = true;
            this.gridSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSanh.Location = new System.Drawing.Point(21, 187);
            this.gridSanh.Name = "gridSanh";
            this.gridSanh.RowTemplate.Height = 24;
            this.gridSanh.Size = new System.Drawing.Size(645, 150);
            this.gridSanh.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(35, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(540, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(347, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số Lượng Bàn Tối Đa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(190, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại Sảnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên Sảnh:";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(91, 91);
            this.tbGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(564, 20);
            this.tbGhiChu.TabIndex = 26;
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
            this.cbLoai.Location = new System.Drawing.Point(252, 57);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(66, 21);
            this.cbLoai.TabIndex = 25;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(594, 57);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(61, 20);
            this.tbDonGia.TabIndex = 24;
            // 
            // tbSLBan
            // 
            this.tbSLBan.Location = new System.Drawing.Point(464, 57);
            this.tbSLBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSLBan.Name = "tbSLBan";
            this.tbSLBan.Size = new System.Drawing.Size(55, 20);
            this.tbSLBan.TabIndex = 23;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(91, 57);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(76, 20);
            this.tbTen.TabIndex = 22;
            // 
            // btTroGiup
            // 
            this.btTroGiup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTroGiup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btTroGiup.Image = global::ProjectWedding.Properties.Resources.information;
            this.btTroGiup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTroGiup.Location = new System.Drawing.Point(524, 130);
            this.btTroGiup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTroGiup.Name = "btTroGiup";
            this.btTroGiup.Size = new System.Drawing.Size(91, 28);
            this.btTroGiup.TabIndex = 35;
            this.btTroGiup.Text = "Trợ Giúp";
            this.btTroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroGiup.UseVisualStyleBackColor = false;
            this.btTroGiup.Click += new System.EventHandler(this.btTroGiup_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btSua.Image = global::ProjectWedding.Properties.Resources.pencil;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.Location = new System.Drawing.Point(367, 130);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(91, 28);
            this.btSua.TabIndex = 34;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btXoa.Image = global::ProjectWedding.Properties.Resources.delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.Location = new System.Drawing.Point(206, 130);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(91, 28);
            this.btXoa.TabIndex = 33;
            this.btXoa.Text = "Xoá";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btThem.Image = global::ProjectWedding.Properties.Resources.add_1_;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.Location = new System.Drawing.Point(60, 130);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(91, 28);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x1080;
            this.ClientSize = new System.Drawing.Size(683, 365);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btTroGiup;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
    }
}