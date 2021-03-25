using Design_Login_Form.DAO;
using System;
using System.Windows.Forms;

namespace Design_Login_Form
{
    public partial class fQuanLyLoaiDichVu : Form
    {
        BindingSource loaidvlist = new BindingSource();
        public fQuanLyLoaiDichVu()
        {
            InitializeComponent();
            load();
            LoaiDVBinding();

        }

        void LoaiDVBinding()
        {
            txbMaLoaiDichVu.DataBindings.Add(new Binding("Text", dtgvThongTinLoaiDichVu.DataSource, "Mã loại dịch vụ", true, DataSourceUpdateMode.Never));
            txbTenLoaiDichVu.DataBindings.Add(new Binding("Text", dtgvThongTinLoaiDichVu.DataSource, "Tên loại dịch vụ", true, DataSourceUpdateMode.Never));
        }


        void load()
        {


            string query = "exec ThongTinLDV";
            dtgvThongTinLoaiDichVu.DataSource = loaidvlist;
            loaidvlist.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnThemLoaiDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbMaLoaiDichVu.Text == "" || txbTenLoaiDichVu.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin!";
                fm.ShowDialog();
            }
            else
            {

                string tenloaidv = txbTenLoaiDichVu.Text; 
                string maloaidv = txbMaLoaiDichVu.Text;
                

                if (LoaiDVDAO.Instance.InsertLoaiDV(maloaidv, tenloaidv))
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

        private void btnSuaLoaiDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbMaLoaiDichVu.Text == "" || txbTenLoaiDichVu.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin!";
                fm.ShowDialog();
            }
            else
            {

                string tenloaidv = txbTenLoaiDichVu.Text; 
                string maloaidv = txbMaLoaiDichVu.Text;
                

                if (LoaiDVDAO.Instance.UpdateLoaiDV(maloaidv,tenloaidv))
                {
                    fm.message = "Sửa loại dịch vụ thành công!";
                    fm.ShowDialog();
                    load();
                }
                else
                {
                    fm.message = "Sửa loại dịch vụ không thành công!";
                    fm.ShowDialog();
                }
            }
        }

        private void btnXoaLoaiDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbMaLoaiDichVu.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin!";
                fm.ShowDialog();
            }
            else
            {
                string maloaidv = txbMaLoaiDichVu.Text;

                if (LoaiDVDAO.Instance.DeleteLoaiDV(maloaidv))
                {
                    fm.message = "Xóa loại dịch vụ thành công!";
                    fm.ShowDialog();
                    load();
                }
                else
                {
                    fm.message = "Xóa loại dịch vụ không thành công!";
                    fm.ShowDialog();
                }
            }
        }

        private void btnXemLoaiDichVu_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnTimKiemLoaiDichVu_Click(object sender, EventArgs e)
        {
            fMessageBox fm = new fMessageBox();
            if (txbTimKiem.Text == "")
            {
                fm.message = "Bạn chưa nhập thông tin tìm kiếm !";
                fm.ShowDialog();
            }
            else
            {
                if(rbtnTheoTen.Checked == false && rbtnTheoMa.Checked == false)
                {
                    fm.message = "Bạn chưa chọn chủ đề tìm kiếm";
                    fm.ShowDialog();
                }
                else
                {
                    if (rbtnTheoTen.Checked == true)
                    {
                        string query = string.Format("exec TimKiemLDV_Ten N'{0}'", txbTimKiem.Text);
                        dtgvThongTinLoaiDichVu.DataSource = DataProvider.Instance.ExecuteQuery(query);
                        int count = dtgvThongTinLoaiDichVu.Rows.Count - 1;
                        fm.message = "Tìm thấy " + count + " kết quả";
                        fm.ShowDialog();
                    }
                    else if (rbtnTheoMa.Checked == true)
                    {
                        string query = string.Format("exec TimKiemLDV_Ma N'{0}'", txbTimKiem.Text);
                        dtgvThongTinLoaiDichVu.DataSource = DataProvider.Instance.ExecuteQuery(query);
                        int count = dtgvThongTinLoaiDichVu.Rows.Count - 1;
                        fm.message = "Tìm thấy " + count + " kết quả";
                        fm.ShowDialog();


                    }
                }
            }
        }
    }

}
