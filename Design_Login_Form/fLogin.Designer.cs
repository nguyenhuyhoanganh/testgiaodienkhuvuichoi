namespace Design_Login_Form
{
    partial class fLogin
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnChangePasswordChar = new FontAwesome.Sharp.IconPictureBox();
            this.iconSmile = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegister = new FontAwesome.Sharp.IconButton();
            this.btnSignin = new FontAwesome.Sharp.IconButton();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.iconUsername = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePasswordChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txbUsername.HideSelection = false;
            this.txbUsername.Location = new System.Drawing.Point(78, 241);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(207, 20);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.TabStop = false;
            this.txbUsername.Text = "Username";
            this.txbUsername.Click += new System.EventHandler(this.txbUsername_Click);
            this.txbUsername.MouseLeave += new System.EventHandler(this.txbUsername_MouseLeave);
            this.txbUsername.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txbUsername_MouseMove);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelUsername.Location = new System.Drawing.Point(45, 264);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(270, 1);
            this.panelUsername.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.txbPassword.HideSelection = false;
            this.txbPassword.Location = new System.Drawing.Point(78, 286);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(207, 20);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.TabStop = false;
            this.txbPassword.Text = "Password";
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            this.txbPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txbPassword_MouseMove);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelPassword.Location = new System.Drawing.Point(45, 309);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(270, 1);
            this.panelPassword.TabIndex = 13;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 38);
            this.panelTitleBar.TabIndex = 14;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 29;
            this.btnExit.Location = new System.Drawing.Point(336, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseMove);
            // 
            // btnChangePasswordChar
            // 
            this.btnChangePasswordChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnChangePasswordChar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnChangePasswordChar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnChangePasswordChar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnChangePasswordChar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePasswordChar.IconSize = 33;
            this.btnChangePasswordChar.Location = new System.Drawing.Point(283, 278);
            this.btnChangePasswordChar.Name = "btnChangePasswordChar";
            this.btnChangePasswordChar.Size = new System.Drawing.Size(35, 33);
            this.btnChangePasswordChar.TabIndex = 12;
            this.btnChangePasswordChar.TabStop = false;
            this.btnChangePasswordChar.Click += new System.EventHandler(this.btnChangePasswordChar_Click);
            this.btnChangePasswordChar.MouseLeave += new System.EventHandler(this.btnChangePasswordChar_MouseLeave);
            this.btnChangePasswordChar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnChangePasswordChar_MouseMove);
            // 
            // iconSmile
            // 
            this.iconSmile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconSmile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconSmile.IconChar = FontAwesome.Sharp.IconChar.SmileWink;
            this.iconSmile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconSmile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSmile.IconSize = 142;
            this.iconSmile.Location = new System.Drawing.Point(90, 57);
            this.iconSmile.Name = "iconSmile";
            this.iconSmile.Size = new System.Drawing.Size(180, 142);
            this.iconSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSmile.TabIndex = 11;
            this.iconSmile.TabStop = false;
            this.iconSmile.MouseLeave += new System.EventHandler(this.iconSmile_MouseLeave);
            this.iconSmile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconSmile_MouseMove);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnRegister.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.btnRegister.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(45, 440);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(270, 52);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegister_MouseMove);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnSignin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignin.Location = new System.Drawing.Point(45, 348);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(270, 52);
            this.btnSignin.TabIndex = 0;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 31;
            this.iconPassword.Location = new System.Drawing.Point(45, 278);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(31, 33);
            this.iconPassword.TabIndex = 4;
            this.iconPassword.TabStop = false;
            // 
            // iconUsername
            // 
            this.iconUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUsername.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 31;
            this.iconUsername.Location = new System.Drawing.Point(45, 234);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(31, 33);
            this.iconUsername.TabIndex = 1;
            this.iconUsername.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(360, 570);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.btnChangePasswordChar);
            this.Controls.Add(this.iconSmile);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.iconPassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.iconUsername);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangePasswordChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconUsername;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private FontAwesome.Sharp.IconButton btnSignin;
        private FontAwesome.Sharp.IconButton btnRegister;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox iconSmile;
        private FontAwesome.Sharp.IconPictureBox btnChangePasswordChar;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}

