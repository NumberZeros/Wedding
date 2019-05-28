namespace ProjectWedding
{
    partial class FHoaDon
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
            this.bthdReturn = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bthdReturn
            // 
            this.bthdReturn.Location = new System.Drawing.Point(21, 12);
            this.bthdReturn.Name = "bthdReturn";
            this.bthdReturn.Size = new System.Drawing.Size(75, 67);
            this.bthdReturn.TabIndex = 0;
            this.bthdReturn.Text = "Return";
            this.bthdReturn.UseVisualStyleBackColor = true;
            this.bthdReturn.Click += new System.EventHandler(this.bthdReturn_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.Location = new System.Drawing.Point(702, 12);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(75, 67);
            this.btThanhToan.TabIndex = 1;
            this.btThanhToan.Text = "Thanh Toán";
            this.btThanhToan.UseVisualStyleBackColor = true;
            this.btThanhToan.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hóa đơn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 206);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chú rể";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên cô dâu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày thanh toán";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(321, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng tiền hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tiền đã đặt cọc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Số tiền còn lại";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(456, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(321, 150);
            this.dataGridView2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Các món ăn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Các dịch vụ";
            // 
            // FHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.bthdReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bthdReturn;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}