using LeDuyHai_2280600799_KT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_2280600799_KT
{
    public partial class frmDanhGia : Form
    {
        KiemTraDBContext db = new KiemTraDBContext();
        private string ResID;
        private Form1 parentForm;
        public frmDanhGia(string ResID, Form1 parentForm)
        {
            InitializeComponent();
            //AddEmptyDanhGia();
            this.ResID = ResID;
            this.parentForm = parentForm;
        }
        private void AddEmptyDanhGia()
        {
            try
            {
                // Kiểm tra xem đã có đánh giá trống hay chưa
                var emptyDanhGia = db.Danh_Gia_Cua_Sinh_Vien
                    .FirstOrDefault(dg => dg.Ma_Ket_Qua == ResID && string.IsNullOrEmpty(dg.Noi_Dung_Danh_Gia));

                // Nếu chưa có đánh giá trống, thêm mới
                if (emptyDanhGia == null)
                {
                    // Tạo mã đánh giá từ mã kết quả
                    string maDanhGia = CreateMaDanhGia(ResID);

                    Danh_Gia_Cua_Sinh_Vien danhGiaMoi = new Danh_Gia_Cua_Sinh_Vien
                    {
                        Ma_Danh_Gia = maDanhGia, // Tạo mã đánh giá
                        Ma_Ket_Qua = ResID,
                        Noi_Dung_Danh_Gia = "" // Nội dung trống
                    };

                    db.Danh_Gia_Cua_Sinh_Vien.Add(danhGiaMoi);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu đánh giá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void frmDanhGia_Load(object sender, EventArgs e)
        {
            lblMaKQ.Text = ResID;
            List<Danh_Gia_Cua_Sinh_Vien> danhGiaList = db.Danh_Gia_Cua_Sinh_Vien.Where(db => db.Ma_Ket_Qua == ResID).ToList();
            dgvDanhGia.Rows.Clear();
            fillDGVDanhGia(danhGiaList);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void fillDGVDanhGia(List<Danh_Gia_Cua_Sinh_Vien> danhGiaList)
        {
            setGridViewStyle(dgvDanhGia);
            dgvDanhGia.Rows.Clear();
            foreach (Danh_Gia_Cua_Sinh_Vien item in danhGiaList)
            {
                int rowNew = dgvDanhGia.Rows.Add();
                dgvDanhGia.Rows[rowNew].Cells[0].Value = item.Ma_Danh_Gia;
                dgvDanhGia.Rows[rowNew].Cells[1].Value = item.Noi_Dung_Danh_Gia;
            }
        }
        private int GetSelectedRow(string danhGiaID)
        {
            for (int i = 0; i < dgvDanhGia.Rows.Count; i++)
            {
                if (dgvDanhGia.Rows[i].Cells[0].Value != null &&
                    dgvDanhGia.Rows[i].Cells[0].Value.ToString() == danhGiaID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvDanhGia.Rows[selectedRow].Cells[0].Value = txtMaDanhGia.Text;
            dgvDanhGia.Rows[selectedRow].Cells[1].Value = rxtNoiDung.Text;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void dgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDanhGia.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhGia.Rows[e.RowIndex];

                txtMaDanhGia.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value != null)
                {
                    rxtNoiDung.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    rxtNoiDung.Text = ""; // Gán giá trị mặc định nếu trống
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaDanhGia.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy đánh giá cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        var danhGia = db.Danh_Gia_Cua_Sinh_Vien.FirstOrDefault(s => s.Ma_Danh_Gia == txtMaDanhGia.Text.Trim());
                        if (danhGia != null)
                        {
                            db.Danh_Gia_Cua_Sinh_Vien.Remove(danhGia);
                            db.SaveChanges(); // Lưu
                        }
                        dgvDanhGia.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa đánh giá thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                txtMaDanhGia.Enabled = true;
                txtMaDanhGia.Text = "";
                rxtNoiDung.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaDanhGia.Text == "" || rxtNoiDung.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo");
                return;
            }    
            int selectedRow = GetSelectedRow(txtMaDanhGia.Text);
            InsertUpdate(selectedRow);
            var danhGia = db.Danh_Gia_Cua_Sinh_Vien.FirstOrDefault(s => s.Ma_Danh_Gia == txtMaDanhGia.Text);
            if (danhGia != null)
            {
                //danhGia.Ma_Danh_Gia = txtMaDanhGia.Text.Trim();
                danhGia.Noi_Dung_Danh_Gia = rxtNoiDung.Text.Trim();
                db.SaveChanges(); // Lưu
                MessageBox.Show("Cập nhật đánh giá thành công!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaDanhGia.Enabled = true;
            txtMaDanhGia.Text = "";
            rxtNoiDung.Text = "";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtFind.Text.Trim();

            if (!string.IsNullOrEmpty(searchValue))
            {
                int cursorPosition = rxtNoiDung.SelectionStart;
                rxtNoiDung.SelectAll();
                rxtNoiDung.SelectionBackColor = Color.White;
                rxtNoiDung.DeselectAll();
                int startIndex = 0;
                while (startIndex < rxtNoiDung.TextLength)
                {
                    int wordStartIndex = rxtNoiDung.Find(searchValue, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        rxtNoiDung.Select(wordStartIndex, searchValue.Length);
                        rxtNoiDung.SelectionBackColor = Color.Yellow;
                        startIndex = wordStartIndex + searchValue.Length;
                    }
                    else
                    {
                        break;
                    }
                }
                rxtNoiDung.SelectionStart = cursorPosition;
                rxtNoiDung.SelectionLength = 0;
                rxtNoiDung.SelectionBackColor = Color.White;
            }
            else
            {
                rxtNoiDung.SelectAll();
                rxtNoiDung.SelectionBackColor = Color.White;
                rxtNoiDung.DeselectAll();
            }
        }
        private string HighlightText(string originalText, string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                return originalText; // Nếu không có từ khóa để tìm kiếm, trả về nội dung gốc
            }
            string highlighted = originalText.Replace(searchValue, $"<highlight>{searchValue}</highlight>");

            return highlighted;
        }

        private void frmDanhGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.LoadKetQuaThi();
        }
    }
}