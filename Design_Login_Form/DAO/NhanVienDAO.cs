using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Login_Form.DAO
{
     public class NhanVienDAO
     {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            } 
            set => instance = value; 
        }

        private NhanVienDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "dangNhap @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, passWord});
            return result.Rows.Count > 0;
        }
     }
}
