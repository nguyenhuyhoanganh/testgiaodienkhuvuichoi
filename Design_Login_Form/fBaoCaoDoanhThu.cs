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
    public partial class fBaoCaoDoanhThu : Form
    {
        public fBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongKeDT_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (dtpkNgayBatDau.Value>dtpkNgayKetThuc.Value)
            {
                fm.message = "Ngày bắt đầu không được lớn hơn";
                fm.ShowDialog();
            }
            else
            {
                try
                {
                    string que = "";
                    dtgvDoanhThu.DataSource = DataProvider.Instance.ExecuteQuery(que);
                }catch(Exception ex)
                {
                    fm.message = ex.ToString();
                }
            }
        }
    }
}
