namespace ProjectWedding
{
    partial class FTraCuu
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridTraCuu = new System.Windows.Forms.DataGridView();
            this.btTiemkiem = new System.Windows.Forms.Button();
            this.bttcReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(291, 94);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(287, 32);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(187, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên:";
            // 
            // gridTraCuu
            // 
            this.gridTraCuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTraCuu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTraCuu.Location = new System.Drawing.Point(37, 178);
            this.gridTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridTraCuu.Name = "gridTraCuu";
            this.gridTraCuu.RowTemplate.Height = 24;
            this.gridTraCuu.Size = new System.Drawing.Size(840, 215);
            this.gridTraCuu.TabIndex = 7;
            // 
            // btTiemkiem
            // 
            this.btTiemkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTiemkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTiemkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTiemkiem.Image = global::ProjectWedding.Properties.Resources.magnifier;
            this.btTiemkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTiemkiem.Location = new System.Drawing.Point(592, 94);
            this.btTiemkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTiemkiem.Name = "btTiemkiem";
            this.btTiemkiem.Size = new System.Drawing.Size(121, 32);
            this.btTiemkiem.TabIndex = 6;
            this.btTiemkiem.Text = "Tìm kiếm ";
            this.btTiemkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTiemkiem.UseVisualStyleBackColor = false;
            this.btTiemkiem.Click += new System.EventHandler(this.btTiemkiem_Click);
            // 
            // bttcReturn
            // 
            this.bttcReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttcReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttcReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.bttcReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttcReturn.Location = new System.Drawing.Point(11, 11);
            this.bttcReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttcReturn.Name = "bttcReturn";
            this.bttcReturn.Size = new System.Drawing.Size(70, 30);
            this.bttcReturn.TabIndex = 0;
            this.bttcReturn.Text = "Return";
            this.bttcReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttcReturn.UseVisualStyleBackColor = false;
            this.bttcReturn.Click += new System.EventHandler(this.bttcReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(309, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "TRA CỨU TIỆC";
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x10801;
            this.ClientSize = new System.Drawing.Size(907, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridTraCuu);
            this.Controls.Add(this.btTiemkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bttcReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.gridTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttcReturn;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTiemkiem;
        private System.Windows.Forms.DataGridView gridTraCuu;
        private System.Windows.Forms.Label label3;
    }
}