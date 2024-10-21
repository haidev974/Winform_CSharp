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
    public partial class frmNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        private bool themmoi = false;
        public frmNhanVien()
        {
            InitializeComponent();
            lsv_dssv.Columns.Add("Mã nhân viên", 100, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Họ tên", 200, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Ngày sinh", 100, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Địa chỉ", 200, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Điện thoại", 80, HorizontalAlignment.Left);
            lsv_dssv.Columns.Add("Bằng cấp", 100, HorizontalAlignment.Left);
            loadDSNV();
            HienthiBangcap();
            setButton(true);
            setNull();
        }

        //đổ dữ liệu nhân viên xuống listview
        private void loadDSNV()
        {
            lsv_dssv.Items.Clear();
            DataTable dt = nv.LayDSNhanvien();//lấy ds
            //đổ xuống listview
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ListViewItem item = lsv_dssv.Items.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayBangcap();
            cbb_bangCap.DataSource = dt;
            cbb_bangCap.DisplayMember = "TenBangcap";
            cbb_bangCap.ValueMember = "MaBangcap";
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_hoTen.Text == "" || txt_diaChi.Text == "" || txt_dienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            themmoi = true;
            setButton(false);
            txt_hoTen.Focus();
        }

        private void lsv_dssv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                txt_hoTen.Text = lsv_dssv.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime 
                dtp_ngaySinh.Value =DateTime.Parse(lsv_dssv.SelectedItems[0].SubItems[2].Text);
                txt_diaChi.Text = lsv_dssv.SelectedItems[0].SubItems[3].Text;
                txt_dienThoai.Text = lsv_dssv.SelectedItems[0].SubItems[4].Text;
                //Tìm vị trí của Tên bằng cấp trong Combobox 
                cbb_bangCap.SelectedIndex =cbb_bangCap.FindString(lsv_dssv.SelectedItems[0].SubItems[5].Text);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật","Sửa mẫu tin");
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsv_dssv.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa  không ? ", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsv_dssv.SelectedItems[0].SubItems[0].Text);
                    lsv_dssv.Items.RemoveAt(lsv_dssv.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}",dtp_ngaySinh.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver 
            if (themmoi)
            {
                nv.ThemNhanVien(txt_hoTen.Text, ngay, txt_diaChi.Text,txt_dienThoai.Text, cbb_bangCap.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsv_dssv.SelectedItems[0].SubItems[0].Text,txt_hoTen.Text, ngay, txt_diaChi.Text, txt_dienThoai.Text,cbb_bangCap.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            loadDSNV();
            setNull();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiBangcap();
        }
    }
}
