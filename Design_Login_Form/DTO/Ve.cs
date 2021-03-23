using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Login_Form.DTO
{
    public class Ve
    {
        private string maVe;
        private int soLuongNL;
        private int soLuongTE;
        private string maKhu;
        private string maNV;
        private decimal tongTien;
        private DateTime ngayBan;

        public string MaVe { get => maVe; set => maVe = value; }
        public int SoLuongNL { get => soLuongNL; set => soLuongNL = value; }
        public int SoLuongTE { get => soLuongTE; set => soLuongTE = value; }
        public string MaKhu { get => maKhu; set => maKhu = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }

        public Ve() { }
        public Ve(string maVe, int soLuongNL, int soLuongTE, string maKhu, string maNV, decimal tongTien, DateTime ngayBan)
        {
            this.MaVe = maVe;
            this.SoLuongNL = soLuongNL;
            this.SoLuongTE = soLuongTE;
            this.MaKhu = maKhu;
            this.MaNV = maNV;
            this.TongTien = tongTien;
            this.NgayBan = ngayBan;
        }

        public Ve(DataRow row)
        {
            this.MaVe = row["maVe"].ToString();
            this.SoLuongNL = (int)row["soLuongNL"];
            this.SoLuongTE = (int)row["soLuongTE"];
            this.MaKhu = row["maKhu"].ToString();
            this.MaNV = row["maNV"].ToString();
            this.TongTien = Convert.ToDecimal(row["tongTien"].ToString());
            this.NgayBan = Convert.ToDateTime(row["ngayBan"].ToString());
        }
    }
}
