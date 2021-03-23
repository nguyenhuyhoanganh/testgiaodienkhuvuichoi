using Design_Login_Form.DAO;
using Design_Login_Form.DTO;
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
    public partial class fQuanLyVeBan : Form
    {
        public fQuanLyVeBan()
        {
            InitializeComponent();
        }

        private void btnXemVe_Click(object sender, EventArgs e)
        {
            dtgvVE.DataSource = VeDAO.Instance.Xem();
        }

        private void btnTimKiemVe_Click(object sender, EventArgs e)
        {
            string maVe = txbTimKiem.Text;
            dtgvVE.DataSource = VeDAO.Instance.TimKiem(maVe);
            if (dtgvVE.Rows.Count == 1)
            {
                fMessageBox mesage = new fMessageBox();
                mesage.message = "Không Tìm Được!!!";
                mesage.Show();
            }
        }

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            Ve ve = new Ve() ;
            ve.MaVe = txbMaVe.Text;
            ve.SoLuongNL = Convert.ToInt32(txbSoNL.Text);
            ve.SoLuongTE = Convert.ToInt32(txbSoTE.Text);
            ve.MaKhu = txbMaKhu_VE.Text; 
            ve.MaNV = txbMaNV_VE.Text;
            ve.TongTien = Convert.ToDecimal(txbTongTien.Text);
            ve.NgayBan = Convert.ToDateTime(txbNgayBan_VE.Value);
            if (VeDAO.Instance.Them(ve) > 0)
            {
                fMessageBox mesage = new fMessageBox();
                mesage.message = "Vé Đã Được Thêm";
                mesage.Show();
                btnXemVe_Click(sender, e);
            }
            else
            {
                fMessageBox mesage = new fMessageBox();
                mesage.message = "Không Thể Thêm Vé";
                mesage.Show();
            }
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {

        }
    }
}
