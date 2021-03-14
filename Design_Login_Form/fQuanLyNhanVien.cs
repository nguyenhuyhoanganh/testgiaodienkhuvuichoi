using Design_Login_Form.DAO;
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
    public partial class fQuanLyNhanVien : Form
    {
        public fQuanLyNhanVien()
        {
            InitializeComponent();           
        }

        /*private void fQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            string query = "select * from NHANVIEN";
            dtgvNV.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }*/
    }
}
