using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            offButtom();
            cbbKhoa.SelectedIndex = 0;
            dgvThongTinSV.Rows.Add("111", "Duy Hải", "Nam", 8.5f, "CNTT");
            dgvThongTinSV.Rows.Add("222", "Tuấn Nguyên", "Nam", 5.5f, "CNTT");
            dgvThongTinSV.Rows.Add("333", "Công Dương", "Nam", 6.5f, "QTKD");
            dgvThongTinSV.Rows.Add("444", "Tiến Đạt", "Nam", 7.5f, "CNTT");
            dgvThongTinSV.Rows.Add("555", "Ngọc Trai", "Nam", 8.5f, "CNTT");
            dgvThongTinSV.Rows.Add("666", "Đức Tiến", "Nam", 9.5f, "CNTT");
        }

        //Hàm kiểm tra sinh viên đã có trong danh sách chưa
        //Nếu có thì trà về vị trí trong danh sách
        private int getIndexStudent(string StudentID)
        {
            foreach(DataGridViewRow row in dgvThongTinSV.Rows)
            {
                if (row.Cells[0].Value.ToString() == StudentID)
                    return row.Index;
            }
            return -1;
        }
        //hàm thêm hoặc cập nhật
        //nếu chưa có -> thêm
        //nếu có -> cập nhật thông tin
        private void insertOrUpdate(int index)
        {
            dgvThongTinSV.Rows[index].Cells[0].Value = txtMssv.Text.Trim();
            dgvThongTinSV.Rows[index].Cells[1].Value = txtHoTen.Text.Trim();
            dgvThongTinSV.Rows[index].Cells[2].Value = rdbNam.Checked ? "Nam" : "Nữ";
            dgvThongTinSV.Rows[index].Cells[3].Value = float.Parse(txtDtb.Text.Trim());
            dgvThongTinSV.Rows[index].Cells[4].Value = cbbKhoa.Text.Trim();
        }
        //Hàm kiếm tra đã nhập đủ thông tin chưa
        private bool checkNull()
        {
            if (txtHoTen.Text == "" || txtMssv.Text == "" || txtDtb.Text == "" || cbbKhoa.SelectedIndex == 0 || (rdbNam.Checked == false) || (rdbNu.Checked == false))
                return true;
            return false;
        }
        private void onButtom()
        {
            btnThemSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void offButtom()
        {
            btnThemSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string studentID = txtMssv.Text.Trim();
            int index = getIndexStudent(studentID);
            if (index == -1)
            {
                index = dgvThongTinSV.Rows.Add();
                insertOrUpdate(index);
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtMssv_TextChanged(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                onButtom();
            }
            else
            {
                offButtom();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string studentID = txtMssv.Text.Trim();
            int index = getIndexStudent(studentID);
            if(index == -1)
            {
                MessageBox.Show("Bạn có sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult res = MessageBox.Show("Bạn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void dgvThongTinSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy vị trí mà người dùng click
            int index = dgvThongTinSV.Rows[e.RowIndex].Index;
            //đổ dữ liệu xuống
            txtMssv.Text = dgvThongTinSV.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dgvThongTinSV.Rows[index].Cells[1].Value.ToString();
            string gt = dgvThongTinSV.Rows[index].Cells[2].Value.ToString();
            if(gt == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtDtb.Text = dgvThongTinSV.Rows[index].Cells[3].Value.ToString();
        }
    }
}
