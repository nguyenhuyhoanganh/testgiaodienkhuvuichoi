using Design_Login_Form.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Login_Form
{
    
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region Username-Password Text
        private void txbUsername_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "Username")
                txbUsername.Clear();
            
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
                txbPassword.Clear();
            txbPassword.UseSystemPasswordChar = true;
        }
        #endregion
        #region Register Effect
        private void btnRegister_MouseMove(object sender, MouseEventArgs e)
        {
            btnRegister.ForeColor = Color.FromArgb(78, 220, 206);
            btnRegister.IconColor = Color.FromArgb(78, 220, 206);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.FromArgb(78, 184, 206);
            btnRegister.IconColor = Color.FromArgb(78, 184, 206);
        }
        #endregion
        #region Username Effect
        private void txbUsername_MouseMove(object sender, MouseEventArgs e)
        {
            iconUsername.IconColor = Color.FromArgb(78, 220, 206);
            panelUsername.BackColor = Color.FromArgb(78, 220, 206);
            txbUsername.ForeColor = Color.FromArgb(78, 220, 206);
        }

        private void txbUsername_MouseLeave(object sender, EventArgs e)
        {
            iconUsername.IconColor = Color.FromArgb(78, 184, 206);
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            txbUsername.ForeColor = Color.FromArgb(78, 184, 206);     
        }
        #endregion
        #region Password Effect
        private void txbPassword_MouseMove(object sender, MouseEventArgs e)
        {
            iconPassword.IconColor = Color.FromArgb(78, 220, 206);
            panelPassword.BackColor = Color.FromArgb(78, 220, 206);
            txbPassword.ForeColor = Color.FromArgb(78, 220, 206);
            btnChangePasswordChar.IconColor = Color.FromArgb(78, 220, 206);
        }

        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            iconPassword.IconColor = Color.FromArgb(78, 184, 206);
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            txbPassword.ForeColor = Color.FromArgb(78, 184, 206);
            btnChangePasswordChar.IconColor = Color.FromArgb(78, 184, 206);
        }
        #endregion
        #region Exit Effect
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(78, 184, 206);
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.IconColor = Color.FromArgb(78, 220, 206);
        }
        #endregion
        #region Smile Effect
        private void iconSmile_MouseMove(object sender, MouseEventArgs e)
        {
            iconSmile.IconColor = Color.FromArgb(78, 220, 206);
        }

        private void iconSmile_MouseLeave(object sender, EventArgs e)
        {
            iconSmile.IconColor = Color.FromArgb(78, 184, 206);
        }
        #endregion
        #region Password Char Change
        private void btnChangePasswordChar_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar == true)
                txbPassword.UseSystemPasswordChar = false;
            else
                txbPassword.UseSystemPasswordChar = true;
        }

        private void btnChangePasswordChar_MouseMove(object sender, MouseEventArgs e)
        {
            iconPassword.IconColor = Color.FromArgb(78, 220, 206);
            panelPassword.BackColor = Color.FromArgb(78, 220, 206);
            txbPassword.ForeColor = Color.FromArgb(78, 220, 206);
            btnChangePasswordChar.IconColor = Color.FromArgb(78, 220, 206);
        }

        private void btnChangePasswordChar_MouseLeave(object sender, EventArgs e)
        {
            iconPassword.IconColor = Color.FromArgb(78, 184, 206);
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            txbPassword.ForeColor = Color.FromArgb(78, 184, 206);
            btnChangePasswordChar.IconColor = Color.FromArgb(78, 184, 206);
        }
        #endregion

        bool Login(string userName, string passWord)
        {
            return NhanVienDAO.Instance.Login(userName, passWord);
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (Login(txbUsername.Text, txbPassword.Text)==true)
            {
                fTableManager manager = new fTableManager();
                this.Hide();
                manager.ShowDialog();
                try { this.Show(); }
                catch { this.Close(); }
            }
            else
            {
                fMessageBox messageBox = new fMessageBox();
                messageBox.message = "Đăng Nhập Không Thành Công !";
                messageBox.Show();
            }
        }
        #region Title Bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Kéo Title Bar
        #endregion
    }
}
