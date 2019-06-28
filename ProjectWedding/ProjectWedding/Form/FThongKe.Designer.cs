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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btQuayve = new System.Windows.Forms.Button();
            this.gridThongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DỮ LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btQuayve
            // 
            this.btQuayve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayve.Location = new System.Drawing.Point(12, 12);
            this.btQuayve.Name = "btQuayve";
            this.btQuayve.Size = new System.Drawing.Size(92, 37);
            this.btQuayve.TabIndex = 3;
            this.btQuayve.Text = "Quay về";
            this.btQuayve.UseVisualStyleBackColor = true;
            // 
            // gridThongke
            // 
            this.gridThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongke.Location = new System.Drawing.Point(12, 55);
            this.gridThongke.Name = "gridThongke";
            this.gridThongke.Size = new System.Drawing.Size(623, 268);
            this.gridThongke.TabIndex = 4;
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 337);
            this.Controls.Add(this.gridThongke);
            this.Controls.Add(this.btQuayve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FThongKe";
            this.Text = "FThongKe";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQuayve;
        private System.Windows.Forms.DataGridView gridThongke;
    }
}