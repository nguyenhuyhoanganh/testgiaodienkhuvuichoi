using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Login_Form.DAO
{
    public class VeDAO
    {
        private static VeDAO instance;

        public static VeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VeDAO();
                return instance;
            }
            set => instance = value;
        }

        private VeDAO() { }
        
        public DataTable Xem()
        {
            string query = "select MAVE as N'Mã Vé', MAKHU as N'Mã Khu', MANV as N'Mã Nhân Viên', SOLUONGNL as N'Số Người Lớn',SOLUONGTE as N'Số Trẻ Em', NGAYBAN as N'Ngày Bán', TONGTIEN as N'Tổng Tiền'  from VE";
            return DataProvider.Instance.ExecuteQuery(query);
            
        }
    }
}
