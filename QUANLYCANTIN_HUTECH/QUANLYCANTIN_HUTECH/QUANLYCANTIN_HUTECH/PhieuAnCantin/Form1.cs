using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhieuAnCantin.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PhieuAnCantin
{
    public partial class Form1 : Form
    {
        DBContext db = new DBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvPhieuAn);
            setGridViewStyle(dgvCTPhieuAn);
            dgvPhieuAn.Rows.Clear();
            dgvCTPhieuAn.Rows.Clear();

            List<PHIEU_AN> phieuAnList = db.PHIEU_AN.ToList();
            fillDGVPhieuAn(phieuAnList);

            List<MAT_HANG> matHangList = db.MAT_HANG.ToList();
            fillCBXMatHang(matHangList);

            LoadKhuyenMaiList();

            List<NHAN_VIEN> nhanVienList = db.NHAN_VIEN.ToList();
            fillCBXNhanVien(nhanVienList);

            List<KHACH_HANG> khachHangList = db.KHACH_HANG.ToList();
            fillCBXKhanhHang(khachHangList);

            List<PHIEU_THONG_KE> thongKeList = db.PHIEU_THONG_KE.ToList();
            fillCBXThongKe(thongKeList);

            dtpNgayLap.Value = DateTime.Now;
            cbx_tenhang.SelectedIndex = -1;
            txt_mahang.Text = "";
            txtMaKhuyenMai.Text = "";
            txtGiaHang.Text = "0";
            lbl_tongphieuan.Text = "0";
            lblDVT.Text = "";

            anBanHang(false);
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
        
        #region -> "CHUC_NANG"
        void anBanHang(bool an)
        {
            panel3.Visible = an;
            panel8.Visible = an;
            panel9.Visible = an;
            panel5.Visible = an;
            panel4.Visible = an;
            panel7.Visible = an;
            panel22.Visible = an;
            dgvCTPhieuAn.Visible = an;
            dgvPhieuAn.Visible = an;
            btnHuyPhieuAn.Visible = an;
            btnThemPhieuAn.Visible = an;
            btnSuaPhieuAn.Visible = an;
        }
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            if (btn_banhang.BackColor == Color.Pink)
            {
                anBanHang(false);
                btn_banhang.BackColor = Color.White;
            }
            else
            {
                anBanHang(true);
                btn_banhang.BackColor = Color.Pink;
            }
        }
        #endregion

        #region -> "FILL_CBX"
        private void fillCBXThongKe(List<PHIEU_THONG_KE> thongKeList)
        {
            cbxMaThongKe.DataSource = thongKeList;
            cbxMaThongKe.DisplayMember = "MA_THONG_KE";
            cbxMaThongKe.ValueMember = "MA_THONG_KE";
        }

        private void fillCBXKhanhHang(List<KHACH_HANG> khachHangList)
        {
            cbxTenKH.DataSource = khachHangList;
            cbxTenKH.DisplayMember = "HO_TEN_KH";
            cbxTenKH.ValueMember = "MA_KH";
        }

        private void fillCBXNhanVien(List<NHAN_VIEN> nhanVienList)
        {
            cbxTenNhanVien.DataSource = nhanVienList;
            cbxTenNhanVien.DisplayMember = "HO_VA_TEN_NV";
            cbxTenNhanVien.ValueMember = "MA_NV";
        }

        private void fillCBXKhuyenMai(List<KHUYEN_MAI> khuyenMaiList)
        {
            cbxTenKhuyenMai.DataSource = khuyenMaiList;
            cbxTenKhuyenMai.DisplayMember = "TEN_KHUYEN_MAI";
            cbxTenKhuyenMai.ValueMember = "MA_KHUYEN_MAI";
        }

        private void fillCBXMatHang(List<MAT_HANG> matHangList)
        {
            cbx_tenhang.DataSource = matHangList;
            cbx_tenhang.DisplayMember = "TEN_HANG";
            cbx_tenhang.ValueMember = "MA_HANG";
        }
        #endregion

        #region -> "CBX_SelectedIndexChanged"
        private void cbx_tenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_tenhang.SelectedItem != null)
            {
                MAT_HANG selectedMatHang = (MAT_HANG)cbx_tenhang.SelectedItem;
                txt_mahang.Text = selectedMatHang.MA_HANG.Trim();
                txtGiaHang.Text = selectedMatHang.GIA_HANG.Value.ToString();
                lblDVT.Text = selectedMatHang.DON_VI_TINH;
                txtTongTien.Text = TongTien();
            }
        }

        private void cbxTenKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenKhuyenMai.SelectedItem != null)
            {
                KHUYEN_MAI selectedKhuyenMai = (KHUYEN_MAI)cbxTenKhuyenMai.SelectedItem;
                txtMaKhuyenMai.Text = selectedKhuyenMai.MA_KHUYEN_MAI.Trim();
                txtPhanTram.Text = selectedKhuyenMai.PHAN_TRAM.ToString();
                txtTongTien.Text = TongTien();
            }
        }
        private void cbxTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenNhanVien.SelectedItem != null)
            {
                NHAN_VIEN it = (NHAN_VIEN)cbxTenNhanVien.SelectedItem;
                txtMaNhanVien.Text = it.MA_NV;
                lblNhanVien.Text = it.HO_VA_TEN_NV;
                lblChucVu.Text = it.CHUC_VU.TEN_CV;
            }
        }
        private void cbxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenKH.SelectedItem != null)
            {
                KHACH_HANG it = (KHACH_HANG)cbxTenKH.SelectedItem;
                txtMaKH.Text = it.MA_KH;
            }
        }
        #endregion

        #region -> "TONG_TIEN"
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = TongTien();
        }

        string TongTien()
        {
            int soLuong;
            decimal giaHang;
            int khuyenMai;

            if (int.TryParse(txt_soluong.Text, out soLuong) &&
                decimal.TryParse(txtGiaHang.Text, out giaHang) &&
                int.TryParse(txtPhanTram.Text, out khuyenMai))
            {
                decimal tongTien = soLuong * giaHang;
                decimal giamGia = tongTien * (khuyenMai / 100m);
                decimal tongTienSauGiamGia = tongTien - giamGia;
                return tongTienSauGiamGia.ToString();
            }
            else
            {
                return "0";
            }
        }
        #endregion

        #region -> "DGV_PHIEU_AN"
        private void fillDGVPhieuAn(List<PHIEU_AN> phieuAnList)
        {
            dgvPhieuAn.Rows.Clear();
            foreach (var item in phieuAnList)
            {
                int newRow = dgvPhieuAn.Rows.Add();

                dgvPhieuAn.Rows[newRow].Cells[0].Value = dgvPhieuAn.Rows.Count;
                dgvPhieuAn.Rows[newRow].Cells[1].Value = item.MA_PHIEU_AN.Trim();
                dgvPhieuAn.Rows[newRow].Cells[2].Value = item.MA_THONG_KE.Trim();
                dgvPhieuAn.Rows[newRow].Cells[3].Value = item.NHAN_VIEN.HO_VA_TEN_NV;
                dgvPhieuAn.Rows[newRow].Cells[4].Value = item.KHACH_HANG.HO_TEN_KH ?? "";
                dgvPhieuAn.Rows[newRow].Cells[5].Value = item.NGAY_LAP;
                dgvPhieuAn.Rows[newRow].Cells[6].Value = (bool)item.PHUONG_THUC_THANH_TOAN ? "Tiền mặt" : "Chuyển khoản";
                dgvPhieuAn.Rows[newRow].Cells[7].Value = item.TONG_TIEN;
            }
        }
        private int GetSelectedRow_PhieuAn(string phieuAnID)
        {

            for (int i = 0; i < dgvPhieuAn.Rows.Count; i++)
            {
                if (dgvPhieuAn.Rows[i].Cells[1].Value != null &&
                    dgvPhieuAn.Rows[i].Cells[1].Value.ToString() == phieuAnID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata_PhieuAn(int selectRow, string tongTien)
        {
            dgvPhieuAn.Rows[selectRow].Cells[0].Value = dgvPhieuAn.Rows.Count;
            dgvPhieuAn.Rows[selectRow].Cells[1].Value = txtMaPhieuAn.Text.Trim();
            dgvPhieuAn.Rows[selectRow].Cells[2].Value = cbxMaThongKe.Text.Trim();
            dgvPhieuAn.Rows[selectRow].Cells[3].Value = cbxTenNhanVien.Text.Trim();
            dgvPhieuAn.Rows[selectRow].Cells[4].Value = cbxTenKH.Text.Trim() ?? "";
            dgvPhieuAn.Rows[selectRow].Cells[5].Value = dtpNgayLap.Value;
            dgvPhieuAn.Rows[selectRow].Cells[6].Value = rdbTienMat.Checked ? "Tiền mặt" : "Chuyển khoản";
            dgvPhieuAn.Rows[selectRow].Cells[7].Value = decimal.Parse(tongTien);
        }

        private void btnThemPhieuAn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaPhieuAn.Text.Trim() == "" || txtMaNhanVien.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");

                int selectRow = GetSelectedRow_PhieuAn(txtMaPhieuAn.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvPhieuAn.Rows.Add();
                    insertUpdata_PhieuAn(selectRow, "0");
                    PHIEU_AN newPhieuAn = new PHIEU_AN
                    {
                        MA_PHIEU_AN = txtMaPhieuAn.Text.Trim(),
                        MA_THONG_KE = cbxMaThongKe.Text.Trim(),
                        MA_NV = txtMaNhanVien.Text.Trim(),
                        MA_KH = txtMaKH.Text.Trim(),
                        NGAY_LAP = dtpNgayLap.Value,
                        PHUONG_THUC_THANH_TOAN = rdbTienMat.Checked,
                        TONG_TIEN = 0,
                    };

                    db.PHIEU_AN.Add(newPhieuAn);
                    db.SaveChanges();
                    MessageBox.Show("Thêm phiếu ăn mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có phiếu ăn này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaPhieuAn_Click(object sender, EventArgs e)
        {
            int row = GetSelectedRow_PhieuAn(txtMaPhieuAn.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy phiếu ăn để sửa", "THÔNG BÁO");
            }
            else
            {
                int selectRow = GetSelectedRow_PhieuAn(txtMaPhieuAn.Text.Trim());
                insertUpdata_PhieuAn(selectRow, lbl_tongphieuan.Text.Trim());
                var phieuAn = db.PHIEU_AN.FirstOrDefault(s => s.MA_PHIEU_AN == txtMaPhieuAn.Text.Trim());
                if (phieuAn != null)
                {
                    phieuAn.MA_THONG_KE = cbxMaThongKe.Text.Trim();
                    phieuAn.MA_NV = txtMaNhanVien.Text.Trim();
                    phieuAn.MA_KH = txtMaKH.Text.Trim();
                    phieuAn.NGAY_LAP = dtpNgayLap.Value;
                    phieuAn.PHUONG_THUC_THANH_TOAN = rdbTienMat.Checked;
                    phieuAn.TONG_TIEN = decimal.Parse(lbl_tongphieuan.Text.Trim());
                    db.SaveChanges(); // Lưu
                }
                MessageBox.Show("Cập nhật thông tin phiếu ăn thành công!", "Thông báo");
            }
        }
        private void dgvPhieuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuAn.Enabled = false;
            cbxMaThongKe.Enabled = false;
            if (e.RowIndex >= 0)
            {
                if (dgvPhieuAn.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaPhieuAn.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbxMaThongKe.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbxTenNhanVien.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbxTenKH.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtpNgayLap.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[5].Value.ToString();
                    if (dgvPhieuAn.Rows[e.RowIndex].Cells[6].Value.ToString() == "Tiền mặt")
                    {
                        rdbTienMat.Checked = true;
                    }
                    else
                    {
                        rdbChuyenKhoan.Checked = true;
                    }
                    lbl_tongphieuan.Text = dgvPhieuAn.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            lblMaPhieuAn.Text = txtMaPhieuAn.Text;
            List<CHI_TIET_PHIEU_AN> ctPhieuAnList = db.CHI_TIET_PHIEU_AN.Where(ct => ct.MA_PHIEU_AN == txtMaPhieuAn.Text).ToList();
            fillDGVChiTietPhieuAn(ctPhieuAnList);
        }
        private void btnHuyPhieuAn_Click(object sender, EventArgs e)
        {
            txtMaPhieuAn.Enabled = true;
            txtMaPhieuAn.Text = "";
            cbxMaThongKe.Enabled = true;
            dgvCTPhieuAn.Rows.Clear();
            lblMaPhieuAn.Text = "";
        }
        #endregion

        #region -> "DGV_CT_PHIEUAN"
        private void fillDGVChiTietPhieuAn(List<CHI_TIET_PHIEU_AN> ctPhieuAnList)
        {
            dgvCTPhieuAn.Rows.Clear();
            foreach (var item in ctPhieuAnList)
            {
                int newRow = dgvCTPhieuAn.Rows.Add();

                dgvCTPhieuAn.Rows[newRow].Cells[0].Value = dgvCTPhieuAn.Rows.Count;
                dgvCTPhieuAn.Rows[newRow].Cells[1].Value = item.MAT_HANG.TEN_HANG;
                dgvCTPhieuAn.Rows[newRow].Cells[2].Value = item.MAT_HANG.GIA_HANG;
                dgvCTPhieuAn.Rows[newRow].Cells[3].Value = item.SO_LUONG_MUA;
                dgvCTPhieuAn.Rows[newRow].Cells[4].Value = item.MA_KHUYEN_MAI;

                decimal soLuong = Convert.ToDecimal(item.SO_LUONG_MUA);
                decimal giaHang = Convert.ToDecimal(item.MAT_HANG.GIA_HANG);
                decimal tongTien = soLuong * giaHang;
                dgvCTPhieuAn.Rows[newRow].Cells[5].Value = tongTien;
            }
        }
        private int GetSelectedRow_CTPhieuAn(string hangID)
        {

            for (int i = 0; i < dgvCTPhieuAn.Rows.Count; i++)
            {
                if (dgvCTPhieuAn.Rows[i].Cells[1].Value != null &&
                    dgvCTPhieuAn.Rows[i].Cells[1].Value.ToString() == hangID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata_CTPhieuAn(int selectRow)
        {
            dgvCTPhieuAn.Rows[selectRow].Cells[0].Value = dgvCTPhieuAn.Rows.Count;
            dgvCTPhieuAn.Rows[selectRow].Cells[1].Value = cbx_tenhang.Text.Trim();
            dgvCTPhieuAn.Rows[selectRow].Cells[2].Value = txtGiaHang.Text.Trim();
            dgvCTPhieuAn.Rows[selectRow].Cells[3].Value = txt_soluong.Text.Trim();
            dgvCTPhieuAn.Rows[selectRow].Cells[4].Value = txtMaKhuyenMai.Text.Trim();
            dgvCTPhieuAn.Rows[selectRow].Cells[5].Value = float.Parse(txtTongTien.Text.Trim());
        }

        private void dgv_Thongtinphieuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCTPhieuAn.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    cbx_tenhang.Text = dgvCTPhieuAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGiaHang.Text = dgvCTPhieuAn.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_soluong.Text = dgvCTPhieuAn.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtMaKhuyenMai.Text = dgvCTPhieuAn.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtTongTien.Text = dgvCTPhieuAn.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            decimal tong = 0;
            for (int i = 0; i < dgvCTPhieuAn.Rows.Count; i++)
            {
                if (dgvCTPhieuAn.Rows[i].Cells[5].Value != null &&
                    decimal.TryParse(dgvCTPhieuAn.Rows[i].Cells[5].Value.ToString(), out decimal giaTri))
                {
                    tong += giaTri;
                }
            }
            lbl_tongphieuan.Text = tong.ToString();
            MessageBox.Show("Tổng tiền là " + lbl_tongphieuan.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);


            bool phuongThucThanhToan = false;
            if (rdbTienMat.Checked)
            {
                phuongThucThanhToan = true;
            }
            else if (rdbChuyenKhoan.Checked)
            {
                phuongThucThanhToan = false;
            }
            decimal tongTien;
            if (decimal.TryParse(lbl_tongphieuan.Text, out tongTien))
            {
                using (var context = new DBContext())
                {
                    var hoaDon = context.PHIEU_AN.Find(lblMaPhieuAn.Text.Trim());

                    if (hoaDon != null)
                    {
                        hoaDon.PHUONG_THUC_THANH_TOAN = phuongThucThanhToan;
                        hoaDon.TONG_TIEN = tongTien;

                        context.SaveChanges();

                        MessageBox.Show("Cập nhật thành công!");

                        var phieuAnList = context.PHIEU_AN.ToList(); // Lấy lại danh sách PHIEU_AN từ cơ sở dữ liệu
                        fillDGVPhieuAn(phieuAnList);
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn không tồn tại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tổng tiền hợp lệ!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            lblMaPhieuAn.Text = "";
            dgvCTPhieuAn.Rows.Clear();
            cbx_tenhang.SelectedIndex = -1;
            cbxTenKhuyenMai.SelectedIndex = -1;
            txt_soluong.Text = "";
            txt_mahang.Text = "";
            txtGiaHang.Text = "";
            lblDVT.Text = "";
            txtMaKhuyenMai.Text = "";
            txtPhanTram.Text = "";
        }

        private void txtMaKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            string maKhuyenMai = txtMaKhuyenMai.Text;
            string tenKhuyenMai = "";
            using (var context = new DBContext())
            {
                var khuyenMai = context.KHUYEN_MAI
                                       .Where(km => km.MA_KHUYEN_MAI == maKhuyenMai)
                                       .Select(km => km.TEN_KHUYEN_MAI)
                                       .FirstOrDefault();
                tenKhuyenMai = khuyenMai ?? string.Empty;
            }
            cbxTenKhuyenMai.Text = tenKhuyenMai;
        }

        private void btnThemSuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_soluong.Text.Trim(), out int SL) && SL > 100)
                {
                    DialogResult result = MessageBox.Show("Số lượng lớn hơn 100. Bạn có chắc chắn muốn tiếp tục?",
                                                          "Xác nhận số lượng",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        txt_soluong.Text = "";
                        return;
                    }
                }
                if (string.IsNullOrEmpty(txtMaPhieuAn.Text) || string.IsNullOrEmpty(txt_mahang.Text) || string.IsNullOrEmpty(txt_soluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                int selectRow = GetSelectedRow_CTPhieuAn(cbx_tenhang.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvCTPhieuAn.Rows.Add();
                    insertUpdata_CTPhieuAn(selectRow);

                    int phanTram = int.Parse(txtPhanTram.Text.Trim());
                    float soLuong = float.Parse(txt_soluong.Text.Trim());
                    decimal giaHang = decimal.Parse(txtGiaHang.Text.Trim());

                    CHI_TIET_PHIEU_AN newCT = new CHI_TIET_PHIEU_AN
                    {
                        MA_PHIEU_AN = lblMaPhieuAn.Text.Trim(),
                        MA_KHUYEN_MAI = txtMaKhuyenMai.Text.Trim(),
                        MA_HANG = txt_mahang.Text.Trim(),
                        GIA_BAN = decimal.Parse(txtTongTien.Text.Trim(), CultureInfo.InvariantCulture),
                        SO_LUONG_MUA = float.Parse(txt_soluong.Text.Trim()),
                    };
                    db.CHI_TIET_PHIEU_AN.Add(newCT);
                    db.SaveChanges();
                    MessageBox.Show("Thêm món ăn mới thành công!", "Thông báo");
                }
                else
                {
                    insertUpdata_CTPhieuAn(selectRow);
                    var chitiet = db.CHI_TIET_PHIEU_AN.FirstOrDefault(s => s.MA_HANG == txt_mahang.Text.Trim() && s.MA_PHIEU_AN == lblMaPhieuAn.Text.Trim());
                    if (chitiet != null)
                    {
                        chitiet.MA_KHUYEN_MAI = txtMaKhuyenMai.Text.Trim();
                        chitiet.GIA_BAN = decimal.Parse(txtTongTien.Text.Trim(), CultureInfo.InvariantCulture);
                        chitiet.SO_LUONG_MUA = int.Parse(txt_soluong.Text.Trim());
                        db.SaveChanges(); // Lưu
                        MessageBox.Show("Cập nhật thông tin chi tiết phiếu ăn thành công!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow_CTPhieuAn(cbx_tenhang.Text.Trim());
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy hàng cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        var chitiet = db.CHI_TIET_PHIEU_AN.FirstOrDefault(s => s.MA_HANG == txt_mahang.Text.Trim());
                        //if (chitiet != null)
                        //{
                            db.CHI_TIET_PHIEU_AN.Remove(chitiet);
                            db.SaveChanges(); // Lưu
                        //}
                        dgvCTPhieuAn.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region -> "CAP_NHAT_KHUYEN_MAI_KHI_THEM/XOA/SUA frmKhuyenMai"
        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            frmKhuyenMai f = new frmKhuyenMai();
            f.FormClosed += FrmKhuyenMai_FormClosed;
            f.ShowDialog();
        }
        private void FrmKhuyenMai_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadKhuyenMaiList();
        }
        #endregion

        #region -> "RANG_BUOC"
        private void LoadKhuyenMaiList()
        {
            DateTime now = DateTime.Now;
            List<KHUYEN_MAI> khuyenMaiList = db.KHUYEN_MAI
                .Where(km =>
                    (km.NGAY_BAT_DAU == null || km.NGAY_BAT_DAU <= now) &&
                    (km.NGAY_KET_THUC == null || km.NGAY_KET_THUC >= now)
                ).ToList();
            fillCBXKhuyenMai(khuyenMaiList);
        }
        private void txtMaPhieuAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_mahang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '0' && txt_soluong.Text.Length == 0)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}