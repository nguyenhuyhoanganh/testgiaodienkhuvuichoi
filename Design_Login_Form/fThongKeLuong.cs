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
    public partial class fThongKeLuong : Form
    {
        public fThongKeLuong()
        {
            InitializeComponent();
        }

        private void btnThongKeLuong_Click(object sender, EventArgs e)
        {
            double tong = 0;
            try
            {
                string que = "Select manv, makhu, tennv, ngaysinh, gioitinh, diachi, luong from Nhanvien";
                dtgvLuong.DataSource = DataProvider.Instance.ExecuteQuery(que);
                for(int i=0;i<dtgvLuong.RowCount; i++)
                {
                    tong = tong + Convert.ToDouble(dtgvLuong.Rows[i].Cells[6].Value);
                }
                string rz= tong.ToString();
                int dem = 0;
                string kq = "";
                for(int i=rz.Length-1;i>=0;i--)
                {
                    dem++;
                    kq = rz[i]+kq;
                    if(dem==3)
                    {
                        kq = " "+kq ;
                        dem = 0;
                    }    
                }
                kq.Reverse();
                txbTongDoanhThu.Text = kq +" 000 vnd";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
