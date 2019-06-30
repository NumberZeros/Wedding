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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gridMon = new System.Windows.Forms.DataGridView();
            this.btQuayve = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btThaydoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(54, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã là 20*** khi là dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(54, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã là 10*** khi là mon ăn";
            // 
            // gridMon
            // 
            this.gridMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMon.Location = new System.Drawing.Point(48, 257);
            this.gridMon.Name = "gridMon";
            this.gridMon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridMon.Size = new System.Drawing.Size(848, 233);
            this.gridMon.TabIndex = 26;
            this.gridMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMon_CellClick);
            // 
            // btQuayve
            // 
            this.btQuayve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQuayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btQuayve.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btQuayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuayve.Location = new System.Drawing.Point(12, 22);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(84, 29);
            this.btQuayve.TabIndex = 25;
            this.btQuayve.Text = "Return";
            this.btQuayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuayve.UseVisualStyleBackColor = false;
            this.btQuayve.Click += new System.EventHandler(this.btQuayve_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btThem.Location = new System.Drawing.Point(48, 184);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(145, 40);
            this.btThem.TabIndex = 24;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThaydoi
            // 
            this.btThaydoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThaydoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThaydoi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btThaydoi.Location = new System.Drawing.Point(382, 184);
            this.btThaydoi.Name = "btThaydoi";
            this.btThaydoi.Size = new System.Drawing.Size(145, 40);
            this.btThaydoi.TabIndex = 23;
            this.btThaydoi.Text = "Sửa";
            this.btThaydoi.UseVisualStyleBackColor = false;
            this.btThaydoi.Click += new System.EventHandler(this.btThaydoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btXoa.Location = new System.Drawing.Point(751, 184);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(145, 40);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "Xóa ";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // tbTenMon
            // 
            this.tbTenMon.Location = new System.Drawing.Point(399, 88);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(185, 20);
            this.tbTenMon.TabIndex = 21;
            // 
            // tbMaMon
            // 
            this.tbMaMon.Location = new System.Drawing.Point(131, 89);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(129, 20);
            this.tbMaMon.TabIndex = 20;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(751, 88);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(129, 20);
            this.tbGia.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá thành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(331, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            // 
            // FMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x1080;
            this.ClientSize = new System.Drawing.Size(941, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMonAn";
            this.Text = "FMonAn";
            this.Load += new System.EventHandler(this.FMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gridMon;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThaydoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}