using bai1.BUS;
using bai1.DAL.Entities;
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
    public partial class frmRegister : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmRegister()
        {
            InitializeComponent();
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvQuanLySinhVien);
                var listStudents = studentService.GetAll();
                var listFacultys = facultyService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa, giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cbxKhoa.DataSource = listFacultys;
            this.cbxKhoa.DisplayMember = "FacultyName";
            this.cbxKhoa.ValueMember = "FacultyID";
        }
        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.chbChuaDangKyChuyenNganh.Checked)
            {
                Faculty selectedFaculty = cbxKhoa.SelectedItem as Faculty;
                if(selectedFaculty != null)
                {
                    var listMajoi = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                    fillMajorCombobox(listMajoi);
                    var listStudent = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                    BindGrid(listStudent);
                }
            }
            else
            {
                Faculty selectedFaculty = cbxKhoa.SelectedItem as Faculty;
                if( selectedFaculty != null )
                {
                    var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                    fillMajorCombobox(listMajor);
                    if (int.TryParse(cbxKhoa.SelectedValue?.ToString(), out int selectedFacultyID) &&
                        int.TryParse(cbxChuyenNganh.SelectedValue?.ToString(), out int selectMajorID))
                    {
                        var listStudent = studentService.GetAllHasNoMajor(selectedFacultyID, selectMajorID);
                        BindGrid(listStudent);
                    }    
                }
            }
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvQuanLySinhVien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvQuanLySinhVien.Rows.Add();

                dgvQuanLySinhVien.Rows[index].Cells[1].Value = item.StudentID;
                dgvQuanLySinhVien.Rows[index].Cells[2].Value = item.FullName;
                if (item.Faculty != null)
                {
                    dgvQuanLySinhVien.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
                }
                else
                {
                    dgvQuanLySinhVien.Rows[index].Cells[3].Value = "N/A"; // mặc định nếu null -> N/A
                }
                dgvQuanLySinhVien.Rows[index].Cells[4].Value = item.AverageScore.ToString();
                //if (item.MajorID != null)
                    //dgvQuanLySinhVien.Rows[index].Cells[5].Value = item.Major.Name + "";
            }
        }

        private void fillMajorCombobox(List<Major> listMajor)
        {
            this.cbxChuyenNganh.DataSource = listMajor;
            this.cbxChuyenNganh.DisplayMember = "Name";
            this.cbxChuyenNganh.ValueMember = "MajorID";
        }

        private void chbChuaDangKyChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            var listStudent = new List<Student>();
            if (this.chbChuaDangKyChuyenNganh.Checked)
                listStudent = studentService.GetAllHasNoMajor();
            else
                listStudent = studentService.GetAll();
            BindGrid(listStudent);
        }

        private void cbxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!chbChuaDangKyChuyenNganh.Checked)
            {
                if(int.TryParse(cbxKhoa.SelectedValue?.ToString(), out int selectedFacultyID) && 
                    int.TryParse(cbxChuyenNganh.SelectedValue?.ToString(), out int selectedMajorID))
                {
                    var listStudent = studentService.GetAllHasNoMajor(selectedFacultyID, selectedMajorID);
                    BindGrid(listStudent);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvQuanLySinhVien.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Column1"].Value) == true)
                {
                    row.Cells["Column1"].Value = false;
                }
            }
            dgvQuanLySinhVien.Refresh();
            cbxChuyenNganh.SelectedIndex = -1;
            cbxKhoa.SelectedIndex = -1;
        }
        private void DangKyChuyenNganh(string maSinhVien, int maChuyenNganh)
        {
            using (var context = new SinhVienDatabaseContext())
            {
                var sinhVien = context.Students.SingleOrDefault(sv => sv.StudentID == maSinhVien);

                if (sinhVien != null)
                {
                    sinhVien.MajorID = maChuyenNganh;

                    context.SaveChanges();
                }
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var selectedChuyenNganhId = (int)cbxChuyenNganh.SelectedValue;

            foreach (DataGridViewRow row in dgvQuanLySinhVien.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    string maSinhVien = row.Cells[1].Value.ToString();
                    DangKyChuyenNganh(maSinhVien, selectedChuyenNganhId);
                }
            }
            MessageBox.Show("Đăng ký chuyên ngành thành công!");
        }
    }
}