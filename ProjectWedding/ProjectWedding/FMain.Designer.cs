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
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btDatTiec = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.btBaoCao = new System.Windows.Forms.Button();
            this.btSanh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Image = global::ProjectWedding.Properties.Resources.back_arrow;
            this.btReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReturn.Location = new System.Drawing.Point(11, 11);
            this.btReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(71, 26);
            this.btReturn.TabIndex = 0;
            this.btReturn.Text = "Return";
            this.btReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Image = global::ProjectWedding.Properties.Resources.login_square_arrow_button_outline;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.Location = new System.Drawing.Point(516, 11);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(57, 26);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
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
            this.btDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btDatTiec.Image = global::ProjectWedding.Properties.Resources.food_and_restaurant;
            this.btDatTiec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDatTiec.Location = new System.Drawing.Point(307, 191);
            this.btDatTiec.Name = "btDatTiec";
            this.btDatTiec.Size = new System.Drawing.Size(139, 31);
            this.btDatTiec.TabIndex = 15;
            this.btDatTiec.Text = "Đặt tiệc";
            this.btDatTiec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDatTiec.UseVisualStyleBackColor = false;
            this.btDatTiec.Click += new System.EventHandler(this.btDatTiec_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btHoaDon.Image = global::ProjectWedding.Properties.Resources.bills;
            this.btHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHoaDon.Location = new System.Drawing.Point(307, 266);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(114, 31);
            this.btHoaDon.TabIndex = 16;
            this.btHoaDon.Text = "Hóa đơn";
            this.btHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHoaDon.UseVisualStyleBackColor = false;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btTraCuu
            // 
            this.btTraCuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btTraCuu.Image = global::ProjectWedding.Properties.Resources.search_4_;
            this.btTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraCuu.Location = new System.Drawing.Point(126, 229);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(151, 31);
            this.btTraCuu.TabIndex = 17;
            this.btTraCuu.Text = "Tra cứu tiệc";
            this.btTraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTraCuu.UseVisualStyleBackColor = false;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);
            // 
            // btBaoCao
            // 
            this.btBaoCao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBaoCao.Image = global::ProjectWedding.Properties.Resources.statistics_1_;
            this.btBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaoCao.Location = new System.Drawing.Point(160, 299);
            this.btBaoCao.Name = "btBaoCao";
            this.btBaoCao.Size = new System.Drawing.Size(117, 31);
            this.btBaoCao.TabIndex = 18;
            this.btBaoCao.Text = "Báo cáo";
            this.btBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBaoCao.UseVisualStyleBackColor = false;
            this.btBaoCao.Click += new System.EventHandler(this.btBaoCao_Click);
            // 
            // btSanh
            // 
            this.btSanh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSanh.Image = global::ProjectWedding.Properties.Resources.search;
            this.btSanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSanh.Location = new System.Drawing.Point(77, 161);
            this.btSanh.Name = "btSanh";
            this.btSanh.Size = new System.Drawing.Size(200, 31);
            this.btSanh.TabIndex = 19;
            this.btSanh.Text = "Danh sách sảnh";
            this.btSanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSanh.UseVisualStyleBackColor = false;
            this.btSanh.Click += new System.EventHandler(this.btSanh_Click_1);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectWedding.Properties.Resources.Main1;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btSanh);
            this.Controls.Add(this.btBaoCao);
            this.Controls.Add(this.btTraCuu);
            this.Controls.Add(this.btHoaDon);
            this.Controls.Add(this.btDatTiec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMain";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btDatTiec;
        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.Button btBaoCao;
        private System.Windows.Forms.Button btSanh;
    }
}