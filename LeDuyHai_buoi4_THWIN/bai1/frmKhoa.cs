using bai1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class frmKhoa : Form
    {
        SinhVienDatabase k = new SinhVienDatabase();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            List<Faculty> facultiesList = k.Faculties.ToList();
            fillDgvKhoa(facultiesList);
        }

        private void fillDgvKhoa(List<Faculty> facultiesList)
        {
            dgvKhoa.Rows.Clear();
            foreach (Faculty item in facultiesList)
            {
                int rowNew = dgvKhoa.Rows.Add();
                dgvKhoa.Rows[rowNew].Cells[0].Value = item.FacultyID;
                dgvKhoa.Rows[rowNew].Cells[1].Value = item.FacultyName;
                dgvKhoa.Rows[rowNew].Cells[2].Value = item.TotalProfessor ?? 0;
            }
        }
        private int GetSelectedRow(string facultyID)
        {

            for (int i = 0; i < dgvKhoa.Rows.Count; i++)
            {
                if (dgvKhoa.Rows[i].Cells[0].Value != null &&
                            dgvKhoa.Rows[i].Cells[0].Value.ToString() == facultyID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvKhoa.Rows[selectRow].Cells[0].Value = txtMaKhoa.Text.Trim();
            dgvKhoa.Rows[selectRow].Cells[1].Value = txtTenKhoa.Text.Trim();
            dgvKhoa.Rows[selectRow].Cells[2].Value = int.Parse(txtTongGS.Text).ToString();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvKhoa.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTongGS.Text = dgvKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaKhoa.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy khoa cần xoá", "THÔNG BÁO");
                return;
            }

            int facultyID;
            if (!int.TryParse(txtMaKhoa.Text.Trim(), out facultyID))
            {
                MessageBox.Show("Mã khoa không hợp lệ.", "Thông báo");
                return;
            }

            // Kiểm tra xem có sinh viên thuộc khoa không
            var studentsInFaculty = k.Students.Where(s => s.FacultyID == facultyID).ToList();
            if (studentsInFaculty.Any())
            {
                string studentList = string.Join(", ", studentsInFaculty.Select(s => s.FullName));
                DialogResult status = MessageBox.Show($"Đang có sinh viên thuộc khoa {txtTenKhoa.Text}. Nếu xóa, sẽ xóa các sinh viên thuộc khoa này: {studentList}. Bạn có muốn xóa không?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (status == DialogResult.No)
                    return;

                // Nếu đồng ý, xóa sinh viên
                foreach (var student in studentsInFaculty)
                {
                    k.Students.Remove(student);
                }
            }

            // Xóa khoa
            var faculty = k.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);
            if (faculty != null)
            {
                k.Faculties.Remove(faculty);
                k.SaveChanges(); // Lưu thay đổi vào database
                dgvKhoa.Rows.RemoveAt(row);
                MessageBox.Show("Xoá thông tin khoa thành công.");
                if (Owner is Form1 form1)
                {
                    form1.UpdateSinhVienList();
                }
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text) || string.IsNullOrWhiteSpace(txtTongGS.Text))
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int facultyID;
                if (!int.TryParse(txtMaKhoa.Text.Trim(), out facultyID))
                    throw new Exception("Mã khoa không hợp lệ.");

                var existingFaculty = k.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                if (existingFaculty == null) // Nếu không tìm thấy khoa, thêm mới
                {
                    Faculty newFaculty = new Faculty
                    {
                        FacultyID = facultyID,
                        FacultyName = txtTenKhoa.Text.Trim(),
                        TotalProfessor = int.Parse(txtTongGS.Text.Trim()),
                    };

                    k.Faculties.Add(newFaculty);
                    k.SaveChanges();
                    MessageBox.Show("Thêm khoa mới thành công!", "Thông báo");
                }
                else // Nếu tìm thấy khoa, cập nhật thông tin
                {
                    existingFaculty.FacultyName = txtTenKhoa.Text.Trim();
                    existingFaculty.TotalProfessor = int.Parse(txtTongGS.Text.Trim());

                    k.SaveChanges(); // Lưu thay đổi vào database
                    MessageBox.Show("Cập nhật thông tin khoa thành công!", "Thông báo");
                }

                // Cập nhật lại DataGridView sau khi thêm/sửa
                List<Faculty> facultiesList = k.Faculties.ToList();
                fillDgvKhoa(facultiesList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner is Form1 form1)
            {
                form1.RefreshKhoaList();
            }
        }
    }
}