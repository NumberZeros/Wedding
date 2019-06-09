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
            this.btUndo = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.gridAn = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridMenu = new System.Windows.Forms.DataGridView();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenuMonAn
            // 
            this.btMenuMonAn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMenuMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenuMonAn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btMenuMonAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenuMonAn.Location = new System.Drawing.Point(12, 12);
            this.btMenuMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMenuMonAn.Name = "btMenuMonAn";
            this.btMenuMonAn.Size = new System.Drawing.Size(96, 36);
            this.btMenuMonAn.TabIndex = 0;
            this.btMenuMonAn.Text = "Return ";
            this.btMenuMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenuMonAn.UseVisualStyleBackColor = false;
            this.btMenuMonAn.Click += new System.EventHandler(this.btMenuMonAn_Click);
            // 
            // btUndo
            // 
            this.btUndo.Location = new System.Drawing.Point(556, 287);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(127, 86);
            this.btUndo.TabIndex = 0;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(12, 80);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(458, 22);
            this.tbTimKiem.TabIndex = 3;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(477, 80);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(73, 23);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(717, 645);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(704, 80);
            this.btThanhToan.TabIndex = 5;
            this.btThanhToan.Text = "Hoàn Tất";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // gridAn
            // 
            this.gridAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAn.Location = new System.Drawing.Point(12, 132);
            this.gridAn.Name = "gridAn";
            this.gridAn.RowTemplate.Height = 24;
            this.gridAn.Size = new System.Drawing.Size(538, 150);
            this.gridAn.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(538, 593);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // gridMenu
            // 
            this.gridMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenu.Location = new System.Drawing.Point(717, 80);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.RowTemplate.Height = 24;
            this.gridMenu.Size = new System.Drawing.Size(704, 559);
            this.gridMenu.TabIndex = 2;
            // 
            // cbMaKH
            // 
            this.cbMaKH.Enabled = false;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(717, 50);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 24);
            this.cbMaKH.TabIndex = 11;
            this.cbMaKH.Visible = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1430, 803);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gridAn);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.gridMenu);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.btMenuMonAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuMonAn";
            this.Load += new System.EventHandler(this.FMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenuMonAn;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.DataGridView gridAn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView gridMenu;
        private System.Windows.Forms.ComboBox cbMaKH;
    }
}