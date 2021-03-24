using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Design_login_Form.DAO;

namespace Design_Login_Form
{
    public partial class fQuanLyKhuVuiChoi : Form
    {
        static String connString = ConnectionString.str;
        SqlConnection conn = new SqlConnection(connString);
        public fQuanLyKhuVuiChoi()
        {
            InitializeComponent();
        }
        
        private void btnXemKhu_Click(object sender, EventArgs e)
        {
            try
            {   
                if(conn.State==ConnectionState.Closed)
                conn.Open();
                Sqlxem();
                if(conn.State==ConnectionState.Open)
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Sqlxem()
        {
            string SqlSELECT = "SELECT MAKHU as N'Mã khu',TENKHU as N'Tên khu',GIAVENL as N'Giá vé người lớn',GIAVETE as N'Giá vé trẻ em',DIADIEM as N'Địa điểm' FROM KHUVUICHOI";
            SqlCommand cmd = new SqlCommand(SqlSELECT, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgvKhu.DataSource = dt;
        }

        private void btnThemKhu_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State==ConnectionState.Closed)
                conn.Open();
                SqlCommand cmd = new SqlCommand("themKHUVUICHOI", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAKHU", txbMaKhu.Text);
                cmd.Parameters.AddWithValue("@TENKHU", txbTenKhuVuiChoi.Text);
                cmd.Parameters.AddWithValue("@GIAVENL", int.Parse(txbGiaVe_NL.Text));
                cmd.Parameters.AddWithValue("@GIAVETE", int.Parse(txbGiaVe_TE.Text));
                cmd.ExecuteNonQuery();
                if(conn.State==ConnectionState.Open)
                conn.Close();
                btnXemKhu_Click(sender, e);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgvKhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvKhu.CurrentRow.Index;
            txbMaKhu.Text = dtgvKhu.Rows[i].Cells[0].Value.ToString();
            txbTenKhuVuiChoi.Text = dtgvKhu.Rows[i].Cells[1].Value.ToString();
            txbGiaVe_NL.Text = dtgvKhu.Rows[i].Cells[2].Value.ToString();
            txbGiaVe_TE.Text = dtgvKhu.Rows[i].Cells[3].Value.ToString();
        }
        private void XoaTextbox()
        {
            txbMaKhu.Clear();
            txbTenKhuVuiChoi.Clear();
            txbGiaVe_NL.Clear();
            txbGiaVe_TE.Clear();
            txbMaKhu.Focus();
        }
        private void btnSuaKhu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("CapNhatKhuVuiChoi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MAKHU", txbMaKhu.Text);
                cmd.Parameters.AddWithValue("@TENKHU", txbTenKhuVuiChoi.Text);
                cmd.Parameters.AddWithValue("@GIAVENL", int.Parse(txbGiaVe_NL.Text));
                cmd.Parameters.AddWithValue("@GIAVETE", int.Parse(txbGiaVe_TE.Text));
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                btnXemKhu_Click(sender, e);
                XoaTextbox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKhu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from KHUVUICHOI where MAKHU='"+txbMaKhu.Text+"'", conn);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                btnXemKhu_Click(sender, e);
                XoaTextbox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemKhu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                if (rbtnTheoTen.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAKHU as N'Mã khu',TENKHU as N'Tên khu',GIAVENL as N'Giá vé người lớn',GIAVETE as N'Giá vé trẻ em',DIADIEM as N'Địa điểm' FROM KHUVUICHOI where TENKHU=@TENKHU", conn);
                    cmd.Parameters.AddWithValue("@TENKHU", txbTenKhuVuiChoi.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtgvKhu.DataSource = dt;

                }
                if (rbtnTheoMa.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAKHU as N'Mã khu',TENKHU as N'Tên khu',GIAVENL as N'Giá vé người lớn',GIAVETE as N'Giá vé trẻ em',DIADIEM as N'Địa điểm' FROM KHUVUICHOI where MAKHU=@MAKHU", conn);
                    cmd.Parameters.AddWithValue("@MAKHU", txbMaKhu.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtgvKhu.DataSource = dt;
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }

    }
