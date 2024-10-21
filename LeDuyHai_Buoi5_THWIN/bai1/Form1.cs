using bai1.BUS;
using bai1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private string imageRelativePath;
        private string imageFileName = "C:\\Users\\ADMIN\\source\\repos\\LeDuyHai_Buoi5_THWIN\\bai1\\bin\\Debug\\Images";

        public Form1()
        {
            InitializeComponent();
        }

        private void chbDangKiChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            var listStudent = new List<Student>();
            if (this.chbDangKiChuyenNganh.Checked) listStudent = studentService.GetAllHasNoMajor();
            else listStudent = studentService.GetAll();
            BindGrid(listStudent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvQuanLySinhVien);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cbxKhoa.DataSource = listFacultys;
            this.cbxKhoa.DisplayMember = "FacultyName";
            this.cbxKhoa.ValueMember = "FacultyID";
        }
        private int GetSelectedRow(string mssv)
        {
            for (int i = 0; i < dgvQuanLySinhVien.Rows.Count; i++)
            {
                if (dgvQuanLySinhVien.Rows[i].Cells[0].Value != null &&
                    dgvQuanLySinhVien.Rows[i].Cells[0].Value.ToString() == mssv)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvQuanLySinhVien.Rows[selectedRow].Cells[0].Value = txtMSSV.Text;
            dgvQuanLySinhVien.Rows[selectedRow].Cells[1].Value = txtHoTen.Text;
            dgvQuanLySinhVien.Rows[selectedRow].Cells[3].Value = txtDiemTB.Text;
            dgvQuanLySinhVien.Rows[selectedRow].Cells[2].Value = cbxKhoa.Text;
        }
        //Hàm binding gridView từ list sinh viên                   
        private void BindGrid(List<Student> listStudent)//load co tham so
        {
            dgvQuanLySinhVien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvQuanLySinhVien.Rows.Add();
                dgvQuanLySinhVien.Rows[index].Cells[0].Value = item.StudentID;
                dgvQuanLySinhVien.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvQuanLySinhVien.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvQuanLySinhVien.Rows[index].Cells[3].Value = item.AverageScore + "";

                if (item.MajorID != null)
                    dgvQuanLySinhVien.Rows[index].Cells[4].Value = item.Major.Name + "";
                ShowAvatar(item.Avatar);
            }
        }
        private void LoadData()//load ko tham so
        {
            List<Student> students = studentService.GetAll();
            dgvQuanLySinhVien.Rows.Clear();
            foreach (var student in students)
            {
                int index = dgvQuanLySinhVien.Rows.Add();

                dgvQuanLySinhVien.Rows[index].Cells[0].Value = student.StudentID;
                dgvQuanLySinhVien.Rows[index].Cells[1].Value = student.FullName;
                dgvQuanLySinhVien.Rows[index].Cells[2].Value = student.Faculty?.FacultyName ?? null;
                dgvQuanLySinhVien.Rows[index].Cells[3].Value = student.AverageScore;
                dgvQuanLySinhVien.Rows[index].Cells[4].Value = student.Major?.Name ?? null;
            }
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                ptbSinhVien.Image = null;
            }
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, imageFileName, ImageName);
                ptbSinhVien.Image = Image.FromFile(imagePath);
                ptbSinhVien.Refresh();
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string studentID = txtMSSV.Text;
            string fullName = txtHoTen.Text;
            string averageScoreText = txtDiemTB.Text;
            Faculty selectedFaculty = cbxKhoa.SelectedItem as Faculty; // Lấy khoa từ ComboBox
            string imageName = Path.GetFileName(imageRelativePath); // Lấy tên ảnh từ đường dẫn

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(fullName) || selectedFaculty == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var student = new Student()
            {
                StudentID = studentID,
                FullName = fullName,
                AverageScore = float.Parse(averageScoreText),
                FacultyID = selectedFaculty.FacultyID,
                Avatar = imageName,
            };

            studentService.InsertUpdate(student);
            List<Student> listStudents = studentService.GetAll();
            BindGrid(listStudents);
            Form1_Load(null, null);
            MessageBox.Show("Thêm/Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn MSSV để lưu ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string studentID = txtMSSV.Text;
            string imageFolder = Path.Combine(Application.StartupPath, imageFileName);
            string imagePathJPG = Path.Combine(imageFolder, studentID + ".jpg");
            string imagePathPNG = Path.Combine(imageFolder, studentID + ".png");
            if (ptbSinhVien.Image != null)
            {
                ptbSinhVien.Image.Dispose(); 
                ptbSinhVien.Image = null;
            }
            if (File.Exists(imagePathJPG))
            {
                File.Delete(imagePathJPG);
            }
            else if (File.Exists(imagePathPNG))
            {
                File.Delete(imagePathPNG);
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofd.FileName;
                string extension = Path.GetExtension(imagePath);
                string fileName = studentID + extension;
                ptbSinhVien.Image = Image.FromFile(imagePath);
                if (!Directory.Exists(imageFolder))
                {
                    Directory.CreateDirectory(imageFolder);
                }
                string destinationFilePath = Path.Combine(imageFolder, fileName);
                File.Copy(imagePath, destinationFilePath, true); // Lưu ảnh mới vào thư mục
                imageRelativePath = Path.Combine(imageFileName, fileName);
            }
        }

        private void dgvQuanLySinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvQuanLySinhVien.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow row = dgvQuanLySinhVien.Rows[e.RowIndex];

                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtDiemTB.Text = row.Cells[3].Value.ToString();
                cbxKhoa.Text = row.Cells[2].Value.ToString();

                string studentID = txtMSSV.Text;
                string imageFolder = Path.Combine(Application.StartupPath, imageFileName);
                string imagePathJPG = Path.Combine(imageFolder, studentID + ".jpg");
                string imagePathPNG = Path.Combine(imageFolder, studentID + ".png");

                if (File.Exists(imagePathJPG))
                {
                    ptbSinhVien.Image = Image.FromFile(imagePathJPG);
                }
                else if (File.Exists(imagePathPNG))
                {
                    ptbSinhVien.Image = Image.FromFile(imagePathPNG);
                }
                else
                {
                    ptbSinhVien.Image = null;
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuanLySinhVien.SelectedRows.Count > 0)
            {
                string selectedStudentID = dgvQuanLySinhVien.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Student studentToDelete = studentService.FindById(selectedStudentID);

                        if (studentToDelete != null)
                        {
                            if (!string.IsNullOrEmpty(studentToDelete.Avatar))
                            {
                                string imagePath = Path.Combine(Application.StartupPath, imageFileName, studentToDelete.Avatar);
                                if (File.Exists(imagePath))
                                {
                                    File.Delete(imagePath);
                                }
                            }
                            studentService.DeleteStudent(selectedStudentID);
                            LoadData();
                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi  ra khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}