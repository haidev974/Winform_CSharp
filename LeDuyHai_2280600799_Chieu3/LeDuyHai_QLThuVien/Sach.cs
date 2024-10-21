using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDuyHai_QLThuVien
{
    class Sach
    {
        dataBase db;
        public Sach()
        {
            db = new dataBase();
        }
        
        public DataTable LayDSSach()
        {
            string strSQL = "select MaSach, TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap from SACH";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public void XoaSach(string index_nv)
        {
            string sql = "Delete from SACH where MaSach = " + index_nv;
            db.ExecuteNonQuery(sql);
        }

        public void ThemSach(string tenS, string tacgia, string namxb, string nhaxb, string trigia, string ngaynhap)
        {
            string sql = string.Format("Insert Into SACH " +
                "Values(N'{0}', N'{1}', '{2}', N'{3}',{4}, {5})", tenS, tacgia, namxb, nhaxb, trigia, ngaynhap);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatSach(string index_dg, string tenS, string tacgia, string namxb, string nhaxb, string trigia, string ngaynhap)
        {
            string str = string.Format("Update SACH set TenSach = N'{0}', " +
                "TacGia = N'{1}', NamXuatBan = '{2}',NhaXuatBan = N'{3}', " +
                "TriGia = '{4}', NgayNhap = '{5}'" +
                " where MaSach = {6}", tenS, tacgia, namxb, nhaxb, trigia, ngaynhap, index_dg);
            db.ExecuteNonQuery(str);
        }
    }
}
