using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDuyHai_2280600799_KTGK_LTWIN.Models;

namespace LeDuyHai_2280600799_KTGK_LTWIN
{
    public partial class Form1 : Form
    {
        ThiTracNghiemDBContext db = new ThiTracNghiemDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List <KET_QUA> ketquaList = db.KET_QUA.ToList();
            dgvKetQua.Rows.Clear();
            fillDGVKetQua(ketquaList);
        }
        private int GetSelectedRow(string maketqua)
        {
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                if (dgvKetQua.Rows[i].Cells[1].Value != null &&
                    dgvKetQua.Rows[i].Cells[1].Value.ToString() == maketqua)
                {
                    return i;
                }
            }
            return -1;
        }
        private void fillDGVKetQua(List<KET_QUA> ketquaList)
        {
            dgvKetQua.Rows.Clear();
            foreach (KET_QUA item in ketquaList)
            {
                int rowNew = dgvKetQua.Rows.Add();
                dgvKetQua.Rows[rowNew].Cells[0].Value = dgvKetQua.Rows.Count - 1;
                dgvKetQua.Rows[rowNew].Cells[1].Value = item.Ma_ket_qua.Trim();
                dgvKetQua.Rows[rowNew].Cells[2].Value = item.Ma_dap_an_sv.Trim();
                dgvKetQua.Rows[rowNew].Cells[3].Value = item.Diem.Value;
            }
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (dgvKetQua.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKetQua.Text = dgvKetQua.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMaDapAn.Text = dgvKetQua.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiem.Text = dgvKetQua.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void txtDiem_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                string pattern = @"^(10|[1-9](\.\d+)?|0*(\.[1-9]\d*)?)$"; // Biểu thức cho phép số thập phân
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(txtDiem.Text))
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 1 đến 10.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiem.Focus();
                    txtDiem.SelectAll();
                }
            }
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            frmSinhVienDanhGia danhgia = new frmSinhVienDanhGia(txtMaKetQua.Text);
            danhgia.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiem.Text.Trim() == "" || txtMaDapAn.Text.Trim() == "" || txtMaKetQua.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaKetQua.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvKetQua.Rows.Add();
                    insertUpdata(selectRow);
                    KET_QUA newStudent = new KET_QUA
                    {
                        Ma_ket_qua = txtMaKetQua.Text.Trim(),
                        Ma_dap_an_sv = txtMaDapAn.Text.Trim(),
                        Diem = int.Parse(txtDiem.Text.Trim()),
                    };

                    db.KET_QUA.Add(newStudent);
                    db.SaveChanges();
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

        private void insertUpdata(int selectRow)
        {
            int stt = dgvKetQua.Rows.Count - 1;
            dgvKetQua.Rows[selectRow].Cells[0].Value = int.Parse(stt.ToString());
            dgvKetQua.Rows[selectRow].Cells[1].Value = txtMaKetQua.Text.Trim();
            dgvKetQua.Rows[selectRow].Cells[2].Value = txtMaDapAn.Text.Trim();
            dgvKetQua.Rows[selectRow].Cells[3].Value = txtDiem.Text.Trim();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaKetQua.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow(txtMaKetQua.Text.Trim());
                insertUpdata(selectRow);
                var res = db.KET_QUA.FirstOrDefault(s => s.Ma_ket_qua == txtMaKetQua.Text.Trim());
                if (res != null)
                {
                    res.Ma_dap_an_sv = txtMaDapAn.Text.Trim();
                    res.Diem = int.Parse(txtDiem.Text.Trim());
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaKetQua.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xoá", "THÔNG BÁO");
            }
            else
            {
                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo", MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var res = db.KET_QUA.FirstOrDefault(s => s.Ma_ket_qua == txtMaKetQua.Text.Trim());
                    if (res != null)
                    {
                        db.KET_QUA.Remove(res);
                        db.SaveChanges(); // Lưu
                    }
                    dgvKetQua.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }

            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}