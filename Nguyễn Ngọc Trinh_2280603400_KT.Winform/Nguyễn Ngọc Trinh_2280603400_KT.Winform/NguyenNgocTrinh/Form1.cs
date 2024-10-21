using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenNgocTrinh.Models;

namespace NguyenNgocTrinh
{
    public partial class Form1 : Form
    {
        HoaDonDBContext db = new HoaDonDBContext();
        List<HOA_DON> hoadonList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp_ngaylap.MinDate = new DateTime(2000, 1, 1);
            dtp_ngaylap.MaxDate = DateTime.Now;

            hoadonList = db.HOA_DON.ToList();
            dgvhoadon.Rows.Clear();
            fillDGVHoaDon(hoadonList);
            CapNhatTongTien(hoadonList);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void fillDGVHoaDon(List<HOA_DON> hoadonList)
        {
            setGridViewStyle(dgvhoadon);
            dgvhoadon.Rows.Clear();
            foreach (var item in hoadonList)
            {
                int newRow = dgvhoadon.Rows.Add();

                dgvhoadon.Rows[newRow].Cells[0].Value = dgvhoadon.Rows.Count;
                dgvhoadon.Rows[newRow].Cells[1].Value = item.MA_HOA_DON;
                dgvhoadon.Rows[newRow].Cells[2].Value = item.MA_PHIEU_AN;
                dgvhoadon.Rows[newRow].Cells[3].Value = item.MA_NV;
                //DateTime ngayLap = Convert.ToDateTime(item.NGAY_LAP);
                //dgvhoadon.Rows[newRow].Cells[4].Value = ngayLap.ToString("dd/MM/yyyy");
                dgvhoadon.Rows[newRow].Cells[4].Value = item.NGAY_LAP;

                //var chiTietList = db.CHI_TIET_HOA_DON.Where(ct => ct.MA_HOA_DON == item.MA_HOA_DON).ToList();
                //decimal tongTien = (decimal)chiTietList.Sum(ct => ct.DON_GIA);

                //dgvhoadon.Rows[newRow].Cells[5].Value = tongTien;
            }
            CapNhatTongTien(hoadonList);
        }

        public void CapNhatTongTien(List<HOA_DON> hoadonList)
        {
            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                string maHoaDon = hoadonList[i].MA_HOA_DON;
                var chiTietList = db.CHI_TIET_HOA_DON.Where(ct => ct.MA_HOA_DON == maHoaDon).ToList();

                if (chiTietList.Any())
                {
                    decimal tongTien = (decimal)chiTietList.Sum(ct => ct.DON_GIA);

                    dgvhoadon.Rows[i].Cells[5].Value = tongTien;
                }
                else
                {
                    dgvhoadon.Rows[i].Cells[5].Value = 0;
                }
            }
        }
        private void CapNhatSoThuTu()
        {
            for (int i = 0; i <  dgvhoadon.Rows.Count; i++)
            {
                dgvhoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private int GetSelectedRow(string hoadonID)
        {
            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                if (dgvhoadon.Rows[i].Cells[1].Value != null &&
                    dgvhoadon.Rows[i].Cells[1].Value.ToString() == hoadonID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvhoadon.Rows[selectedRow].Cells[0].Value = dgvhoadon.Rows.Count;
            dgvhoadon.Rows[selectedRow].Cells[1].Value = txtMaHoaDon.Text;
            dgvhoadon.Rows[selectedRow].Cells[2].Value = txtMaPhieuAn.Text;
            dgvhoadon.Rows[selectedRow].Cells[3].Value = txtMaNhanVien.Text;
            dgvhoadon.Rows[selectedRow].Cells[4].Value = dtp_ngaylap.Value;//.ToString("dd/MM/yyyy");
            dgvhoadon.Rows[selectedRow].Cells[5].Value = txtTongtien.Text;
        }

        private void InsertUpdate_THEM(int selectedRow)
        {
            dgvhoadon.Rows[selectedRow].Cells[0].Value = dgvhoadon.Rows.Count;
            dgvhoadon.Rows[selectedRow].Cells[1].Value = txtMaHoaDon.Text;
            dgvhoadon.Rows[selectedRow].Cells[2].Value = txtMaPhieuAn.Text;
            dgvhoadon.Rows[selectedRow].Cells[3].Value = txtMaNhanVien.Text;
            dgvhoadon.Rows[selectedRow].Cells[4].Value = dtp_ngaylap.Value;//.ToString("dd/MM/yyyy");
            dgvhoadon.Rows[selectedRow].Cells[5].Value = 0;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHoaDon.Text == "" || txtMaPhieuAn.Text == "" || txtMaNhanVien.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectedRow = GetSelectedRow(txtMaHoaDon.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvhoadon.Rows.Add();
                    InsertUpdate_THEM(selectedRow);
                    HOA_DON newHoaDon = new HOA_DON
                    {
                        MA_HOA_DON = txtMaHoaDon.Text.Trim(),
                        MA_PHIEU_AN = txtMaPhieuAn.Text.Trim(),
                        MA_NV = txtMaNhanVien.Text.Trim(),
                        NGAY_LAP = dtp_ngaylap.Value,
                        TONG_TIEN =  0,
                    };
                    db.HOA_DON.Add(newHoaDon);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    var hoadon = db.HOA_DON.FirstOrDefault(s => s.MA_HOA_DON == txtMaHoaDon.Text.Trim());
                    if (hoadon != null)
                    {
                        hoadon.MA_PHIEU_AN = txtMaPhieuAn.Text.Trim();
                        hoadon.MA_NV = txtMaNhanVien.Text.Trim();
                        hoadon.NGAY_LAP = dtp_ngaylap.Value;
                        //hoadon.TONG_TIEN = decimal.Parse(txtTongtien.Text.Trim());
                        db.SaveChanges(); // Lưu
                    }
                    MessageBox.Show("Cập nhật thông tin hóa đơn thành công!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaHoaDon.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy hóa đơn cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        var hoadon = db.HOA_DON.FirstOrDefault(s => s.MA_HOA_DON == txtMaHoaDon.Text.Trim());
                        if (hoadon != null)
                        {
                            db.HOA_DON.Remove(hoadon);
                            db.SaveChanges(); // Lưu
                        }
                        dgvhoadon.Rows.RemoveAt(selectedRow);
                        CapNhatSoThuTu();
                        MessageBox.Show("Xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(dgvhoadon.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaHoaDon.Text = dgvhoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
                    btnChiTietHoaDon.Text = "Chi tiết hóa đơn " + dgvhoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMaPhieuAn.Text = dgvhoadon.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMaNhanVien.Text = dgvhoadon.Rows[e.RowIndex].Cells[3].Value.ToString();
                    dtp_ngaylap.Text = dgvhoadon.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtTongtien.Text = dgvhoadon.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaHoaDon.Text);
            if (selectedRow == -1)
            {
                MessageBox.Show("Không tìm thấy hóa đơn cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                Form2 form2 = new Form2(txtMaHoaDon.Text);
                form2.UpdateAllBillsEvent += ReloadBills;
                
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ReloadBills()
        {
            Form1_Load(null, null);
            fillDGVHoaDon(hoadonList);
            CapNhatTongTien(hoadonList);
        }
    }
}