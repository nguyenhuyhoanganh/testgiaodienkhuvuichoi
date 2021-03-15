namespace Design_Login_Form
{
    partial class fThongTinHoaDon
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
            this.gbThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.dtgvThongTinCuThe = new System.Windows.Forms.DataGridView();
            this.dtgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.labelThôngTinNhânViên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.nmudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.gbThongTinHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinCuThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTinHoaDon
            // 
            this.gbThongTinHoaDon.Controls.Add(this.btnXemHoaDon);
            this.gbThongTinHoaDon.Controls.Add(this.label2);
            this.gbThongTinHoaDon.Controls.Add(this.nmudGiamGia);
            this.gbThongTinHoaDon.Controls.Add(this.btnXuatHoaDon);
            this.gbThongTinHoaDon.Controls.Add(this.label1);
            this.gbThongTinHoaDon.Controls.Add(this.labelThôngTinNhânViên);
            this.gbThongTinHoaDon.Controls.Add(this.dtgvDanhSachHoaDon);
            this.gbThongTinHoaDon.Controls.Add(this.dtgvThongTinCuThe);
            this.gbThongTinHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.gbThongTinHoaDon.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinHoaDon.Name = "gbThongTinHoaDon";
            this.gbThongTinHoaDon.Size = new System.Drawing.Size(838, 605);
            this.gbThongTinHoaDon.TabIndex = 4;
            this.gbThongTinHoaDon.TabStop = false;
            this.gbThongTinHoaDon.Text = "Thông Tin Hóa Đơn";
            // 
            // dtgvThongTinCuThe
            // 
            this.dtgvThongTinCuThe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvThongTinCuThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTinCuThe.Location = new System.Drawing.Point(438, 80);
            this.dtgvThongTinCuThe.Name = "dtgvThongTinCuThe";
            this.dtgvThongTinCuThe.RowHeadersWidth = 51;
            this.dtgvThongTinCuThe.RowTemplate.Height = 24;
            this.dtgvThongTinCuThe.Size = new System.Drawing.Size(370, 370);
            this.dtgvThongTinCuThe.TabIndex = 1;
            // 
            // dtgvDanhSachHoaDon
            // 
            this.dtgvDanhSachHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDon.Location = new System.Drawing.Point(30, 80);
            this.dtgvDanhSachHoaDon.Name = "dtgvDanhSachHoaDon";
            this.dtgvDanhSachHoaDon.RowHeadersWidth = 51;
            this.dtgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dtgvDanhSachHoaDon.Size = new System.Drawing.Size(370, 370);
            this.dtgvDanhSachHoaDon.TabIndex = 2;
            // 
            // labelThôngTinNhânViên
            // 
            this.labelThôngTinNhânViên.AutoSize = true;
            this.labelThôngTinNhânViên.Location = new System.Drawing.Point(26, 58);
            this.labelThôngTinNhânViên.Name = "labelThôngTinNhânViên";
            this.labelThôngTinNhânViên.Size = new System.Drawing.Size(162, 19);
            this.labelThôngTinNhânViên.TabIndex = 55;
            this.labelThôngTinNhânViên.Text = "Danh Sách Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Thông Tin Cụ Thể";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(648, 497);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(160, 46);
            this.btnXuatHoaDon.TabIndex = 60;
            this.btnXuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // nmudGiamGia
            // 
            this.nmudGiamGia.Location = new System.Drawing.Point(438, 514);
            this.nmudGiamGia.Name = "nmudGiamGia";
            this.nmudGiamGia.Size = new System.Drawing.Size(198, 27);
            this.nmudGiamGia.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Giảm Giá";
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.btnXemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHoaDon.Location = new System.Drawing.Point(30, 497);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(114, 46);
            this.btnXemHoaDon.TabIndex = 63;
            this.btnXemHoaDon.Text = "Xem";
            this.btnXemHoaDon.UseVisualStyleBackColor = false;
            // 
            // fThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(862, 629);
            this.Controls.Add(this.gbThongTinHoaDon);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(240)))), ((int)(((byte)(206)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThongTinHoaDon";
            this.Text = "Hóa Đơn";
            this.gbThongTinHoaDon.ResumeLayout(false);
            this.gbThongTinHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinCuThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudGiamGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongTinHoaDon;
        private System.Windows.Forms.DataGridView dtgvThongTinCuThe;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelThôngTinNhânViên;
        private System.Windows.Forms.NumericUpDown nmudGiamGia;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemHoaDon;
    }
}