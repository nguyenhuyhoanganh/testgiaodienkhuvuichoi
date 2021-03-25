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

namespace Design_Login_Form
{
    public partial class fQuanLyTroChoi : Form
    {
        public fQuanLyTroChoi()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=DESKTOP-7HIL2OS\SQLEXPRESS;Initial Catalog=KHUVUICHOIGIAITRI;Integrated Security=True";

        private void btnXemTroChoi_Click(object sender, EventArgs e)
        {
            load();  
        }
        void load()
        {
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select matc as N'Mã trò chơi', tentc as N'Tên trò chơi', makhu as N'Mã khu'  from trochoi", sqlcon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                dtgvThongTinTroChoi.DataSource = dataTable;
            }
        }

        string matc, tentc, makhu;

        private void btnThemTroChoi_Click(object sender, EventArgs e)
        {
            if (txbMaKhu_TC.Text == "" || txbMaTroChoi.Text == "" || txbTenTroChoi.Text == "")
            {
                MessageBox.Show("Mời nhập đủ các trường thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute themTrochoi N'" + txbMaTroChoi.Text + "', N'" + txbTenTroChoi.Text + "',N'" + txbMaKhu_TC.Text + "'", sqlcon);
                    //sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    command.ExecuteNonQuery();
                }
            load();
        }
        }

        private void btnSuaTroChoi_Click(object sender, EventArgs e)
        {
            if (txbMaKhu_TC.Text == "" || txbMaTroChoi.Text == "" || txbTenTroChoi.Text == "")
            {
                MessageBox.Show("Mời nhập đủ các trường thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute capnhatTrochoi N'" + txbMaTroChoi.Text + "', N'" + txbTenTroChoi.Text + "',N'" + txbMaKhu_TC.Text + "'", sqlcon);
                    //sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    command.ExecuteNonQuery();
                }
                load();
            }
        }

        private void btnXoaTroChoi_Click(object sender, EventArgs e)
        {
            if (txbMaKhu_TC.Text == "" || txbMaTroChoi.Text == "" || txbTenTroChoi.Text == "")
            {
                MessageBox.Show("Mời nhập đủ các trường thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                using (SqlConnection sqlcon = new SqlConnection(ConnectionString.str))
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand("execute xoaTrochoi N'" + txbMaTroChoi.Text + "'", sqlcon);
                    //sqlcon.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
                    command.ExecuteNonQuery();
                }
            load();
        }
        }

        private void btnTimKiemTroChoi_Click(object sender, EventArgs e)
        {
            if (rbtnTheoMa.Checked == false && rbtnTheoTen.Checked == false)
                MessageBox.Show("Chưa chọn điều kiện tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(rbtnTheoTen.Checked==true)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constr))
                    {
                        sqlcon.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("execute tktrochoi N'" + txbTimKiem.Text + "'", sqlcon);
                        DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                         dtgvThongTinTroChoi.DataSource = dataTable;
                    }
                }
                else if(rbtnTheoMa.Checked==true)
                    using (SqlConnection sqlcon = new SqlConnection(constr))
                    {
                        sqlcon.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("execute tkmatrochoi N'" + txbTimKiem.Text + "'", sqlcon);
                        DataTable dataTable = new DataTable();
                        sqlData.Fill(dataTable);
                        dtgvThongTinTroChoi.DataSource = dataTable;
                    }
            }
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txbMatKhau.Text = "";
            if (dtgvThongTinTroChoi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = this.dtgvThongTinTroChoi.Rows[e.RowIndex];
                txbMaTroChoi.Text = row.Cells[0].Value.ToString();
                matc = row.Cells[0].Value.ToString();
                txbTenTroChoi.Text = row.Cells[1].Value.ToString();
                tentc = row.Cells[1].Value.ToString();
                txbMaKhu_TC.Text = row.Cells[2].Value.ToString();
                
                //row.Cells[7].Value.ToString();
            }
        }
    }
}
