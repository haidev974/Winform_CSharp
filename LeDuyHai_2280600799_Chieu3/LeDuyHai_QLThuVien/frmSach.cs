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
    public partial class frmSach : Form
    {
        Sach s = new Sach();
        private bool themmoi = false;
        public frmSach()
        {
            InitializeComponent();
            lsvQuanLySach.Columns.Add("Mã sách", 50, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Tên sách", 200, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Tác giả", 100, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Năm xuất bản", 200, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Nhà xuất bản", 200, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Trị giá", 100, HorizontalAlignment.Left);
            lsvQuanLySach.Columns.Add("Ngày nhập", 100, HorizontalAlignment.Left);
            loadLTDG();
            setButton(true);
            setNull();
        }
        private void loadLTDG()
        {
            lsvQuanLySach.Items.Clear();
            DataTable dt = s.LayDSSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = lsvQuanLySach.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }

        void setNull()
        {
            txtTenSach.Text = "";
            txtTriGia.Text = "";
            txtTacGia.Text = "";
            txtNhaXuatban.Text = "";
            txtNamXuatBan.Text = "";
        }
        void setButton(bool val)
        {
            btn_them.Enabled = val;
            btn_sua.Enabled = val;
            btn_luu.Enabled = !val;
            btn_xoa.Enabled = val;
            btn_huy.Enabled = !val;
            btn_Thoat.Enabled = val;
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtTacGia.Text == "" || txtNhaXuatban.Text == "" || txtNamXuatBan.Text == "" || txtTriGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            themmoi = true;
            setButton(false);
            txtTenSach.Focus();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngaynhap = String.Format("{0:MM/dd/yyyy}", dtpNgayNhap.Value);
            if (themmoi)
            {
                s.ThemSach(txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatban.Text, txtTriGia.Text, ngaynhap);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                s.CapNhatSach(lsvQuanLySach.SelectedItems[0].SubItems[0].Text, txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatban.Text, txtTriGia.Text, ngaynhap);
                MessageBox.Show("Cập nhật thành công");
            }
            loadLTDG();
            setNull();
            setButton(true);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsvQuanLySach.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa  không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    s.XoaSach(lsvQuanLySach.SelectedItems[0].SubItems[0].Text);
                    lsvQuanLySach.Items.RemoveAt(lsvQuanLySach.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsvQuanLySach.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void lsvQuanLySach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvQuanLySach.SelectedIndices.Count > 0)
            {
                txtTenSach.Text = lsvQuanLySach.SelectedItems[0].SubItems[1].Text;
                txtTacGia.Text = lsvQuanLySach.SelectedItems[0].SubItems[2].Text;
                txtNamXuatBan.Text = lsvQuanLySach.SelectedItems[0].SubItems[3].Text;
                txtNhaXuatban.Text = lsvQuanLySach.SelectedItems[0].SubItems[4].Text;
                txtTriGia.Text = lsvQuanLySach.SelectedItems[0].SubItems[5].Text;
                dtpNgayNhap.Value = DateTime.Parse(lsvQuanLySach.SelectedItems[0].SubItems[6].Text);
            }
        }
    }
}
