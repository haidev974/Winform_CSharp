using Lab6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class frmLoaiSach : Form
    {
        SachDB_Context db = new SachDB_Context();
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            List<LoaiSach> loaiList = db.LoaiSaches.ToList();
            dgvLoaiSach.Rows.Clear();
            fillDGVLoaiSach(loaiList);
        }
        private void setGridViewStyle(DataGridView dgview)
        {
            // Bỏ đường viền ngoài của DataGridView
            dgview.BorderStyle = BorderStyle.None;

            // Tạo kiểu cho header của bảng
            dgview.EnableHeadersVisualStyles = false; // Bỏ enable visual style mặc định
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgview.ColumnHeadersHeight = 35;

            // Màu nền và màu chữ khi chọn hàng
            dgview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(43, 107, 189);
            dgview.DefaultCellStyle.SelectionForeColor = Color.White;

            // Màu nền mặc định của các ô và căn chỉnh text
            dgview.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgview.DefaultCellStyle.ForeColor = Color.Black;
            dgview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgview.DefaultCellStyle.Padding = new Padding(5); // Tạo khoảng cách giữa nội dung và ô

            // Đường viền giữa các ô
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.GridColor = Color.FromArgb(200, 200, 200);

            // Màu nền bảng tổng thể
            dgview.BackgroundColor = Color.White;

            // Tùy chỉnh chế độ chọn hàng
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgview.MultiSelect = false; // Không cho phép chọn nhiều hàng cùng lúc

            // Đặt chiều cao của từng dòng
            dgview.RowTemplate.Height = 30;
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột sẽ tự động điều chỉnh kích thước để vừa khít
        }

        //private void setGridViewStyle(DataGridView dgview)
        //{
        //    dgview.BorderStyle = BorderStyle.None;
        //    dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
        //    dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        //    dgview.BackgroundColor = Color.White;
        //    dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //}
        private void fillDGVLoaiSach(List<LoaiSach> loaiList)
        {
            setGridViewStyle(dgvLoaiSach);
            dgvLoaiSach.Rows.Clear();
            foreach (LoaiSach item in loaiList)
            {
                int rowNew = dgvLoaiSach.Rows.Add();

                dgvLoaiSach.Rows[rowNew].Cells[0].Value = item.MaLoai;
                dgvLoaiSach.Rows[rowNew].Cells[1].Value = item.TenLoai;
            }
        }

        private void dgvLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvLoaiSach.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtMaLoai.Text = dgvLoaiSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenLoai.Text = dgvLoaiSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
            }
        }
        private int GetSelectedRow(string sachID)
        {

            for (int i = 0; i < dgvLoaiSach.Rows.Count; i++)
            {

                if (dgvLoaiSach.Rows[i].Cells[0].Value != null &&
                    dgvLoaiSach.Rows[i].Cells[0].Value.ToString() == sachID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void insertUpdata(int selectRow)
        {
            dgvLoaiSach.Rows[selectRow].Cells[0].Value = txtMaLoai.Text.Trim();
            dgvLoaiSach.Rows[selectRow].Cells[1].Value = txtTenLoai.Text.Trim();
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenLoai.Text.Trim() == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin.");
                int maLoai;
                if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
                {
                    maLoai = db.LoaiSaches.Max(ls => (int?)ls.MaLoai) ?? 0;
                    maLoai++; // Mã loại mới tăng lên 1 so với mã lớn nhất hiện tại
                }
                else
                {
                    maLoai = int.Parse(txtMaLoai.Text.Trim());
                }
                int selectRow = GetSelectedRow(maLoai.ToString());
                if (selectRow == -1) // Nếu chưa có thì thêm mới
                {
                    LoaiSach newLoaiSach = new LoaiSach
                    {
                        MaLoai = maLoai, // Sử dụng mã loại vừa tính
                        TenLoai = txtTenLoai.Text.Trim() // Tên loại từ input
                    };
                    db.LoaiSaches.Add(newLoaiSach);
                    db.SaveChanges();
                    int newRow = dgvLoaiSach.Rows.Add();
                    dgvLoaiSach.Rows[newRow].Cells[0].Value = newLoaiSach.MaLoai; // Mã loại vừa tính
                    dgvLoaiSach.Rows[newRow].Cells[1].Value = newLoaiSach.TenLoai;

                    MessageBox.Show("Thêm loại sách mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Loại sách này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã loại sách cần xóa.", "Thông báo");
                    return;
                }

                if (!int.TryParse(txtMaLoai.Text.Trim(), out int maLoai))
                {
                    MessageBox.Show("Mã loại sách phải là một số nguyên.", "Thông báo");
                    return;
                }
                int row = GetSelectedRow(maLoai.ToString()); // Chuyển maLoai thành chuỗi để tìm dòng trong DataGridView
                if (row == -1)
                {
                    MessageBox.Show("Không tìm thấy loại sách cần xóa", "Thông báo");
                }
                else
                {
                    DialogResult status = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách này không?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (status == DialogResult.OK)
                    {
                        var loaiSach = db.LoaiSaches.FirstOrDefault(ls => ls.MaLoai == maLoai);
                        if (loaiSach != null)
                        {
                            db.LoaiSaches.Remove(loaiSach);
                            db.SaveChanges(); // Lưu thay đổi vào DB
                            dgvLoaiSach.Rows.RemoveAt(row);
                            MessageBox.Show("Xóa loại sách thành công.", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy loại sách trong cơ sở dữ liệu.", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã loại sách cần sửa.", "Thông báo");
                    return;
                }
                if (!int.TryParse(txtMaLoai.Text.Trim(), out int maLoai))
                {
                    MessageBox.Show("Mã loại sách phải là một số nguyên.", "Thông báo");
                    return;
                }
                int row = GetSelectedRow(maLoai.ToString());
                if (row == -1)
                {
                    MessageBox.Show("Không tìm thấy loại sách để sửa", "Thông báo");
                }
                else
                {
                    var loaiSach = db.LoaiSaches.FirstOrDefault(ls => ls.MaLoai == maLoai);
                    if (loaiSach != null)
                    {
                        loaiSach.TenLoai = txtTenLoai.Text.Trim();
                        db.SaveChanges(); // Lưu thay đổi vào DB
                        insertUpdata(row);

                        MessageBox.Show("Cập nhật thông tin loại sách thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy loại sách trong cơ sở dữ liệu.", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
