using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LeDuyHai_QLThuVien
{
    class DocGia
    {
        dataBase db;
        public DocGia()
        {
            db = new dataBase();
        }

        public DataTable LayDSDocGia()
        {
            string strSQL = "select MaDocGia, HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, TienNo from DOCGIA";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public void XoaDocGia(string index_nv)
        {
            string sql = "Delete from DOCGIA where MaDocGia = " + index_nv;
            db.ExecuteNonQuery(sql);
        }

        public void ThemDocGia(string ten, string ngaysinh, string diachi, string email, string ngaylt, string ngayhh, string tienno)
        {
            string sql = string.Format("Insert Into DOCGIA " +
                "Values(N'{0}', '{1}', N'{2}', '{3}',{4}, {5}, {6})", ten, ngaysinh, diachi, email, ngaylt, ngayhh, tienno);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatDocGia(string index_dg, string ten, string ngaysinh, string diachi, string email, string ngaylt, string ngayhh, string tienno)
        {
            //Chuẩn bị câu lẹnh truy vấn
            string str = string.Format("Update DOCGIA set HoTenDocGia = N'{0}', " +
                "NgaySinh = '{1}', DiaChi = N'{2}',Email = '{3}', " +
                "NgayLapThe = '{4}', NgayHetHan = '{5}',TienNo = '{6}'" +
                " where MaDocGia = {7}", ten, ngaysinh, diachi, email, ngaylt, ngayhh, tienno, index_dg);
            db.ExecuteNonQuery(str);
        }
    }
}