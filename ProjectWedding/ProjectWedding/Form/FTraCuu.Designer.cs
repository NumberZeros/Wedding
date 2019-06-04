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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTiemkiem = new System.Windows.Forms.Button();
            this.bttcReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(150, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(147, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày đặt tiệc:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 98);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 165);
            this.dataGridView1.TabIndex = 7;
            // 
            // btTiemkiem
            // 
            this.btTiemkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTiemkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTiemkiem.Image = global::ProjectWedding.Properties.Resources.magnifier;
            this.btTiemkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTiemkiem.Location = new System.Drawing.Point(263, 131);
            this.btTiemkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTiemkiem.Name = "btTiemkiem";
            this.btTiemkiem.Size = new System.Drawing.Size(88, 28);
            this.btTiemkiem.TabIndex = 6;
            this.btTiemkiem.Text = "Tìm kiếm ";
            this.btTiemkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTiemkiem.UseVisualStyleBackColor = false;
            // 
            // bttcReturn
            // 
            this.bttcReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttcReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttcReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.bttcReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttcReturn.Location = new System.Drawing.Point(11, 11);
            this.bttcReturn.Margin = new System.Windows.Forms.Padding(2);
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
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tra cứu tiệc";
            // 
            // FTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x10801;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btTiemkiem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttcReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttcReturn;
        private System.Windows.Forms.DataGridView gridTraCuu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btTiemkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}