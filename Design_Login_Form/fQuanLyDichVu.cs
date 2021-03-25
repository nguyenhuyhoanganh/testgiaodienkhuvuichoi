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
    public partial class fQuanLyDichVu : Form
    {
        BindingSource dvlist = new BindingSource();
        public fQuanLyDichVu()
        {
            InitializeComponent();
            load();
            LoaiDVBinding();
        }

        void LoaiDVBinding()
        {
            txbMaDichVu.DataBindings.Add(new Binding("Text", dtgvThongTinDichVu.DataSource, "Mã dịch vụ", true, DataSourceUpdateMode.Never));
            txbTenDichVu.DataBindings.Add(new Binding("Text", dtgvThongTinDichVu.DataSource, "Tên dịch vụ", true, DataSourceUpdateMode.Never));
            txbDonGiaDV.DataBindings.Add(new Binding("Text", dtgvThongTinDichVu.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            txbMaLoaiDichVu_DV.DataBindings.Add(new Binding("Text", dtgvThongTinDichVu.DataSource, "Mã loại dịch vụ", true, DataSourceUpdateMode.Never));
        }


        void load()
        {


            string query = "exec ThongTinDV";
            dtgvThongTinDichVu.DataSource = dvlist;
            dvlist.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbMaDichVu.Text == "" || txbTenDichVu.Text == "" || txbDonGiaDV.Text == "" || txbMaLoaiDichVu_DV.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin!";
                fm.ShowDialog();
            }
            else
            {

                string madv = txbMaDichVu.Text;
                string tendv = txbTenDichVu.Text;
                decimal dongia = Convert.ToDecimal(txbDonGiaDV.Text);
                string maldv = txbMaLoaiDichVu_DV.Text;



                if (DichVuDAO.Instance.InsertDV(madv, tendv, dongia, maldv))
                {
                    fm.message = "Thêm loại dịch vụ thành công!";
                    fm.ShowDialog();
                    load();
                }
                else
                {
                    fm.message = "Thêm loại dịch vụ không thành công!";
                    fm.ShowDialog();
                }
            }
        }

        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbMaDichVu.Text == "" || txbTenDichVu.Text == "" || txbDonGiaDV.Text == "" || txbMaLoaiDichVu_DV.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin!";
                fm.ShowDialog();
            }
            else
            {

                string madv = txbMaDichVu.Text;
                string tendv = txbTenDichVu.Text;
                decimal dongia = Convert.ToDecimal(txbDonGiaDV.Text);
                string maldv = txbMaLoaiDichVu_DV.Text;



                if (DichVuDAO.Instance.UpdateDV(madv, tendv, dongia, maldv))
                {
                    fm.message = "Sửa dịch vụ thành công!";
                    fm.ShowDialog();
                    load();
                }
                else
                {
                    fm.message = "Sửa dịch vụ không thành công!";
                    fm.ShowDialog();
                }
            }

        }
        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            string madv = txbMaDichVu.Text;
            if (DichVuDAO.Instance.DeleteDV(madv))
            {
                fm.message = "Xóa dịch vụ thành công!";
                fm.ShowDialog();
                load();
            }
            else
            {
                fm.message = "Xóa dịch vụ không thành công!";
                fm.ShowDialog();
            }
        }

        private void btnXemDichVu_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnTimKiemDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbTimKiem.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin tìm kiếm !";
                fm.ShowDialog();
            }
            else
            {
                if (rbtnTheoTen.Checked == false && rbtnTheoMa.Checked == false)
                {
                    fm.message = "Bạn chưa chọn chủ đề tìm kiếm";
                    fm.ShowDialog();
                }
                else
                {
                    if (rbtnTheoTen.Checked == true)
                    {
                        string query = string.Format("exec TimKiemDV_Ten N'{0}'", txbTimKiem.Text);
                        dtgvThongTinDichVu.DataSource = DataProvider.Instance.ExecuteQuery(query);
                        int count = dtgvThongTinDichVu.Rows.Count - 1;
                        fm.message = "Tìm thấy " + count + " kết quả";
                        fm.ShowDialog();
                    }
                    else if (rbtnTheoMa.Checked == true)
                    {
                        string query = string.Format("exec TimKiemDV_Ma N'{0}'", txbTimKiem.Text);
                        dtgvThongTinDichVu.DataSource = DataProvider.Instance.ExecuteQuery(query);
                        int count = dtgvThongTinDichVu.Rows.Count - 1;
                        fm.message = "Tìm thấy " + count + " kết quả";
                        fm.ShowDialog();


                    }
                }
            }
        }
    }
}
