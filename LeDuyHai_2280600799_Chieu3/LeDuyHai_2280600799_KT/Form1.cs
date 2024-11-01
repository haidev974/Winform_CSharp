using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDuyHai_2280600799_KT.Models;

namespace LeDuyHai_2280600799_KT
{
    public partial class Form1 : Form
    {
        KiemTraDBContext db = new KiemTraDBContext();
        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip emptyMenu = new ContextMenuStrip();

            txtDiem.ContextMenuStrip = emptyMenu;
        }

        private void btnChucNangDanhGia_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaKQ.Text);
            if (selectedRow == -1)
            {
                MessageBox.Show("Không tìm thấy kết quả cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!string.IsNullOrEmpty(txtMaKQ.Text))
            {
                string maDanhgia = CreateMaDanhGia(txtMaKQ.Text.Trim());

                var existingDanhGia = db.Danh_Gia_Cua_Sinh_Vien
                    .FirstOrDefault(dg => dg.Ma_Ket_Qua == txtMaKQ.Text.Trim());

                if (existingDanhGia != null)
                {
                    frmDanhGia danhGia = new frmDanhGia(txtMaKQ.Text, this);
                    danhGia.ShowDialog();
                }
                else
                {
                    Danh_Gia_Cua_Sinh_Vien newDanhGia = new Danh_Gia_Cua_Sinh_Vien
                    {
                        Ma_Danh_Gia = maDanhgia,
                        Ma_Ket_Qua = txtMaKQ.Text.Trim(),
                    };

                    db.Danh_Gia_Cua_Sinh_Vien.Add(newDanhGia);
                    db.SaveChanges();

                    frmDanhGia danhGia = new frmDanhGia(txtMaKQ.Text, this);
                    danhGia.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã kết quả để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
;
        }
        public void LoadKetQuaThi()
        {
            List<Ket_Qua_Thi> ketquaList = db.Ket_Qua_Thi.ToList();
            dgvKetQuaThi.Rows.Clear();
            fillDGVKetQua(ketquaList);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ket_Qua_Thi> ketquaList = db.Ket_Qua_Thi.ToList();
            dgvKetQuaThi.Rows.Clear();
            fillDGVKetQua(ketquaList);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void fillDGVKetQua(List<Ket_Qua_Thi> ketquaList)
        {
            setGridViewStyle(dgvKetQuaThi);
            dgvKetQuaThi.Rows.Clear();
            foreach (var item in ketquaList)
            {
                int newRow = dgvKetQuaThi.Rows.Add();

                dgvKetQuaThi.Rows[newRow].Cells[0].Value = dgvKetQuaThi.Rows.Count;
                dgvKetQuaThi.Rows[newRow].Cells[1].Value = item.Ma_Ket_Qua;
                dgvKetQuaThi.Rows[newRow].Cells[2].Value = item.Bai_Thi.Ma_Bai_Thi;
                dgvKetQuaThi.Rows[newRow].Cells[3].Value = item.Diem;
            }
        }
        private int GetSelectedRow(string ResID)
        {
            for (int i = 0; i < dgvKetQuaThi.Rows.Count; i++)
            {
                if (dgvKetQuaThi.Rows[i].Cells[1].Value != null &&
                    dgvKetQuaThi.Rows[i].Cells[1].Value.ToString() == ResID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvKetQuaThi.Rows[selectedRow].Cells[0].Value = dgvKetQuaThi.Rows.Count;
            dgvKetQuaThi.Rows[selectedRow].Cells[1].Value = txtMaKQ.Text;
            dgvKetQuaThi.Rows[selectedRow].Cells[2].Value = txtMaBT.Text;
            dgvKetQuaThi.Rows[selectedRow].Cells[3].Value = txtDiem.Text;
        }
        private void dgvKetQuaThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaKQ.Enabled = false;
            //txtMaBT.Enabled = false;
            //txtDiem.Enabled = false;
            if (e.RowIndex >= 0)
            {
                if (dgvKetQuaThi.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKQ.Text = dgvKetQuaThi.Rows[e.RowIndex].Cells[1].Value.ToString();
                    btnChucNangDanhGia.Text = "Đánh giá của sinh viên có mã kết quả " + dgvKetQuaThi.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMaBT.Text = dgvKetQuaThi.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiem.Text = dgvKetQuaThi.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
        private string CreateMaDanhGia(string maKetQua)
        {
            if (maKetQua.StartsWith("KQ"))
            {
                string numberPart = maKetQua.Substring(2);
                return "DG" + numberPart;
            }
            return null;
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaKQ.Text.Contains(" ") || txtMaBT.Text.Contains(" "))
                {
                    MessageBox.Show("Mã không được có dấu space!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaKQ.Text) || string.IsNullOrWhiteSpace(txtMaBT.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
                    throw new Exception("Vui lòng nhập đầy đủ thông tin kết quả!");
                int selectedRow = GetSelectedRow(txtMaKQ.Text);
                string maDanhgia = CreateMaDanhGia(txtMaKQ.Text.Trim());

                var baiThi = db.Bai_Thi.FirstOrDefault(bt => bt.Ma_Bai_Thi == txtMaBT.Text.Trim());
                if (baiThi == null)
                {
                    MessageBox.Show("Mã bài thi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (selectedRow == -1)
                {
                    if (txtMaKQ.Text.Trim().Length > 10)
                    {
                        MessageBox.Show("Mã kỳ thi phải nhỏ hơn hoặc bằng 10 ký tự!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    selectedRow = dgvKetQuaThi.Rows.Add();
                    InsertUpdate(selectedRow);

                    Ket_Qua_Thi newKetQua = new Ket_Qua_Thi
                    {
                        Ma_Ket_Qua = txtMaKQ.Text.Trim(),
                        Ma_Bai_Thi = txtMaBT.Text.Trim(),
                        Diem = float.Parse(txtDiem.Text.Trim()),
                    };
                    db.Ket_Qua_Thi.Add(newKetQua);
                    Danh_Gia_Cua_Sinh_Vien newDanhGia = new Danh_Gia_Cua_Sinh_Vien
                    {
                        Ma_Danh_Gia = maDanhgia,
                        Ma_Ket_Qua = txtMaKQ.Text.Trim(),
                    };
                    db.Danh_Gia_Cua_Sinh_Vien.Add(newDanhGia);

                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    var ketqua = db.Ket_Qua_Thi.FirstOrDefault(s => s.Ma_Ket_Qua == txtMaKQ.Text.Trim());
                    if (ketqua != null)
                    {
                        ketqua.Ma_Bai_Thi = txtMaBT.Text.Trim();
                        ketqua.Diem = float.Parse(txtDiem.Text.Trim());
                        db.SaveChanges(); // Lưu
                    }
                    MessageBox.Show("Cập nhật thông tin kết quả thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaKQ.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy kết quả cần xóa.");
                }

                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var ketqua = db.Ket_Qua_Thi.FirstOrDefault(s => s.Ma_Ket_Qua == txtMaKQ.Text.Trim());
                    if (ketqua != null)
                    {
                        var danhGiaList = db.Danh_Gia_Cua_Sinh_Vien.Where(dg => dg.Ma_Ket_Qua == ketqua.Ma_Ket_Qua).ToList();
                        db.Danh_Gia_Cua_Sinh_Vien.RemoveRange(danhGiaList);

                        db.Ket_Qua_Thi.Remove(ketqua);
                        db.SaveChanges();

                        dgvKetQuaThi.Rows.RemoveAt(selectedRow);
                        CapNhatSoThuTu();
                        MessageBox.Show("Xóa kết quả thi thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapNhatSoThuTu()
        {
            for (int i = 0; i < dgvKetQuaThi.Rows.Count; i++)
            {
                dgvKetQuaThi.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox txt = sender as TextBox;

            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {
                string newText = txt.Text.Insert(txt.SelectionStart, e.KeyChar.ToString());

                if (!float.TryParse(newText, out float value) || value > 10)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKQ.Text = "";
            txtMaBT.Text = "";
            txtDiem.Text = "";
            btnChucNangDanhGia.Text = "Đánh giá của sinh viên có mã kết quả";
        }

        private void txtDiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // Ngăn không cho thực hiện thao tác dán
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFind.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dgvKetQuaThi.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                return;
            }

            foreach (DataGridViewRow row in dgvKetQuaThi.Rows)
            {
                bool isMatch = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        isMatch = true;
                        break;
                    }
                }

                if (isMatch)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}