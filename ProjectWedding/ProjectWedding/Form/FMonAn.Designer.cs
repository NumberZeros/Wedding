namespace ProjectWedding
{
    partial class FMonAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThaydoi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btQuayve = new System.Windows.Forms.Button();
            this.gridMon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã món ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá thành";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(590, 83);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(129, 20);
            this.tbGia.TabIndex = 4;
            // 
            // tbMaMon
            // 
            this.tbMaMon.Location = new System.Drawing.Point(86, 83);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(129, 20);
            this.tbMaMon.TabIndex = 5;
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(311, 83);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(185, 20);
            this.tbTenMon.TabIndex = 6;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(590, 144);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 40);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa món ăn";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThaydoi
            // 
            this.btThaydoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThaydoi.Location = new System.Drawing.Point(274, 144);
            this.btThaydoi.Name = "btThaydoi";
            this.btThaydoi.Size = new System.Drawing.Size(145, 40);
            this.btThaydoi.TabIndex = 8;
            this.btThaydoi.Text = "Thay đổi món ăn";
            this.btThaydoi.UseVisualStyleBackColor = true;
            this.btThaydoi.Click += new System.EventHandler(this.btThaydoi_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(12, 144);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(145, 40);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm món ăn";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btQuayve
            // 
            this.btQuayve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayve.Location = new System.Drawing.Point(5, 12);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(112, 40);
            this.btQuayve.TabIndex = 10;
            this.btQuayve.Text = "Quay về";
            this.btQuayve.UseVisualStyleBackColor = true;
            this.btQuayve.Click += new System.EventHandler(this.btQuayve_Click);
            // 
            // gridMon
            // 
            this.gridMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMon.Location = new System.Drawing.Point(6, 190);
            this.gridMon.Name = "gridMon";
            this.gridMon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridMon.Size = new System.Drawing.Size(729, 233);
            this.gridMon.TabIndex = 11;
            // 
            // FMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 435);
            this.Controls.Add(this.gridMon);
            this.Controls.Add(this.btQuayve);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btThaydoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.tbTenMon);
            this.Controls.Add(this.tbMaMon);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FMonAn";
            this.Text = "FMonAn";
            this.Load += new System.EventHandler(this.FMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThaydoi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.DataGridView gridMon;
    }
}