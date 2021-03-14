namespace Design_Login_Form
{
    partial class fThongTinTaiKhoan
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
            this.gbQuanLyNhanVien = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbQuanLyNhanVien
            // 
            this.gbQuanLyNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.gbQuanLyNhanVien.Location = new System.Drawing.Point(12, 12);
            this.gbQuanLyNhanVien.Name = "gbQuanLyNhanVien";
            this.gbQuanLyNhanVien.Size = new System.Drawing.Size(838, 605);
            this.gbQuanLyNhanVien.TabIndex = 5;
            this.gbQuanLyNhanVien.TabStop = false;
            this.gbQuanLyNhanVien.Text = "Thông Tin Tài Khoản";
            // 
            // fThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(862, 629);
            this.Controls.Add(this.gbQuanLyNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fThongTinTaiKhoan";
            this.Text = "Thông Tin Tài Khoản";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuanLyNhanVien;
    }
}