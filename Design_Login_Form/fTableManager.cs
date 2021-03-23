using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Login_Form
{
    public partial class fTableManager : Form
    {
        private IconButton currentBtn;//btuton đang ấn
        private Button subBtn;//Sub btn đang ấn
        private Panel leftBoderBtn;//Button bên trái
        private Form activeForm= new Form();//Form đang dùng
        public fTableManager()
        {
            InitializeComponent();
            customizeDesing();
            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBoderBtn);
            //Tạo một panel sát trái của pannel menu có chiểu cao bằng chiều cao 1 button
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Xóa Trắng All
        }
        private void openForm(Form form)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
            lbTitleForm.Text = form.Text;
        }

        private struct RBGCollors
        {
            public static Color color1 = Color.FromArgb(253, 138, 114);//Cam
            public static Color color2 = Color.FromArgb(249, 118, 176);//Hồng Phấn           
            public static Color color3 = Color.FromArgb(78, 240, 206);//Xanh lá
            public static Color color4 = Color.FromArgb(95, 77, 221);//Xanh Dương Đậm
            public static Color color5 = Color.FromArgb(249, 88, 155);//Hồng
            public static Color color6 = Color.FromArgb(24, 161, 251);//Xanh Dương Nhạt
            public static Color color7 = Color.FromArgb(172, 126, 241);//Tím
        }
#region Thêm Màu Bên Trái Btn
        private void addleftBoderBtn(Button A, Color color)
        {
            //left border button
            leftBoderBtn.BackColor = color;//panel sát trai đổi màu theo màu chữ
            leftBoderBtn.Location = new Point(0, A.Location.Y);// cho vị trị sát trái của button đang ấn
            leftBoderBtn.Visible = true;//Cho phép panel đc nhìn thấy
            leftBoderBtn.BringToFront();//Gọi panel lên khi ấn, hết thì k gọi nữa
        }
        #endregion

#region Thêm Màu Button Đang Mở
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();//hủy button hiện tại
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34, 36, 55);//Đổi Màu Back Color
                currentBtn.ForeColor = color;//Đổi Màu Chữ Thành Màu Được truyền Vào
                currentBtn.IconColor = color;//Đổi Màu Hình Ảnh Thành Màu Được Truyền Vào
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;//Căn Chỉnh Text vào Giữa
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;//Căn Chỉnh Hình Ảnh (text_ảnh)
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;//Căn Chỉnh Ảnh Sát Phải Button

                //Icon Currtnt Form
                iconCurrentForm.IconChar = currentBtn.IconChar;//Icon của panel Tiller Bả đổi theo Icon của Button
                iconCurrentForm.IconColor = color;//Đổi màu icon theo luôn
                lbTitleForm.ForeColor = color;
                btnMenu.ForeColor = color;
                btnMinimize.ForeColor = color;
                btnExit.ForeColor = color;
                btnSignOut.ForeColor = color;
            }
        }
        private void ActivateSubButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableSubButton();//hủy button hiện tại
                //Button
                subBtn = (Button)senderBtn;
                subBtn.BackColor = Color.FromArgb(34, 34, 34);//Đổi Màu Back Color
                subBtn.ForeColor = color;//Đổi Màu Chữ Thành Màu Được truyền Vào
            }
        }

        #endregion

#region Đóng Hoặc Chuyển Mục Đang Mở
        private void DisableButton()
        {
            if (currentBtn != null)//nếu btn đang ấn chưa đóng 
            {
                currentBtn.BackColor = Color.FromArgb(34, 36, 49);//Đưa màu về như cũ
                currentBtn.ForeColor = Color.FromArgb(78, 184, 206);//màu chữ về như cũ
                currentBtn.IconColor = Color.FromArgb(78, 184, 206);//màu icon về như cũ
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;//text dịch sang trái
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;//(Ảnh-Text)
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;//ảnh dịch sang trái
                
                
            }
        }
        private void DisableSubButton()
        {
            if (subBtn != null)//nếu btn đang ấn chưa đóng 
            {
                subBtn.BackColor = Color.FromArgb(34, 36, 40);//Đưa màu về như cũ
                subBtn.ForeColor = Color.LightGray;//màu chữ về như cũ
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBoderBtn.Visible = false;
        }
        #endregion

#region Show SubMenu
        private void customizeDesing()
        {
            panelQuanLy.Visible = false;
            panelBaoCao.Visible = false;
            panelThanhToan.Visible = false;
            panelHeThong.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelQuanLy.Visible == true)
                panelQuanLy.Visible = false;
            if (panelBaoCao.Visible == true)
                panelBaoCao.Visible = false;
            if (panelThanhToan.Visible == true)
                panelThanhToan.Visible = false;
            if (panelHeThong.Visible == true)
                panelHeThong.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            lbTitleForm.Text = btnQuanLy.Text;

            if (btnQuanLy.ForeColor == RBGCollors.color1)
            {
                Reset();
            }
            else
            {
                ActivateButton(sender, RBGCollors.color1);
            }
            showSubMenu(panelQuanLy);
            addleftBoderBtn(btnQuanLy, RBGCollors.color1);
        }
#region Quản Lý
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnNhanVien, RBGCollors.color1);
            openForm(new fQuanLyNhanVien());
        }

        private void btnKhuVuiChoi_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnKhuVuiChoi, RBGCollors.color1);
            openForm(new fQuanLyKhuVuiChoi());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnDichVu, RBGCollors.color1);
            openForm(new fQuanLyDichVu());
        }

        private void btnTrochoi_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnTrochoi, RBGCollors.color1);
            openForm(new fQuanLyTroChoi());
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnVe, RBGCollors.color1);
            openForm(new fQuanLyVeBan());
        }
        private void btnLoaiDichVu_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnLoaiDichVu, RBGCollors.color1);
            openForm(new fQuanLyLoaiDichVu());
        }
        #endregion

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            lbTitleForm.Text = btnBaoCao.Text;
            if (btnBaoCao.ForeColor == RBGCollors.color2)
            {
                Reset();
            }
            else
            {
                ActivateButton(sender, RBGCollors.color2);
            }
            showSubMenu(panelBaoCao);
            addleftBoderBtn(btnBaoCao, RBGCollors.color2);
        }
#region Báo Cáo
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnDoanhThu, RBGCollors.color2);
            openForm(new fBaoCaoDoanhThu());
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnLuong, RBGCollors.color2);
            openForm(new fThongKeLuong());
        }
        #endregion

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            lbTitleForm.Text = btnThanhToan.Text;

            if (btnThanhToan.ForeColor == RBGCollors.color3)
            {
                Reset();
            }
            else
            {
                ActivateButton(sender, RBGCollors.color3);
            }
            showSubMenu(panelThanhToan);
            addleftBoderBtn(btnThanhToan, RBGCollors.color3);
        }
#region Thanh Toán
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnHoaDon, RBGCollors.color3);
            openForm(new fThongTinHoaDon());
        }
        #endregion

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            lbTitleForm.Text = btnHeThong.Text;
            if (btnHeThong.ForeColor == RBGCollors.color4)
            {
                Reset();
            }
            else
            {
                ActivateButton(sender, RBGCollors.color4);
            }
            showSubMenu(panelHeThong);
            addleftBoderBtn(btnHeThong, RBGCollors.color4);
        }
#region Hệ Thống
        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnThongTinTaiKhoan, RBGCollors.color4);
            openForm(new fThongTinTaiKhoan());
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try { activeForm.Close(); }
            catch { }
            activeForm.Close();
            hideSubMenu();
            Reset();
            iconCurrentForm.IconChar = IconChar.Home;
            iconCurrentForm.IconColor = Color.FromArgb(78, 184, 206);
            lbTitleForm.Text = "Home";
            btnMenu.ForeColor = Color.FromArgb(78, 184, 206);
            btnMinimize.ForeColor = Color.FromArgb(78, 184, 206);
            btnExit.ForeColor = Color.FromArgb(78, 184, 206);
            btnSignOut.ForeColor = Color.FromArgb(78, 184, 206);
            lbTitleForm.ForeColor = Color.FromArgb(78, 184, 206);
        }

#region Thanh Tiêu Đề, Thoát, Thu Nhỏ
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
#region Đăng Xuất
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
