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
            this.gbThongKeLuong = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbThongKeLuong
            // 
            this.gbThongKeLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.gbThongKeLuong.Location = new System.Drawing.Point(12, 12);
            this.gbThongKeLuong.Name = "gbThongKeLuong";
            this.gbThongKeLuong.Size = new System.Drawing.Size(838, 605);
            this.gbThongKeLuong.TabIndex = 3;
            this.gbThongKeLuong.TabStop = false;
            this.gbThongKeLuong.Text = "Thống Kê Lương";
            // 
            // fThongKeLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(862, 629);
            this.Controls.Add(this.gbThongKeLuong);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fThongKeLuong";
            this.Text = "Lương";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongKeLuong;
    }
}