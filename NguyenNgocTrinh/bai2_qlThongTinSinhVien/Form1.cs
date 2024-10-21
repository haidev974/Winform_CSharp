using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai2_qlThongTinSinhVien.Models;

namespace bai2_qlThongTinSinhVien
{
    public partial class Form1 : Form
    {
        SinhVienDBContext db = new SinhVienDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> studentList = db.Students.ToList();
            List<Faculty> facultieList = db.Faculties.ToList();
            dgvStudent.Rows.Clear();
            fillCBXChuyenNganh(facultieList);
            fillDGVSinhVien(studentList);
            DemSoLuongNamNu();
        }

        private void fillDGVSinhVien(List<Student> studentList)
        {
            dgvStudent.Rows.Clear();
            foreach (Student item in studentList)
            {
                int rowNew = dgvStudent.Rows.Add();

                dgvStudent.Rows[rowNew].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[rowNew].Cells[1].Value = item.FullName;
                dgvStudent.Rows[rowNew].Cells[2].Value = (bool)item.Gender ? "Nữ" : "Nam";
                dgvStudent.Rows[rowNew].Cells[4].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[rowNew].Cells[3].Value = item.AverageScore;
            }
        }

        private void fillCBXChuyenNganh(List<Faculty> facultieList)
        {
            cbxChuyenNganh.DataSource = facultieList;
            cbxChuyenNganh.DisplayMember = "FacultyName";
            cbxChuyenNganh.ValueMember = "FacultyID";
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null && 
                    dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = radioNam.Checked ? "Nam" : "Nữ";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtDTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cbxChuyenNganh.Text;
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    Student newStudent = new Student
                    {
                        StudentID = txtMSSV.Text.Trim(),
                        FullName = txtHoTen.Text.Trim(),
                        Gender = radioNu.Checked,
                        AverageScore = float.Parse(txtDTB.Text.Trim()),
                        FacultyID = (int)cbxChuyenNganh.SelectedValue
                    };

                    db.Students.Add(newStudent);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    var student = db.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text.Trim());
                    if (student != null)
                    {
                        student.FullName = txtHoTen.Text.Trim();
                        student.Gender = radioNu.Checked;
                        student.AverageScore = float.Parse(txtDTB.Text.Trim());
                        student.FacultyID = (int)cbxChuyenNganh.SelectedValue;
                        db.SaveChanges(); // Lưu
                    }
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo");
                }
                DemSoLuongNamNu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("KHông tìm thấy MSSV cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        var student = db.Students.FirstOrDefault(s => s.StudentID == txtMSSV.Text.Trim());
                        if (student != null)
                        {
                            db.Students.Remove(student);
                            db.SaveChanges(); // Lưu
                        }
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK);
                        DemSoLuongNamNu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DemSoLuongNamNu()
        {
            int soNam = 0;
            int soNu = 0;

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[2].Value != null)
                {
                    string genderValue = dgvStudent.Rows[i].Cells[2].Value.ToString();
                    if (genderValue == "Nữ")
                    {
                        soNu++;
                    }
                    else if (genderValue == "Nam")
                    {
                        soNam++;
                    }
                }
            }
            tongnam.Text = soNam.ToString();
            tongnu.Text = soNu.ToString();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMSSV.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtHoTen.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                    {
                        radioNam.Checked = true;
                    }
                    else
                    {
                        radioNu.Checked = true;
                    }
                    txtDTB.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbxChuyenNganh.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void tsbQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmFaculty khoa = new frmFaculty();
            khoa.Owner = this;
            khoa.ShowDialog();
        }

        private void tsbTimKiem_Click(object sender, EventArgs e)
        {
            frmFind tk = new frmFind();
            tk.StartPosition = FormStartPosition.CenterParent;    
            tk.ShowDialog();
        }

        private void tsbThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }
        public void RefreshKhoaList()
        {
            List<Faculty> facultiesList = db.Faculties.ToList();
            fillCBXChuyenNganh(facultiesList);
        }
        public void UpdateSinhVienList()
        {
            fillDGVSinhVien(db.Students.ToList());
        }
    }
}
