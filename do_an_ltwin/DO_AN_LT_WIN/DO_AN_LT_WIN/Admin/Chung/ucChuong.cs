using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DO_AN_LT_WIN.Entities;


namespace DO_AN_LT_WIN.Admin.Chung
{
    public partial class ucChuong : UserControl
    {
        DBContext db = new DBContext();
        public ucChuong()
        {
            InitializeComponent();
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.EnableHeadersVisualStyles = false;
            dgview.BackgroundColor = Color.White;
            dgview.GridColor = Color.FromArgb(210, 210, 210);
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            var headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
            var cellFont = new Font("Segoe UI", 11);
            dgview.ColumnHeadersDefaultCellStyle.Font = headerFont;
            dgview.DefaultCellStyle.Font = cellFont;
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 57, 85);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgview.ColumnHeadersVisible = true;
            dgview.DefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            dgview.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            dgview.DefaultCellStyle.Padding = new Padding(8);
            dgview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            dgview.DefaultCellStyle.SelectionForeColor = Color.White;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 255);
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.MultiSelect = false;
            dgview.ReadOnly = true;
            dgview.RowHeadersVisible = false;
            dgview.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgview.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataGridViewColumn column in dgview.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void ucChuong_Load(object sender, EventArgs e)
        {
            List<Chuong> chuongList = db.Chuong.ToList();
            List<Mon_Hoc> monHocList = db.Mon_Hoc.ToList();

            dgvChuong.Rows.Clear();
            //setGridViewStyle(dgvChuong);

            fillDGVChuong(chuongList);
            fillCBXTenMon(monHocList);
        }

        private void fillCBXTenMon(List<Mon_Hoc> monHocList)
        {
            cbxMaMon.DataSource = monHocList;
            cbxMaMon.DisplayMember = "Ma_Mon_Hoc";
            cbxMaMon.ValueMember = "Ten_Mon_Hoc";
        }

        private void fillDGVChuong(List<Chuong> chuongList)
        {
            dgvChuong.Rows.Clear();
            foreach (Chuong it in chuongList)
            {
                int rowNew = dgvChuong.Rows.Add();

                dgvChuong.Rows[rowNew].Cells[0].Value = dgvChuong.Rows.Count;
                dgvChuong.Rows[rowNew].Cells[1].Value = it.Ma_Chuong.Trim();
                dgvChuong.Rows[rowNew].Cells[2].Value = it.Mon_Hoc.Ma_Mon_Hoc.Trim();
                dgvChuong.Rows[rowNew].Cells[3].Value = it.Ten_Chuong;
                dgvChuong.Rows[rowNew].Cells[4].Value = it.Mo_Ta;
                dgvChuong.Rows[rowNew].Cells[5].Value = it.Thoi_Gian_Tao;
                dgvChuong.Rows[rowNew].Cells[6].Value = it.Thoi_Gian_Cap_Nhat;
            }
        }
        private int GetSelectedRow(string chuongID)
        {

            for (int i = 0; i < dgvChuong.Rows.Count; i++)
            {
                if (dgvChuong.Rows[i].Cells[1].Value != null &&
                    dgvChuong.Rows[i].Cells[1].Value.ToString() == chuongID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvChuong.Rows[selectRow].Cells[0].Value = dgvChuong.Rows.Count;
            dgvChuong.Rows[selectRow].Cells[1].Value = txtMaChuong.Text.Trim();
            dgvChuong.Rows[selectRow].Cells[2].Value = cbxMaMon.Text.Trim();
            dgvChuong.Rows[selectRow].Cells[3].Value = txtTenChuong.Text.Trim();
            dgvChuong.Rows[selectRow].Cells[4].Value = txtMoTa.Text.Trim();
            dgvChuong.Rows[selectRow].Cells[5].Value = dtpTGTao.Value;
            dgvChuong.Rows[selectRow].Cells[6].Value = dtpTGCapNhat.Value;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectRow = GetSelectedRow(txtMaChuong.Text.Trim());
            if (selectRow == -1)
            {
                MessageBox.Show("Không tìm thấy chương để sửa", "THÔNG BÁO");
                return;
            }
            dtpTGCapNhat.Value = DateTime.Now;
            insertUpdata(selectRow);
            var chuong = db.Chuong.FirstOrDefault(s => s.Ma_Chuong == txtMaChuong.Text.Trim());
            if (chuong != null)
            {
                chuong.Ma_Mon_Hoc = cbxMaMon.Text.Trim();
                chuong.Ten_Chuong = txtTenChuong.Text.Trim();
                chuong.Mo_Ta = txtMoTa.Text.Trim();
                chuong.Thoi_Gian_Tao = dtpTGTao.Value;
                chuong.Thoi_Gian_Cap_Nhat = dtpTGCapNhat.Value;
                db.SaveChanges(); // Lưu
            }
            MessageBox.Show("Cập nhật thông tin chương thành công!", "Thông báo");
        }

        private void dgvChuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvChuong.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaChuong.Text = dgvChuong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTenChuong.Text = dgvChuong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbxMaMon.Text = dgvChuong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMoTa.Text = dgvChuong.Rows[e.RowIndex].Cells[4].Value.ToString();
                    dtpTGTao.Text = dgvChuong.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dtpTGCapNhat.Text = dgvChuong.Rows[e.RowIndex].Cells[6].Value.ToString();

                    var maMonHoc = dgvChuong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    UpdateTenMonByMaMon(maMonHoc);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChuong.Text.Trim() == "" || txtTenChuong.Text.Trim() == "" || txtMoTa.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");
                if (txtMaChuong.Text.Contains(" "))
                    throw new Exception("Mã chương không hợp lệ.");
                int selectRow = GetSelectedRow(txtMaChuong.Text.Trim());
                if (selectRow == -1)
                {
                    selectRow = dgvChuong.Rows.Add();
                    dtpTGTao.Value = DateTime.Now;
                    dtpTGCapNhat.Value = DateTime.Now;
                    insertUpdata(selectRow);
                    Chuong newChuong = new Chuong
                    {
                        Ma_Chuong = txtMaChuong.Text.Trim(),
                        Ma_Mon_Hoc = cbxMaMon.Text.Trim(),
                        Ten_Chuong = txtTenChuong.Text.Trim(),
                        Mo_Ta = txtMoTa.Text.Trim(),
                        Thoi_Gian_Tao = dtpTGTao.Value,
                        Thoi_Gian_Cap_Nhat = dtpTGCapNhat.Value,
                    };

                    db.Chuong.Add(newChuong);
                    db.SaveChanges();
                    MessageBox.Show("Thêm chương mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã có chương này! Vui lòng dùng chức năng sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void UpdateTenMonByMaMon(string maMonHoc)
        {
            var selectedMonHoc = db.Mon_Hoc.FirstOrDefault(mh => mh.Ma_Mon_Hoc == maMonHoc);
            if (selectedMonHoc != null)
            {
                txtTenMon.Text = selectedMonHoc.Ten_Mon_Hoc;
            }
            else
            {
                txtTenMon.Text = string.Empty;
            }
        }

        private void cbxMaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaMon.SelectedItem is Mon_Hoc selectedMonHoc)
            {
                UpdateTenMonByMaMon(selectedMonHoc.Ma_Mon_Hoc);
            }
        }
    }
}
