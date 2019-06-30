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
            this.btMenuMonAn.Location = new System.Drawing.Point(9, 10);
            this.btMenuMonAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMenuMonAn.Name = "btMenuMonAn";
            this.btMenuMonAn.Size = new System.Drawing.Size(81, 29);
            this.btMenuMonAn.TabIndex = 0;
            this.btMenuMonAn.Text = "Return ";
            this.btMenuMonAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMenuMonAn.UseVisualStyleBackColor = false;
            this.btMenuMonAn.Click += new System.EventHandler(this.btMenuMonAn_Click);
            // 
            // btUndo
            // 
            this.btUndo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btUndo.Location = new System.Drawing.Point(428, 251);
            this.btUndo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(95, 54);
            this.btUndo.TabIndex = 0;
            this.btUndo.Text = "Undo";
            this.btUndo.UseVisualStyleBackColor = false;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTimKiem.Location = new System.Drawing.Point(10, 58);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(306, 28);
            this.tbTimKiem.TabIndex = 3;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTimKiem.Location = new System.Drawing.Point(320, 58);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(101, 29);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThanhToan.Location = new System.Drawing.Point(538, 524);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(528, 65);
            this.btThanhToan.TabIndex = 5;
            this.btThanhToan.Text = "Hoàn Tất";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // gridAn
            // 
            this.gridAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAn.Location = new System.Drawing.Point(9, 107);
            this.gridAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridAn.Name = "gridAn";
            this.gridAn.RowTemplate.Height = 24;
            this.gridAn.Size = new System.Drawing.Size(404, 122);
            this.gridAn.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImage = global::ProjectWedding.Properties.Resources.bill;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 107);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 482);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // gridMenu
            // 
            this.gridMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenu.Location = new System.Drawing.Point(538, 65);
            this.gridMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.RowTemplate.Height = 24;
            this.gridMenu.Size = new System.Drawing.Size(528, 454);
            this.gridMenu.TabIndex = 2;
            // 
            // cbMaKH
            // 
            this.cbMaKH.Enabled = false;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(990, 41);
            this.cbMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(77, 21);
            this.cbMaKH.TabIndex = 11;
            this.cbMaKH.Visible = false;
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.bill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 640);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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