namespace ProjectWedding
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            this.btReturn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btDatTiec = new System.Windows.Forms.Button();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.btBaoCao = new System.Windows.Forms.Button();
            this.btSanh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReturn.Location = new System.Drawing.Point(10, 11);
            this.btReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(113, 52);
            this.btReturn.TabIndex = 0;
            this.btReturn.Text = "Log out";
            this.btReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Image = global::ProjectWedding.Properties.Resources.login_square_arrow_button_outline;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.Location = new System.Drawing.Point(714, 11);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(108, 52);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btDatTiec
            // 
            this.btDatTiec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDatTiec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDatTiec.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatTiec.Image = global::ProjectWedding.Properties.Resources.food_and_restaurant;
            this.btDatTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDatTiec.Location = new System.Drawing.Point(452, 256);
            this.btDatTiec.Name = "btDatTiec";
            this.btDatTiec.Size = new System.Drawing.Size(283, 50);
            this.btDatTiec.TabIndex = 15;
            this.btDatTiec.Text = "Đặt tiệc";
            this.btDatTiec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip3.SetToolTip(this.btDatTiec, "Nhập thông tin đặt tiệc");
            this.btDatTiec.UseVisualStyleBackColor = false;
            this.btDatTiec.Click += new System.EventHandler(this.btDatTiec_Click);
            // 
            // btTraCuu
            // 
            this.btTraCuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraCuu.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuu.Image = global::ProjectWedding.Properties.Resources.search_4_;
            this.btTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraCuu.Location = new System.Drawing.Point(106, 309);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(283, 53);
            this.btTraCuu.TabIndex = 17;
            this.btTraCuu.Text = "Tra cứu tiệc";
            this.btTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btTraCuu, "Tra cứu tiệc theo ngày diễn ra");
            this.btTraCuu.UseVisualStyleBackColor = false;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);
            // 
            // btBaoCao
            // 
            this.btBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCao.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCao.Image = global::ProjectWedding.Properties.Resources.statistics_1_;
            this.btBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaoCao.Location = new System.Drawing.Point(106, 414);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(283, 50);
            this.btBaoCao.TabIndex = 18;
            this.btBaoCao.Text = "Báo cáo";
            this.btBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip4.SetToolTip(this.btBaoCao, "Báo cáo về doanh thu");
            this.btBaoCao.UseVisualStyleBackColor = false;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // btSanh
            // 
            this.btSanh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSanh.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanh.Image = global::ProjectWedding.Properties.Resources.search;
            this.btSanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSanh.Location = new System.Drawing.Point(106, 199);
            this.btSanh.Name = "btSanh";
            this.btSanh.Size = new System.Drawing.Size(283, 55);
            this.btSanh.TabIndex = 19;
            this.btSanh.Text = "Danh sách sảnh";
            this.btSanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip2.SetToolTip(this.btSanh, "Chỉnh sửa thông tin về Sảnh");
            this.btSanh.UseVisualStyleBackColor = false;
            this.btSanh.Click += new System.EventHandler(this.btSanh_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ProjectWedding.Properties.Resources.bills;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(452, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quản lí Sổ Chi Tiết";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip5.SetToolTip(this.button1, "Quản lí sổ chi tiết với nhiều thông tin về khách hàng và dịch vụ");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip4
            // 
            this.toolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectWedding.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(390, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F);
            this.lblRole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRole.Location = new System.Drawing.Point(397, 91);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 25);
            this.lblRole.TabIndex = 22;
            this.lblRole.Text = "admin";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.Main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 518);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSanh);
            this.Controls.Add(this.btBaoCao);
            this.Controls.Add(this.btTraCuu);
            this.Controls.Add(this.btDatTiec);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReturn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMain";
            this.Text = "main";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btDatTiec;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.Button btBaoCao;
        private System.Windows.Forms.Button btSanh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRole;
    }
}