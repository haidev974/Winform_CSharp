using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNgocTrinh_QuanLyThuVien
{
    public partial class frmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        public bool themmoi = false;
        public frmNhanVien()
        {
            InitializeComponent();
            listview_ds.Columns.Add("Ma NV", 80, HorizontalAlignment.Left);
            listview_ds.Columns.Add("Ho ten", 200, HorizontalAlignment.Left);
            listview_ds.Columns.Add("Ngay sinh", 100, HorizontalAlignment.Left);
            listview_ds.Columns.Add("Dia chi", 200, HorizontalAlignment.Left);
            listview_ds.Columns.Add("Dien thoai", 80, HorizontalAlignment.Left);
            listview_ds.Columns.Add("Bang cap", 100, HorizontalAlignment.Left);
            nv.LayDSNhanvien();
            HienthiBangcap();
        }
    
        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listview_ds.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayBangcap();
            cbxBangCap.DataSource = dt;
            cbxBangCap.DisplayMember = "TenBangcap";
            cbxBangCap.ValueMember = "MaBangcap";
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiNhanvien();
            HienthiBangcap();
        }
        private void lsvNhanVien_SelectedIndexChanged(object sender,
EventArgs e)
        {
            if (listview_ds.SelectedIndices.Count > 0)
            {
                txtHoTen.Text =
               listview_ds.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtbNgaySinh.Value =
               DateTime.Parse(listview_ds.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text =
               listview_ds.SelectedItems[0].SubItems[3].Text;
                txtDienThoai.Text =
               listview_ds.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox
                cbxBangCap.SelectedIndex =
               cbxBangCap.FindString(listview_ds.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listview_ds.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật",
               "Sửa mẫu tin");
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
            if (listview_ds.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(
                   listview_ds.SelectedItems[0].SubItems[0].Text);
                    listview_ds.Items.RemoveAt(
                   listview_ds.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtbNgaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            if (themmoi)
            {
                nv.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text,
               txtDienThoai.Text, cbxBangCap.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(
               listview_ds.SelectedItems[0].SubItems[0].Text,
               txtHoTen.Text, ngay, txtDiaChi.Text, txtDienThoai.Text,
               cbxBangCap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanvien();
            setNull();
        }

        private void frmNhanVien_Load_1(object sender, EventArgs e)
        {

        }
    }
    }
