namespace ProjectWedding
{
    partial class FBaoCao
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
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D2 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView4 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView5 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView6 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            this.btbcReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chartThang = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView6)).BeginInit();
            this.SuspendLayout();
            // 
            // btbcReturn
            // 
            this.btbcReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbcReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btbcReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbcReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btbcReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbcReturn.Location = new System.Drawing.Point(12, 12);
            this.btbcReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbcReturn.Name = "btbcReturn";
            this.btbcReturn.Size = new System.Drawing.Size(96, 36);
            this.btbcReturn.TabIndex = 0;
            this.btbcReturn.Text = "Return";
            this.btbcReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbcReturn.UseVisualStyleBackColor = false;
            this.btbcReturn.Click += new System.EventHandler(this.btbcReturn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProjectWedding.Properties.Resources.login_square_arrow_button_outline;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1303, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartThang
            // 
            xyDiagram3D2.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" +
    "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" +
    "1";
            this.chartThang.Diagram = xyDiagram3D2;
            this.chartThang.Location = new System.Drawing.Point(193, 15);
            this.chartThang.Name = "chartThang";
            series3.Name = "Series 1";
            series3.View = sideBySideBar3DSeriesView4;
            series4.Name = "Series 2";
            series4.View = sideBySideBar3DSeriesView5;
            this.chartThang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3,
        series4};
            this.chartThang.SeriesTemplate.View = sideBySideBar3DSeriesView6;
            this.chartThang.Size = new System.Drawing.Size(1036, 707);
            this.chartThang.TabIndex = 8;
            // 
            // FBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.MagnetStreet_PinkMarble_1920x1080;
            this.ClientSize = new System.Drawing.Size(1393, 777);
            this.Controls.Add(this.chartThang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btbcReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBaoCao";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbcReturn;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraCharts.ChartControl chartThang;
    }
}