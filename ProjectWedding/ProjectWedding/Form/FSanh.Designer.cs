﻿namespace ProjectWedding
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
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.tbSLBan = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.btTroGiup = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLoaiSanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btsReturn
            // 
            this.btsReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsReturn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btsReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsReturn.Location = new System.Drawing.Point(12, 12);
            this.btsReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsReturn.Name = "btsReturn";
            this.btsReturn.Size = new System.Drawing.Size(124, 32);
            this.btsReturn.TabIndex = 0;
            this.btsReturn.Text = "Return";
            this.btsReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsReturn.UseVisualStyleBackColor = false;
            this.btsReturn.Click += new System.EventHandler(this.btsReturn_Click);
            // 
            // gridSanh
            // 
            this.gridSanh.AllowDrop = true;
            this.gridSanh.AllowUserToOrderColumns = true;
            this.gridSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSanh.Location = new System.Drawing.Point(98, 447);
            this.gridSanh.Margin = new System.Windows.Forms.Padding(4);
            this.gridSanh.Name = "gridSanh";
            this.gridSanh.RowTemplate.Height = 24;
            this.gridSanh.Size = new System.Drawing.Size(1276, 260);
            this.gridSanh.TabIndex = 21;
            this.gridSanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSanh_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1085, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Đơn giá ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số Lượng Bàn Tối Đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại Sảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên Sảnh";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(200, 158);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(1100, 38);
            this.tbGhiChu.TabIndex = 26;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(1200, 66);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(100, 38);
            this.tbDonGia.TabIndex = 24;
            // 
            // tbSLBan
            // 
            this.tbSLBan.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSLBan.Location = new System.Drawing.Point(946, 66);
            this.tbSLBan.Name = "tbSLBan";
            this.tbSLBan.Size = new System.Drawing.Size(100, 38);
            this.tbSLBan.TabIndex = 23;
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTen.Location = new System.Drawing.Point(200, 66);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(229, 38);
            this.tbTen.TabIndex = 22;
            // 
            // btTroGiup
            // 
            this.btTroGiup.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroGiup.Image = global::ProjectWedding.Properties.Resources.question_1;
            this.btTroGiup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroGiup.Location = new System.Drawing.Point(1200, 292);
            this.btTroGiup.Name = "btTroGiup";
            this.btTroGiup.Size = new System.Drawing.Size(138, 50);
            this.btTroGiup.TabIndex = 35;
            this.btTroGiup.Text = "Trợ Giúp";
            this.btTroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTroGiup.UseVisualStyleBackColor = true;
            this.btTroGiup.Click += new System.EventHandler(this.btTroGiup_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::ProjectWedding.Properties.Resources.updated;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(891, 292);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 50);
            this.btSua.TabIndex = 34;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::ProjectWedding.Properties.Resources.clear;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(547, 292);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 50);
            this.btXoa.TabIndex = 33;
            this.btXoa.Text = "Xoá";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::ProjectWedding.Properties.Resources.add2;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(179, 292);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 50);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 36;
            this.label6.Visible = false;
            // 
            // tbLoaiSanh
            // 
            this.tbLoaiSanh.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoaiSanh.Location = new System.Drawing.Point(611, 66);
            this.tbLoaiSanh.Name = "tbLoaiSanh";
            this.tbLoaiSanh.Size = new System.Drawing.Size(47, 38);
            this.tbLoaiSanh.TabIndex = 37;
            // 
            // FSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.lobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1459, 767);
            this.Controls.Add(this.tbLoaiSanh);
            this.Controls.Add(this.label6);
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
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.tbSLBan);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.gridSanh);
            this.Controls.Add(this.btsReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.TextBox tbSLBan;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button btTroGiup;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLoaiSanh;
    }
}