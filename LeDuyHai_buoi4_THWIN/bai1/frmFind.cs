using bai1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class frmFind : Form
    {
        SinhVienDatabase sv = new SinhVienDatabase();
        public frmFind()
        {
            InitializeComponent();
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
            UpdateResultCount(1);
            List<Faculty> facultiesList = sv.Faculties.ToList();
            fillCBBKhoa(facultiesList);
            cmbKhoa.SelectedIndex = -1;
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

            var results = sv.Students.AsQueryable();

            if (!string.IsNullOrEmpty(studentID))
                results = results.Where(s => s.StudentID.Contains(studentID));

            if (!string.IsNullOrEmpty(fullName))
                results = results.Where(s => s.FullName.Contains(fullName));

            if (facultyID.HasValue)
                results = results.Where(s => s.FacultyID == facultyID.Value);

            dgvTimKiemSinhVien.Rows.Clear();

            foreach (var student in results.ToList())
            {
                int rowNew = dgvTimKiemSinhVien.Rows.Add();
                dgvTimKiemSinhVien.Rows[rowNew].Cells[0].Value = student.StudentID;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[1].Value = student.FullName;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[2].Value = student.Faculty.FacultyName;
                dgvTimKiemSinhVien.Rows[rowNew].Cells[3].Value = student.AverageScore;
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