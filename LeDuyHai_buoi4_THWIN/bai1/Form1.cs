using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai1.Models;

namespace bai1
{
    public partial class Form1 : Form
    {
        //khởi tạo đối tượng đại diện cho database
        SinhVienDatabase sv = new SinhVienDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> studentsList = sv.Students.ToList();
            List<Faculty> facultiesList = sv.Faculties.ToList();
            dgvQuanLySinhVien.Rows.Clear();
            fillCBBKhoa(facultiesList);
            fillDgvSinhVien(studentsList);
        }

        private void fillDgvSinhVien(List<Student> students)
        {
            dgvQuanLySinhVien.Rows.Clear();
            foreach (Student student in students)
            {
                int rowNew = dgvQuanLySinhVien.Rows.Add();

                dgvQuanLySinhVien.Rows[rowNew].Cells[0].Value = student.StudentID;
                dgvQuanLySinhVien.Rows[rowNew].Cells[1].Value = student.FullName;
                dgvQuanLySinhVien.Rows[rowNew].Cells[2].Value = student.Faculty.FacultyName;
                dgvQuanLySinhVien.Rows[rowNew].Cells[3].Value = student.AverageScore;
            }
        }

        private void fillCBBKhoa(List<Faculty> facultiesList)
        {
            cmbKhoa.DataSource = facultiesList;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
        }
        private int GetSelectedRow(string studentID)
        {

            for (int i = 0; i < dgvQuanLySinhVien.Rows.Count; i++)
            {
                if (dgvQuanLySinhVien.Rows[i].Cells[0].Value != null && 
                    dgvQuanLySinhVien.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvQuanLySinhVien.Rows[selectRow].Cells[0].Value = txtMssv.Text.Trim();
            dgvQuanLySinhVien.Rows[selectRow].Cells[1].Value = txtHoTen.Text.Trim();
            dgvQuanLySinhVien.Rows[selectRow].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvQuanLySinhVien.Rows[selectRow].Cells[2].Value = cmbKhoa.Text.Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMssv.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDTB.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMssv.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvQuanLySinhVien.Rows.Add();
                    insertUpdata(selectRow);
                    Student newStudent = new Student
                    {
                        StudentID = txtMssv.Text.Trim(),
                        FullName = txtHoTen.Text.Trim(),
                        AverageScore = float.Parse(txtDTB.Text.Trim()),
                        FacultyID = (int)cmbKhoa.SelectedValue
                    };

                    sv.Students.Add(newStudent);
                    sv.SaveChanges();
                    MessageBox.Show("Thêm sinh viên mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có sinh viên này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMssv.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xoá", "THÔNG BÁO");
            }
            else
            {
                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo", MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var student = sv.Students.FirstOrDefault(s => s.StudentID == txtMssv.Text.Trim());
                    if (student != null)
                    {
                        sv.Students.Remove(student);
                        sv.SaveChanges(); // Lưu
                    }
                    dgvQuanLySinhVien.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }

            }
        }

        private void dgvQuanLySinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvQuanLySinhVien.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMssv.Text = dgvQuanLySinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtHoTen.Text = dgvQuanLySinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbKhoa.Text = dgvQuanLySinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDTB.Text = dgvQuanLySinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMssv.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow(txtMssv.Text.Trim());
                insertUpdata(selectRow);
                var student = sv.Students.FirstOrDefault(s => s.StudentID == txtMssv.Text.Trim());
                if (student != null)
                {
                    student.FullName = txtHoTen.Text.Trim();
                    student.AverageScore = float.Parse(txtDTB.Text.Trim());
                    student.FacultyID = (int)cmbKhoa.SelectedValue;
                    sv.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo");
            }    
        }

        private void toolQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frmKhoa = new frmKhoa();
            frmKhoa.Owner = this;
            frmKhoa.ShowDialog();
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {
            frmFind frmFind = new frmFind();
            frmFind.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
        public void RefreshKhoaList()
        {
            List<Faculty> facultiesList = sv.Faculties.ToList();
            fillCBBKhoa(facultiesList);
        }
        public void UpdateSinhVienList()
        {
            fillDgvSinhVien(sv.Students.ToList());
        }
    }
}