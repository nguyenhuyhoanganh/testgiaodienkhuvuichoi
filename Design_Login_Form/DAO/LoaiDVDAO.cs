using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Login_Form.DAO
{
    class LoaiDVDAO
    {
        private static LoaiDVDAO instance;

        public static LoaiDVDAO Instance
        {
            get { if (instance == null) instance = new LoaiDVDAO(); return LoaiDVDAO.instance; }
            private set { LoaiDVDAO.instance = value; }
        }

        private LoaiDVDAO() { }

        public bool InsertLoaiDV(string maloaidv,string tenloaidv)
        {
            string query1 = string.Format("exec THEMLOAIDICHVU '{0}',N'{1}'", maloaidv,tenloaidv);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }

        public bool UpdateLoaiDV(string maloaidv, string tenloaidv)
        {
            string query1 = string.Format("exec suaLOAIDV  '{0}',N'{1}'", maloaidv, tenloaidv);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }

        public bool DeleteLoaiDV(string maloaidv)
        {
            string query1 = string.Format("exec xoaLOAIDV N'{0}' ", maloaidv);
            int result = DataProvider.Instance.ExecuteNonQuery(query1);
            return result > 0;
        }
    }

}
