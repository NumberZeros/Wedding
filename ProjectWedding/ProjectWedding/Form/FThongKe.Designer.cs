namespace ProjectWedding
{
    partial class FThongKe
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
            this.gridThongke = new System.Windows.Forms.DataGridView();
            this.btQuayve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // gridThongke
            // 
            this.gridThongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridThongke.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongke.Location = new System.Drawing.Point(71, 123);
            this.gridThongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridThongke.Name = "gridThongke";
            this.gridThongke.Size = new System.Drawing.Size(831, 330);
            this.gridThongke.TabIndex = 8;
            // 
            // btQuayve
            // 
            this.btQuayve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayve.Location = new System.Drawing.Point(13, 13);
            this.btQuayve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(123, 46);
            this.btQuayve.TabIndex = 7;
            this.btQuayve.Text = "Quay về";
            this.btQuayve.UseVisualStyleBackColor = true;
            this.btQuayve.Click += new System.EventHandler(this.btQuayve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "THỐNG KÊ DỮ LIỆU";
            // 
            // FThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(997, 493);
            this.Controls.Add(this.gridThongke);
            this.Controls.Add(this.btQuayve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThongKe";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridThongke;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}