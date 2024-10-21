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
    public partial class Form2 : Form
    {
        HoaDonDBContext ct = new HoaDonDBContext();
        private string maHoaDon;

        public Form2(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<CHI_TIET_HOA_DON> chitietList = ct.CHI_TIET_HOA_DON.Where(ct => ct.MA_HOA_DON == maHoaDon).ToList();
            List<HANG_HOA> hanghoaList = ct.HANG_HOA.ToList();
            dgv_chitiethoadon.Rows.Clear();
            fillCBXHangHoa(hanghoaList);
            fillDGVChiTietHoaDon(chitietList);
            lbl_mahoadon.Text = maHoaDon;
            UpdateTotalAmount();
            cbx_TenHang.SelectedIndex = -1;
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void fillDGVChiTietHoaDon(List<CHI_TIET_HOA_DON> chitietList)
        {
            setGridViewStyle(dgv_chitiethoadon);
            dgv_chitiethoadon.Rows.Clear();
            foreach (CHI_TIET_HOA_DON item in chitietList)
            {
                int rowNew = dgv_chitiethoadon.Rows.Add();
                dgv_chitiethoadon.Rows[rowNew].Cells[0].Value = dgv_chitiethoadon.Rows.Count;
                dgv_chitiethoadon.Rows[rowNew].Cells[1].Value = item.MA_HANG;
                dgv_chitiethoadon.Rows[rowNew].Cells[2].Value = item.SO_LUONG;
                dgv_chitiethoadon.Rows[rowNew].Cells[3].Value = item.DON_GIA;
            }
        }

        private void fillCBXHangHoa(List<HANG_HOA> hanghoaList)
        {
            cbx_TenHang.DataSource = hanghoaList;
            cbx_TenHang.DisplayMember = "TEN_HANG";
            cbx_TenHang.ValueMember = "MA_HANG";
        }
        private int GetSelectedRow(string HangHoaID)
        {
            for (int i = 0; i < dgv_chitiethoadon.Rows.Count; i++)
            {
                if (dgv_chitiethoadon.Rows[i].Cells[1].Value != null &&
                    dgv_chitiethoadon.Rows[i].Cells[1].Value.ToString() == HangHoaID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgv_chitiethoadon.Rows[selectedRow].Cells[0].Value = dgv_chitiethoadon.Rows.Count;
            dgv_chitiethoadon.Rows[selectedRow].Cells[1].Value = txtMaHang.Text;
            dgv_chitiethoadon.Rows[selectedRow].Cells[2].Value = txt_SL.Text;
            dgv_chitiethoadon.Rows[selectedRow].Cells[3].Value = txt_DonGia.Text;
        }

        private void btn_ThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHang.Text == "" || txt_DonGia.Text == "" || txt_SL.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin chi tiết hóa đơn!");

                int selectedRow = GetSelectedRow(txtMaHang.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgv_chitiethoadon.Rows.Add();
                    InsertUpdate(selectedRow);
                    CHI_TIET_HOA_DON newChiTiet = new CHI_TIET_HOA_DON
                    {
                        MA_HOA_DON = maHoaDon, // Thêm mã hóa đơn từ Form1
                        MA_HANG = cbx_TenHang.SelectedValue.ToString(),
                        SO_LUONG = int.Parse(txt_SL.Text.Trim()),
                        DON_GIA = decimal.Parse(txt_DonGia.Text.Trim())
                    };
                    ct.CHI_TIET_HOA_DON.Add(newChiTiet);
                    ct.SaveChanges();
                    UpdateTotalAmount();
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    var chitiet = ct.CHI_TIET_HOA_DON.FirstOrDefault(s => s.MA_HANG == txtMaHang.Text && s.MA_HOA_DON == maHoaDon);
                    if (chitiet != null)
                    {
                        //chitiet.MA_HANG = maHoaDon;
                        chitiet.SO_LUONG = int.Parse(txt_SL.Text.Trim());
                        chitiet.DON_GIA = decimal.Parse(txt_DonGia.Text.Trim());
                        ct.SaveChanges(); // Lưu
                        UpdateAllBillsEvent?.Invoke();
                        UpdateTotalAmount();
                        MessageBox.Show("Cập nhật thông tin chi tiết hóa đơn thành công!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dgv_chitiethoadon.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    //totalAmount += Convert.ToDecimal(row.Cells[3].Value);
                    totalAmount += decimal.Parse(row.Cells[3].Value.ToString());
                }
            }
            lblTongTien.Text = totalAmount.ToString("C");
        }

        private void cbx_TenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_TenHang.SelectedValue != null && cbx_TenHang.SelectedValue is string)
            {
                txtMaHang.Text = cbx_TenHang.SelectedValue.ToString(); // Chỉ gán mã hàng nếu giá trị hợp lệ
                var selectedHangHoa = cbx_TenHang.SelectedItem as HANG_HOA;
                if (selectedHangHoa != null)
                {
                    // Hiển thị giá hàng hóa ra txtGia
                    txtGia.Text = selectedHangHoa.GIA.ToString();
                }
                CalculateDonGia();
            }
        }

        private void txt_SL_TextChanged(object sender, EventArgs e)
        {
            CalculateDonGia();
        }

        private void CalculateDonGia()
        {
            if (!string.IsNullOrEmpty(txt_SL.Text) && !string.IsNullOrEmpty(txtGia.Text))
            {
                if (decimal.TryParse(txtGia.Text, out decimal gia) && int.TryParse(txt_SL.Text, out int soLuong))
                {
                    decimal donGia = soLuong * gia;

                    txt_DonGia.Text = donGia.ToString();
                }
            }
        }

        private void dgv_chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_chitiethoadon.Rows[e.RowIndex];

                txtMaHang.Text = row.Cells[1].Value.ToString();
                txt_SL.Text = row.Cells[2].Value.ToString();
                txt_DonGia.Text = row.Cells[3].Value.ToString();
                var selectedHangHoa = ct.HANG_HOA.FirstOrDefault(h => h.MA_HANG == txtMaHang.Text);
                if (selectedHangHoa != null)
                {
                    cbx_TenHang.Text = selectedHangHoa.TEN_HANG;
                    txtGia.Text = selectedHangHoa.GIA.ToString();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaHang.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy hóa đơn cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        var chitietHD = ct.CHI_TIET_HOA_DON.FirstOrDefault(s => s.MA_HANG == txtMaHang.Text.Trim());
                        if (chitietHD != null)
                        {
                            ct.CHI_TIET_HOA_DON.Remove(chitietHD);
                            ct.SaveChanges(); // Lưu
                        }
                        dgv_chitiethoadon.Rows.RemoveAt(selectedRow);
                        UpdateTotalAmount();
                        MessageBox.Show("Xóa hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CapNhatSoThuTu();
        }
        private void CapNhatSoThuTu()
        {
            for (int i = 0; i < dgv_chitiethoadon.Rows.Count; i++)
            {
                dgv_chitiethoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            UpdateAllBillsEvent?.Invoke();
            this.Close();
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '0' && txt_SL.Text.Length == 0)
            {
                e.Handled = true;
            }
        }
        public delegate void UpdateAllBillsHandler();
        public event UpdateAllBillsHandler UpdateAllBillsEvent;
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateAllBillsEvent?.Invoke();
        }
    }
}