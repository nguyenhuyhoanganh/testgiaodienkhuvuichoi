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
    }
}
