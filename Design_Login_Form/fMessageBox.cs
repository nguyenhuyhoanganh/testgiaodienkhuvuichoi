using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Login_Form
{
    public partial class fMessageBox : Form
    {
        public string message;
        public fMessageBox()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMessageBox_Load(object sender, EventArgs e)
        {
            txbMessage.Text = message;
        }

        private void btnCheck_MouseMove(object sender, MouseEventArgs e)
        {
            btnCheck.ForeColor = Color.FromArgb(78, 220, 206);
            btnCheck.IconColor = Color.FromArgb(78, 220, 206);
            txbMessage.ForeColor = Color.FromArgb(78, 220, 206);
            this.BackColor = Color.FromArgb(78, 220, 206);
        }

        private void btnCheck_MouseLeave(object sender, EventArgs e)
        {
            btnCheck.ForeColor = Color.FromArgb(78, 184, 206);
            btnCheck.IconColor = Color.FromArgb(78, 184, 206);
            txbMessage.ForeColor = Color.FromArgb(78, 184, 206);
            this.BackColor = Color.FromArgb(78, 184, 206);
        }
    }
}
