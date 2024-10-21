using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_QLThuVien
{
    public partial class frmDocGia : Form
    {
        DocGia dg = new DocGia();
        private bool themmoi = false;
        public frmDocGia()
        {
            InitializeComponent();
            lsvLapTheDocGia.Columns.Add("Mã độc giả", 50, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Họ tên", 200, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Ngày sinh", 100, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Địa chỉ", 200, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Email", 200, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Ngày lập thẻ", 100, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Ngày hết hạn", 100, HorizontalAlignment.Left);
            lsvLapTheDocGia.Columns.Add("Tiền nợ", 100, HorizontalAlignment.Left);
            loadLTDG();
            setButton(true);
            setNull();
        }

        private void loadLTDG()
        {
            lsvLapTheDocGia.Items.Clear();
            DataTable dt = dg.LayDSDocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvLapTheDocGia.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                item.SubItems.Add(dt.Rows[i][7].ToString());
            }
        }

        void setNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtTienNo.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnSua.Enabled = val;
            btnXoa.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
            btnThoat.Enabled = val;
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
        }

        private void lsvLapTheDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvLapTheDocGia.SelectedIndices.Count > 0)
            {
                txtHoTen.Text = lsvLapTheDocGia.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Value = DateTime.Parse(lsvLapTheDocGia.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lsvLapTheDocGia.SelectedItems[0].SubItems[3].Text;
                txtEmail.Text = lsvLapTheDocGia.SelectedItems[0].SubItems[4].Text;
                dtpNgayLapThe.Value = DateTime.Parse(lsvLapTheDocGia.SelectedItems[0].SubItems[5].Text);
                dtpNgayHetHan.Value = DateTime.Parse(lsvLapTheDocGia.SelectedItems[0].SubItems[6].Text);
                txtTienNo.Text = lsvLapTheDocGia.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtTienNo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            themmoi = true;
            setButton(false);
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvLapTheDocGia.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvLapTheDocGia.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa  không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dg.XoaDocGia(lsvLapTheDocGia.SelectedItems[0].SubItems[0].Text);
                    lsvLapTheDocGia.Items.RemoveAt(lsvLapTheDocGia.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngayS = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            string ngaylt = String.Format("{0:MM/dd/yyyy}", dtpNgayLapThe.Value);
            string ngayhh = String.Format("{0:MM/dd/yyyy}", dtpNgayHetHan.Value);
            if (themmoi)
            {
                dg.ThemDocGia(txtHoTen.Text, ngayS, txtDiaChi.Text, txtEmail.Text, ngaylt, ngayhh, txtTienNo.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                dg.CapNhatDocGia(lsvLapTheDocGia.SelectedItems[0].SubItems[0].Text, txtHoTen.Text, ngayS, txtDiaChi.Text, txtEmail.Text, ngaylt, ngayhh, txtTienNo.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            loadLTDG();
            setNull();
        }
    }
}
