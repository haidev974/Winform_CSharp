using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6.Models;

namespace Lab6
{
    public partial class Form1 : Form
    {
        SachDB_Context db = new SachDB_Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTenSach.Select();
            txtTenSach.Focus();
            List<Sach> sachList = db.Saches.ToList();
            List<LoaiSach> theLoai = db.LoaiSaches.ToList();
            dgvSach.Rows.Clear();
            fillDGVSach(sachList);
            fillCBXTheLoai(theLoai);
            cbxTheLoai.SelectedIndex = -1;
            //this.WindowState = FormWindowState.Maximized;
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.EnableHeadersVisualStyles = false;
            dgview.BackgroundColor = Color.White;
            dgview.GridColor = Color.FromArgb(210, 210, 210);
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 57, 85);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgview.ColumnHeadersHeight = 40;
            dgview.DefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgview.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            dgview.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgview.DefaultCellStyle.Padding = new Padding(8);
            dgview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgview.DefaultCellStyle.SelectionForeColor = Color.White;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 255);
            dgview.RowTemplate.Height = 35;
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.MultiSelect = false;
            dgview.ReadOnly = true;
            dgview.RowHeadersVisible = false;
            dgview.RowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgview.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgview.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgview.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgview.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 185, 255);
            dgview.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgview.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 57, 85);
            dgview.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgview.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void fillCBXTheLoai(List<LoaiSach> theLoai)
        {
            cbxTheLoai.DataSource = theLoai;
            cbxTheLoai.DisplayMember = "TenLoai";
            cbxTheLoai.ValueMember = "MaLoai";
        }

        private void fillDGVSach(List<Sach> sachList)
        {
            setGridViewStyle(dgvSach);
            dgvSach.Rows.Clear();
            foreach (Sach item in sachList)
            {
                int rowNew = dgvSach.Rows.Add();

                dgvSach.Rows[rowNew].Cells[0].Value = item.MaSach;
                dgvSach.Rows[rowNew].Cells[1].Value = item.TenSach;
                dgvSach.Rows[rowNew].Cells[2].Value = item.NamXB;
                dgvSach.Rows[rowNew].Cells[3].Value = item.LoaiSach.TenLoai;
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvSach.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaSach.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenSach.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtNamXB.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbxTheLoai.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }
        private int GetSelectedRow(string sachID)
        {

            for (int i = 0; i < dgvSach.Rows.Count; i++)
            {

                if (dgvSach.Rows[i].Cells[0].Value != null &&
                    dgvSach.Rows[i].Cells[0].Value.ToString() == sachID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvSach.Rows[selectRow].Cells[0].Value = txtMaSach.Text.Trim();
            dgvSach.Rows[selectRow].Cells[1].Value = txtTenSach.Text.Trim();
            dgvSach.Rows[selectRow].Cells[2].Value = int.Parse(txtNamXB.Text).ToString();
            dgvSach.Rows[selectRow].Cells[3].Value = cbxTheLoai.Text.Trim();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text.Trim() == "" || txtNamXB.Text.Trim() == "" || txtTenSach.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaSach.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvSach.Rows.Add();
                    insertUpdata(selectRow);
                    Sach newStudent = new Sach
                    {
                        MaSach = txtMaSach.Text.Trim(),
                        TenSach = txtTenSach.Text.Trim(),
                        NamXB = int.Parse(txtNamXB.Text.Trim()),
                        MaLoai = (int)cbxTheLoai.SelectedValue
                    };

                    db.Saches.Add(newStudent);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có sách này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaSach.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xoá", "THÔNG BÁO");
            }
            else
            {
                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo", MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var sach = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach.Text.Trim());
                    if (sach != null)
                    {
                        db.Saches.Remove(sach);
                        db.SaveChanges(); // Lưu
                    }
                    dgvSach.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaSach.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sách để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow(txtMaSach.Text.Trim());
                insertUpdata(selectRow);
                var sach = db.Saches.FirstOrDefault(s => s.MaSach == txtMaSach.Text.Trim());
                if (sach != null)
                {
                    sach.TenSach = txtMaSach.Text.Trim();
                    sach.NamXB = int.Parse(txtNamXB.Text.Trim());
                    sach.MaLoai = (int)cbxTheLoai.SelectedValue;
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo");
            }
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
            }
            else if (txtMaSach.Text.Length != 6)
            {
                MessageBox.Show("Mã sách phải có đúng 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
            }    
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFind.Text.Trim().ToLower();

            var filteredList = db.Saches
                .Where(s => s.MaSach.ToLower().Contains(searchValue)
                            || s.TenSach.ToLower().Contains(searchValue)
                            || s.NamXB.ToString().Contains(searchValue))
                .ToList();

            fillDGVSach(filteredList);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void txtNamXB_Leave(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            if (txtNamXB.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
            }
            else
            {
                if (int.TryParse(txtNamXB.Text.Trim(), out int namXB))
                {
                    if (namXB > currentYear)
                    {
                        MessageBox.Show($"Năm xuất bản không được vượt quá năm {currentYear}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNamXB.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNamXB.Focus();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            txtMaSach.Text = "";
            txtNamXB.Text = "";
            cbxTheLoai.SelectedIndex = -1;
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSach f = new frmLoaiSach();
            f.ShowDialog();
        }

        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeTheoNam f = new frmThongKeTheoNam();
            f.ShowDialog();
        }
    }
}