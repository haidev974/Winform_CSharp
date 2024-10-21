using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDuyHai_2280600799_KTGK_LTWIN.Models;

namespace LeDuyHai_2280600799_KTGK_LTWIN
{
    public partial class frmSinhVienDanhGia : Form
    {
        ThiTracNghiemDBContext db = new ThiTracNghiemDBContext();
        public frmSinhVienDanhGia(string text)
        {
            InitializeComponent();
        }

        private void frmSinhVienDanhGia_Load(object sender, EventArgs e)
        {
            dtpThoiGianDanhGia.MinDate = new DateTime(1990, 1, 1);
            dtpThoiGianDanhGia.MaxDate = DateTime.Now;

            List<SINH_VIEN_DANH_GIA> danhgiaList = db.SINH_VIEN_DANH_GIA.ToList();
            dgvDanhGia.Rows.Clear();
            fillDGVSinhVienDanhGia(danhgiaList);
        }
        private int GetSelectedRow(string madanhgia)
        {
            for (int i = 0; i < dgvDanhGia.Rows.Count; i++)
            {
                if (dgvDanhGia.Rows[i].Cells[1].Value != null &&
                    dgvDanhGia.Rows[i].Cells[1].Value.ToString() == madanhgia)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvDanhGia.Rows[selectedRow].Cells[0].Value = dgvDanhGia.Rows.Count;
            dgvDanhGia.Rows[selectedRow].Cells[1].Value = txtMaDanhGia.Text;
            dgvDanhGia.Rows[selectedRow].Cells[2].Value = txtMaketQua.Text;
            dgvDanhGia.Rows[selectedRow].Cells[3].Value = txtNoiDung.Text;
            dgvDanhGia.Rows[selectedRow].Cells[4].Value = dtpThoiGianDanhGia.Value;
        }
        private void fillDGVSinhVienDanhGia(List<SINH_VIEN_DANH_GIA> danhgiaList)
        {
            dgvDanhGia.Rows.Clear();
            // Thiết lập font cho DataGridView
            foreach (SINH_VIEN_DANH_GIA item in danhgiaList)
            {
                int rowNew = dgvDanhGia.Rows.Add();

                dgvDanhGia.Rows[rowNew].Cells[0].Value = dgvDanhGia.Rows.Count - 1;
                dgvDanhGia.Rows[rowNew].Cells[1].Value = item.Ma_danh_gia;
                dgvDanhGia.Rows[rowNew].Cells[2].Value = item.Ma_ket_qua;
                dgvDanhGia.Rows[rowNew].Cells[3].Value = item.Noi_dung.ToString();
                dgvDanhGia.Rows[rowNew].Cells[4].Value = item.Thoi_gian_danh_gia;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhGia.Text.Trim() == "" || txtMaketQua.Text.Trim() == "" || txtNoiDung.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaDanhGia.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvDanhGia.Rows.Add();
                    InsertUpdate(selectRow);
                    SINH_VIEN_DANH_GIA newDanhGia = new SINH_VIEN_DANH_GIA
                    {
                        Ma_danh_gia = txtMaDanhGia.Text.Trim(),
                        Ma_ket_qua = txtMaketQua.Text.Trim(),
                        Noi_dung = txtNoiDung.Text.Trim(),
                        Thoi_gian_danh_gia = dtpThoiGianDanhGia.Value,
                    };

                    db.SINH_VIEN_DANH_GIA.Add(newDanhGia);
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

        private void dgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvDanhGia.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaDanhGia.Text = dgvDanhGia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMaketQua.Text = dgvDanhGia.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNoiDung.Text = dgvDanhGia.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpThoiGianDanhGia.Text = dgvDanhGia.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaDanhGia.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow(txtMaDanhGia.Text.Trim());
                InsertUpdate(selectRow);
                var danhgia = db.SINH_VIEN_DANH_GIA.FirstOrDefault(s => s.Ma_danh_gia == txtMaDanhGia.Text.Trim());
                if (danhgia != null)
                {
                    danhgia.Ma_ket_qua = txtMaketQua.Text.Trim();
                    danhgia.Noi_dung = txtNoiDung.Text.Trim();
                    danhgia.Thoi_gian_danh_gia = dtpThoiGianDanhGia.Value;
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaDanhGia.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xoá", "THÔNG BÁO");
            }
            else
            {
                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo", MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var danhgia = db.SINH_VIEN_DANH_GIA.FirstOrDefault(s => s.Ma_danh_gia == txtMaDanhGia.Text.Trim());
                    if (danhgia != null)
                    {
                        db.SINH_VIEN_DANH_GIA.Remove(danhgia);
                        db.SaveChanges(); // Lưu
                    }
                    dgvDanhGia.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void dtpThoiGianDanhGia_Leave(object sender, EventArgs e)
        {
            if (dtpThoiGianDanhGia.Value < dtpThoiGianDanhGia.MinDate || dtpThoiGianDanhGia.Value > dtpThoiGianDanhGia.MaxDate)
            {
                MessageBox.Show("Thời gian đánh giá phải nằm trong khoảng từ 01/01/1990 đến nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Đặt lại giá trị về MinDate nếu không hợp lệ
                dtpThoiGianDanhGia.Value = dtpThoiGianDanhGia.MinDate;
                dtpThoiGianDanhGia.Focus(); // Đặt lại tiêu điểm vào DateTimePicker
            }
        }

        //private void dtpThoiGianDanhGia_ValueChanged(object sender, EventArgs e)
        //{
        //    if (dtpThoiGianDanhGia.Value < dtpThoiGianDanhGia.MinDate || dtpThoiGianDanhGia.Value > dtpThoiGianDanhGia.MaxDate)
        //    {
        //        MessageBox.Show("Thời gian đánh giá phải nằm trong khoảng từ 01/01/1990 đến nay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dtpThoiGianDanhGia.Value = dtpThoiGianDanhGia.MinDate;
        //    }
        //}
    }
}