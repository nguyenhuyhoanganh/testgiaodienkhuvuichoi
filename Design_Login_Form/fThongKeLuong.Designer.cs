namespace Design_Login_Form
{
    partial class fThongKeLuong
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
            this.txbTongLuong = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.dtpkThangLuong = new System.Windows.Forms.DateTimePicker();
            this.btnThongKeLuong = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvLuong = new System.Windows.Forms.DataGridView();
            this.labelThôngTinNhânViên = new System.Windows.Forms.Label();
            this.txbTongLuong.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTongLuong
            // 
            this.txbTongLuong.Controls.Add(this.label1);
            this.txbTongLuong.Controls.Add(this.txbTongDoanhThu);
            this.txbTongLuong.Controls.Add(this.dtpkThangLuong);
            this.txbTongLuong.Controls.Add(this.btnThongKeLuong);
            this.txbTongLuong.Controls.Add(this.label31);
            this.txbTongLuong.Controls.Add(this.panel1);
            this.txbTongLuong.Controls.Add(this.labelThôngTinNhânViên);
            this.txbTongLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.txbTongLuong.Location = new System.Drawing.Point(12, 12);
            this.txbTongLuong.Name = "txbTongLuong";
            this.txbTongLuong.Size = new System.Drawing.Size(838, 605);
            this.txbTongLuong.TabIndex = 3;
            this.txbTongLuong.TabStop = false;
            this.txbTongLuong.Text = "Thống Kê Lương";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tổng:";
            // 
            // txbTongDoanhThu
            // 
            this.txbTongDoanhThu.Location = new System.Drawing.Point(597, 541);
            this.txbTongDoanhThu.Name = "txbTongDoanhThu";
            this.txbTongDoanhThu.Size = new System.Drawing.Size(197, 27);
            this.txbTongDoanhThu.TabIndex = 62;
            this.txbTongDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpkThangLuong
            // 
            this.dtpkThangLuong.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpkThangLuong.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.dtpkThangLuong.CustomFormat = "MM/yyyy";
            this.dtpkThangLuong.Enabled = false;
            this.dtpkThangLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThangLuong.Location = new System.Drawing.Point(197, 67);
            this.dtpkThangLuong.Name = "dtpkThangLuong";
            this.dtpkThangLuong.Size = new System.Drawing.Size(198, 27);
            this.dtpkThangLuong.TabIndex = 61;
            // 
            // btnThongKeLuong
            // 
            this.btnThongKeLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.btnThongKeLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeLuong.Location = new System.Drawing.Point(470, 48);
            this.btnThongKeLuong.Name = "btnThongKeLuong";
            this.btnThongKeLuong.Size = new System.Drawing.Size(119, 46);
            this.btnThongKeLuong.TabIndex = 59;
            this.btnThongKeLuong.Text = "Thống Kê";
            this.btnThongKeLuong.UseVisualStyleBackColor = false;
            this.btnThongKeLuong.Click += new System.EventHandler(this.btnThongKeLuong_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(193, 48);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(113, 19);
            this.label31.TabIndex = 58;
            this.label31.Text = "Tháng Lương:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvLuong);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(14, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 357);
            this.panel1.TabIndex = 55;
            // 
            // dtgvLuong
            // 
            this.dtgvLuong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLuong.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgvLuong.Location = new System.Drawing.Point(0, 0);
            this.dtgvLuong.Name = "dtgvLuong";
            this.dtgvLuong.RowHeadersWidth = 51;
            this.dtgvLuong.RowTemplate.Height = 24;
            this.dtgvLuong.Size = new System.Drawing.Size(812, 357);
            this.dtgvLuong.TabIndex = 35;
            // 
            // labelThôngTinNhânViên
            // 
            this.labelThôngTinNhânViên.AutoSize = true;
            this.labelThôngTinNhânViên.Location = new System.Drawing.Point(6, 127);
            this.labelThôngTinNhânViên.Name = "labelThôngTinNhânViên";
            this.labelThôngTinNhânViên.Size = new System.Drawing.Size(58, 19);
            this.labelThôngTinNhânViên.TabIndex = 54;
            this.labelThôngTinNhânViên.Text = "Lương";
            // 
            // fThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(862, 629);
            this.Controls.Add(this.txbTongLuong);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThongKeLuong";
            this.Text = "Lương";
            this.txbTongLuong.ResumeLayout(false);
            this.txbTongLuong.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txbTongLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTongDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpkThangLuong;
        private System.Windows.Forms.Button btnThongKeLuong;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvLuong;
        private System.Windows.Forms.Label labelThôngTinNhânViên;
    }
}