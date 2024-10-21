using LeDuyHai_QLThuVien_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_QLThuVien_EF
{
    public partial class Form1 : Form
    {
        static DBContext db = new DBContext();
        NHANVIEN nv = new NHANVIEN();
        private bool themmoi = false;
        List<BANGCAP> bc = db.BANGCAPs.ToList();
        public Form1()
        {
            InitializeComponent();
            lsv_dssv.Columns.Add("Mã nhân viên", 100, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Họ tên", 200, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Ngày sinh", 100, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Địa chỉ", 200, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Điện thoại", 80, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Bằng cấp", 100, HorizontalAlignment.Left);
            loadDSNV();
            HienThiBangCap();
        }

        private void HienThiBangCap()
        {
            cbb_bangCap.DataSource = bc;
            cbb_bangCap.ValueMember = "MaBangCap";
            cbb_bangCap.DisplayMember = "tenBangCap";
        }
        private void loadDSNV()
        {
            List<NHANVIEN>nv = db.NHANVIENs.ToList();
            lsv_dssv.Items.Clear();
            foreach (NHANVIEN n in nv)
            {
                string tenBangCap = db.BANGCAPs.FirstOrDefault(bc =>
                    bc.MaBangCap == n.MaBangCap)?.TenBangCap;
                ListViewItem lvi = lsv_dssv.Items.Add(n.MaNhanVien.ToString());
                lvi.SubItems.Add(n.HoTenNhanVien.ToString());
                lvi.SubItems.Add(n.NgaySinh.ToString());
                lvi.SubItems.Add(n.DiaChi.ToString());
                lvi.SubItems.Add(n.DienThoai.ToString());
                lvi.SubItems.Add(tenBangCap);
            }
        }
        void setNull()
        {
            txt_hoTen.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
        }
        void setButton(bool val)
        {
            btn_them.Enabled = val;
            btn_xoa.Enabled = val;
            btn_sua.Enabled = val;
            btn_thoat.Enabled = val;
            btn_luu.Enabled = !val;
            btn_huy.Enabled = !val;
        }
        private bool checkNull()
        {
            if (txt_hoTen.Text.Trim() == "" || txt_diaChi.Text.Trim() == "" || txt_dienThoai.Text.Trim() == "")
                return true;
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_hoTen.Text == "" || txt_diaChi.Text == "" || txt_dienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            themmoi = true;
            setButton(false);
            txt_hoTen.Focus();
            HienThiBangCap();
        }

        private void lsv_dssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                txt_hoTen.Text = lsv_dssv.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime 
                dtp_ngaySinh.Value = DateTime.Parse(lsv_dssv.SelectedItems[0].SubItems[2].Text);
                txt_diaChi.Text = lsv_dssv.SelectedItems[0].SubItems[3].Text;
                txt_dienThoai.Text = lsv_dssv.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox 
                cbb_bangCap.SelectedIndex = cbb_bangCap.FindString(lsv_dssv.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int employerID = int.Parse(lsv_dssv.SelectedItems[0].SubItems[0].Text);
                    NHANVIEN dbDelete = db.NHANVIENs.FirstOrDefault(p => p.MaNhanVien ==  employerID);
                    if(dbDelete != null)
                    {
                        db.NHANVIENs.Remove(dbDelete);
                        db.SaveChanges();
                        lsv_dssv.Items.RemoveAt(lsv_dssv.SelectedIndices[0]);
                        setNull();
                    }
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(checkNull())
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
            }
            else
            {
                //nhân viên có tuổi phải lớn hơn hoặc bằng 18
                int tuoi = DateTime.Now.Year - dtp_ngaySinh.Value.Year;
                if(tuoi < 18)
                {
                    MessageBox.Show("Tuổi phải lớn hoặc bằng 18", "Thông báo");
                }
                else
                {
                    string hoten = txt_hoTen.Text.Trim();
                    string diachi = txt_diaChi.Text.Trim();
                    string dienthoai = txt_dienThoai.Text.Trim();
                    int bangcap = cbb_bangCap.SelectedIndex + 1016;
                    BANGCAP mabc = bc.FirstOrDefault(b => b.MaBangCap == bangcap);
                    NHANVIEN nv = new NHANVIEN()
                    {
                        HoTenNhanVien = hoten,
                        NgaySinh = dtp_ngaySinh.Value,
                        DiaChi = diachi,
                        DienThoai = dienthoai,
                        BANGCAP = mabc,
                    };
                    db.NHANVIENs.Add(nv);
                    db.SaveChanges();
                    lsv_dssv.Items.Clear();
                    loadDSNV();
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
            }
            setNull();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc sửa không ? ", "Sửa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    int employerID = int.Parse(lsv_dssv.SelectedItems[0].SubItems[0].Text);
                    NHANVIEN dbUpdate = db.NHANVIENs.FirstOrDefault(p => p.MaNhanVien == employerID);
                    if (dbUpdate != null)
                    {
                        dbUpdate.HoTenNhanVien = txt_hoTen.Text.Trim();
                        dbUpdate.DienThoai = txt_dienThoai.Text.Trim();
                        dbUpdate.DiaChi = txt_diaChi.Text.Trim();
                        dbUpdate.NgaySinh = dtp_ngaySinh.Value;
                        int bangcap = cbb_bangCap.SelectedIndex + 1016;
                        BANGCAP mabc = bc.FirstOrDefault(b => b.MaBangCap == bangcap);
                        dbUpdate.BANGCAP = mabc;
                        db.SaveChanges();
                        lsv_dssv.Items.Clear();
                        loadDSNV();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        setNull();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần sửa", "Thông báo");
                    }
                }    
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienThiBangCap();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }
    }
}