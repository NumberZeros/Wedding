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
            this.btQuanlyMon = new System.Windows.Forms.Button();
            this.btThongkeDL = new System.Windows.Forms.Button();
            this.btQuayve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuanlyMon
            // 
            this.btQuanlyMon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQuanlyMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuanlyMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btQuanlyMon.Location = new System.Drawing.Point(145, 153);
            this.btQuanlyMon.Name = "btQuanlyMon";
            this.btQuanlyMon.Size = new System.Drawing.Size(173, 108);
            this.btQuanlyMon.TabIndex = 10;
            this.btQuanlyMon.Text = "Quản lý món ăn";
            this.btQuanlyMon.UseVisualStyleBackColor = false;
            this.btQuanlyMon.Click += new System.EventHandler(this.btQuanlyMon_Click);
            // 
            // btThongkeDL
            // 
            this.btThongkeDL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThongkeDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongkeDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btThongkeDL.Location = new System.Drawing.Point(385, 153);
            this.btThongkeDL.Name = "btThongkeDL";
            this.btThongkeDL.Size = new System.Drawing.Size(174, 108);
            this.btThongkeDL.TabIndex = 9;
            this.btThongkeDL.Text = "Thống kê dữ liệu";
            this.btThongkeDL.UseVisualStyleBackColor = false;
            this.btThongkeDL.Click += new System.EventHandler(this.btThongkeDL_Click);
            // 
            // btQuayve
            // 
            this.btQuayve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btQuayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuayve.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btQuayve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuayve.Location = new System.Drawing.Point(12, 12);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(91, 35);
            this.btQuayve.TabIndex = 8;
            this.btQuayve.Text = "Return";
            this.btQuayve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuayve.UseVisualStyleBackColor = false;
            this.btQuayve.Click += new System.EventHandler(this.btQuayve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thao tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ CHI TIẾT";
            // 
            // FQuanLyCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x1080;
            this.ClientSize = new System.Drawing.Size(593, 332);
            this.Controls.Add(this.btQuanlyMon);
            this.Controls.Add(this.btThongkeDL);
            this.Controls.Add(this.btQuayve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQuanLyCT";
            this.Text = "FQuanLyCT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuanlyMon;
        private System.Windows.Forms.Button btThongkeDL;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}