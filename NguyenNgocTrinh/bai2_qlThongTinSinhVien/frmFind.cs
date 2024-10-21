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
    public partial class frmFind : Form
    {
        SinhVienDBContext tk = new SinhVienDBContext();
        public frmFind()
        {
            InitializeComponent();
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
            UpdateResultCount(1);
            List<Faculty> facultiesList = tk.Faculties.ToList();
            fillCBBKhoa(facultiesList);
            cmbKhoa.SelectedIndex = -1;

            // Cài đặt thuộc tính autocomplete cho txtMSSV
            txtMSSV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMSSV.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Cài đặt thuộc tính autocomplete cho txtHoTen
            txtHoTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtHoTen.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LoadAutoCompleteData();
        }

        private void LoadAutoCompleteData()
        {
            var mssvSource = new AutoCompleteStringCollection();
            var tenSource = new AutoCompleteStringCollection();

            // Giả sử tk.Students là danh sách sinh viên
            foreach (var student in tk.Students.ToList())
            {
                mssvSource.Add(student.StudentID);
                tenSource.Add(student.FullName);
            }

            txtMSSV.AutoCompleteCustomSource = mssvSource;
            txtHoTen.AutoCompleteCustomSource = tenSource;
        }

        private void fillCBBKhoa(List<Faculty> facultiesList)
        {
            cmbKhoa.DataSource = facultiesList;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
        private void UpdateResultCount(int count)
        {
            count--;
            txtKetQua.Text = count.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string studentID = txtMSSV.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            int? facultyID = cmbKhoa.SelectedValue as int?;

            var results = tk.Students.AsQueryable();

            if (!string.IsNullOrEmpty(studentID))
                results = results.Where(s => s.StudentID.Contains(studentID));

            if (!string.IsNullOrEmpty(fullName))
                results = results.Where(s => s.FullName.Contains(fullName));

            if (facultyID.HasValue)
                results = results.Where(s => s.FacultyID == facultyID.Value);

            if (rdbNam.Checked)
                results = results.Where(s => s.Gender == false);
            else if (rdbNu.Checked)
                results = results.Where(s => s.Gender == true);

            dgvTimKiemSinhVien.Rows.Clear();

            foreach (var student in results.ToList())
            {
                int rowNew = dgvTimKiemSinhVien.Rows.Add();
                dgvTimKiemSinhVien.Rows[rowNew].Cells[0].Value = student.StudentID;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[1].Value = student.FullName;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[2].Value = (bool)student.Gender ? "Nữ" : "Nam";
                dgvTimKiemSinhVien.Rows[rowNew].Cells[3].Value = student.Faculty.FacultyName;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[4].Value = student.AverageScore;
            }
            UpdateResultCount(dgvTimKiemSinhVien.Rows.Count);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cmbKhoa.SelectedIndex = -1;
            dgvTimKiemSinhVien.Rows.Clear();
            UpdateResultCount(0);
        }
    }
}
