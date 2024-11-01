using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhieuAnCantin.Models;

namespace PhieuAnCantin
{
    public partial class frmKhuyenMai : Form
    {
        DBContext db = new DBContext();
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.Rows.Clear();
            List<KHUYEN_MAI> khuyenMaiList = db.KHUYEN_MAI.ToList();
            fillDGVKhuyenMai(khuyenMaiList);
            setGridViewStyle(dgvKhuyenMai);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.ReadOnly = true;
        }
        private void fillDGVKhuyenMai(List<KHUYEN_MAI> khuyenMaiList)
        {
            dgvKhuyenMai.Rows.Clear();
            foreach (var item in khuyenMaiList)
            {
                int newRow = dgvKhuyenMai.Rows.Add();

                dgvKhuyenMai.Rows[newRow].Cells[0].Value = dgvKhuyenMai.Rows.Count;
                dgvKhuyenMai.Rows[newRow].Cells[1].Value = item.MA_KHUYEN_MAI.Trim();
                dgvKhuyenMai.Rows[newRow].Cells[2].Value = item.TEN_KHUYEN_MAI;
                dgvKhuyenMai.Rows[newRow].Cells[3].Value = item.PHAN_TRAM;
                dgvKhuyenMai.Rows[newRow].Cells[4].Value = item.NGAY_BAT_DAU;
                dgvKhuyenMai.Rows[newRow].Cells[5].Value = item.NGAY_KET_THUC;
            }
        }
        private int GetSelectedRow(string khuyenMaiID)
        {

            for (int i = 0; i < dgvKhuyenMai.Rows.Count; i++)
            {
                if (dgvKhuyenMai.Rows[i].Cells[1].Value != null &&
                    dgvKhuyenMai.Rows[i].Cells[1].Value.ToString() == khuyenMaiID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvKhuyenMai.Rows[selectRow].Cells[0].Value = dgvKhuyenMai.Rows.Count;
            dgvKhuyenMai.Rows[selectRow].Cells[1].Value = txtMaKhuyenMai.Text.Trim();
            dgvKhuyenMai.Rows[selectRow].Cells[2].Value = txtTenKhuyenMai.Text.Trim();
            dgvKhuyenMai.Rows[selectRow].Cells[3].Value = txtPhanTram.Text.Trim();
            dgvKhuyenMai.Rows[selectRow].Cells[4].Value = dtpNgayBatDau.Value;
            dgvKhuyenMai.Rows[selectRow].Cells[5].Value = dtpNgayKetThuc.Value;
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvKhuyenMai.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaKhuyenMai.Text = dgvKhuyenMai.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTenKhuyenMai.Text = dgvKhuyenMai.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtPhanTram.Text = dgvKhuyenMai.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtpNgayBatDau.Text = dgvKhuyenMai.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtpNgayKetThuc.Text = dgvKhuyenMai.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhuyenMai.Text.Trim() == "" || txtTenKhuyenMai.Text.Trim() == "" || txtPhanTram.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow(txtMaKhuyenMai.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvKhuyenMai.Rows.Add();
                    insertUpdata(selectRow);
                    KHUYEN_MAI newKM = new KHUYEN_MAI
                    {
                        MA_KHUYEN_MAI = txtMaKhuyenMai.Text.Trim(),
                        TEN_KHUYEN_MAI = txtTenKhuyenMai.Text.Trim(),
                        PHAN_TRAM = int.Parse(txtPhanTram.Text.Trim()),
                        NGAY_BAT_DAU = dtpNgayBatDau.Value,
                        NGAY_KET_THUC = dtpNgayKetThuc.Value,
                    };

                    db.KHUYEN_MAI.Add(newKM);
                    db.SaveChanges();
                    MessageBox.Show("Thêm khuyến mãi mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có chương trình khuyến mãi này này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaKhuyenMai.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy mã khuyến mãi cần xoá", "THÔNG BÁO");
            }
            else
            {
                DialogResult status = MessageBox.Show("Bạn đồng ý xoá không", "Thông báo", MessageBoxButtons.OKCancel);
                if (status == DialogResult.OK)
                {
                    var khuyenMai = db.KHUYEN_MAI.FirstOrDefault(s => s.MA_KHUYEN_MAI == txtMaKhuyenMai.Text.Trim());
                    if (khuyenMai != null)
                    {
                        db.KHUYEN_MAI.Remove(khuyenMai);
                        db.SaveChanges(); // Lưu
                    }
                    dgvKhuyenMai.Rows.RemoveAt(row);
                    MessageBox.Show("Xoá thông tin thành công.");
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow(txtMaKhuyenMai.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy khuyến mãi để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow(txtMaKhuyenMai.Text.Trim());
                insertUpdata(selectRow);
                var khuyenMai = db.KHUYEN_MAI.FirstOrDefault(s => s.MA_KHUYEN_MAI == txtMaKhuyenMai.Text.Trim());
                if (khuyenMai != null)
                {
                    khuyenMai.TEN_KHUYEN_MAI = txtTenKhuyenMai.Text.Trim();
                    khuyenMai.PHAN_TRAM = int.Parse(txtPhanTram.Text.Trim());
                    khuyenMai.NGAY_BAT_DAU = dtpNgayBatDau.Value;
                    khuyenMai.NGAY_KET_THUC = dtpNgayKetThuc.Value;
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trở về?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
    }
}
