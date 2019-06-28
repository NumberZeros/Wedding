namespace ProjectWedding
{
    partial class FQuanLyCT
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
            this.label2 = new System.Windows.Forms.Label();
            this.btQuayve = new System.Windows.Forms.Button();
            this.btThongkeDL = new System.Windows.Forms.Button();
            this.btQuanlyMon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHI TIẾT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thao tác";
            // 
            // btQuayve
            // 
            this.btQuayve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayve.Location = new System.Drawing.Point(12, 13);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(98, 41);
            this.btQuayve.TabIndex = 3;
            this.btQuayve.Text = "Quay về";
            this.btQuayve.UseVisualStyleBackColor = true;
            this.btQuayve.Click += new System.EventHandler(this.btQuayve_Click);
            // 
            // btThongkeDL
            // 
            this.btThongkeDL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongkeDL.Location = new System.Drawing.Point(392, 154);
            this.btThongkeDL.Name = "btThongkeDL";
            this.btThongkeDL.Size = new System.Drawing.Size(174, 108);
            this.btThongkeDL.TabIndex = 4;
            this.btThongkeDL.Text = "Thống kê dữ liệu";
            this.btThongkeDL.UseVisualStyleBackColor = true;
            this.btThongkeDL.Click += new System.EventHandler(this.btThongkeDL_Click);
            // 
            // btQuanlyMon
            // 
            this.btQuanlyMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanlyMon.Location = new System.Drawing.Point(145, 154);
            this.btQuanlyMon.Name = "btQuanlyMon";
            this.btQuanlyMon.Size = new System.Drawing.Size(173, 108);
            this.btQuanlyMon.TabIndex = 5;
            this.btQuanlyMon.Text = "Quản lý món ăn";
            this.btQuanlyMon.UseVisualStyleBackColor = true;
            this.btQuanlyMon.Click += new System.EventHandler(this.button3_Click);
            // 
            // FQuanLyCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 337);
            this.Controls.Add(this.btQuanlyMon);
            this.Controls.Add(this.btThongkeDL);
            this.Controls.Add(this.btQuayve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FQuanLyCT";
            this.Text = "FQuanLyCT";
            this.Load += new System.EventHandler(this.FQuanLyCT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.Button btThongkeDL;
        private System.Windows.Forms.Button btQuanlyMon;
    }
}