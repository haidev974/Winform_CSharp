using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tstFind.KeyDown += new KeyEventHandler(tstFind_KeyDown);
            dataGridView1.ReadOnly = true;//không cho nhập trực tiếp lên dgv
        }

        private void tsbThemMoi_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            this.Close();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            string keyword = tstFind.Text.Trim().ToLower();

            dataGridView1.Rows.Clear();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                foreach (var sv in danhSachSinhVien)
                {
                    dataGridView1.Rows.Add(sv.SoThuTu, sv.MaSo, sv.TenSinhVien, sv.Khoa, sv.DiemTB);
                }
            }
            else
            {
                var ketQuaTimKiem = danhSachSinhVien.Where(sv => sv.TenSinhVien.ToLower().Contains(keyword)).ToList();

                foreach (var sv in ketQuaTimKiem)
                {
                    dataGridView1.Rows.Add(sv.SoThuTu, sv.MaSo, sv.TenSinhVien, sv.Khoa, sv.DiemTB);
                }

                if (ketQuaTimKiem.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tstFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbFind_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public class SinhVien
        {
            public int SoThuTu { get; set; }
            public string MaSo { get; set; }
            public string TenSinhVien { get; set; }
            public string Khoa { get; set; }
            public float DiemTB { get; set; }

            public SinhVien(int stt, string maSo, string tenSinhVien, string khoa, float diemTB)
            {
                SoThuTu = stt;
                MaSo = maSo;
                TenSinhVien = tenSinhVien;
                Khoa = khoa;
                DiemTB = diemTB;
            }
        }

        public void ThemSinhVien(string maSo, string tenSV, string khoa, float diemTB)
        {
            SinhVien svTonTai = danhSachSinhVien.FirstOrDefault(sv => sv.MaSo == maSo);

            if (svTonTai != null)
            {
                DialogResult result = MessageBox.Show("Mã số sinh viên đã tồn tại! Bạn có muốn cập nhật thông tin sinh viên này không?",
                                                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    svTonTai.TenSinhVien = tenSV;
                    svTonTai.Khoa = khoa;
                    svTonTai.DiemTB = diemTB;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["ColMaSo"].Value != null && row.Cells["ColMaSo"].Value.ToString() == maSo)
                        {
                            row.Cells["ColTenSV"].Value = tenSV;
                            row.Cells["ColKhoa"].Value = khoa;
                            row.Cells["ColDTB"].Value = diemTB;
                            break;
                        }
                    }
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                int soThuTu = dataGridView1.Rows.Count;
                SinhVien svMoi = new SinhVien(soThuTu, maSo, tenSV, khoa, diemTB);
                danhSachSinhVien.Add(svMoi);

                dataGridView1.Rows.Add(soThuTu, maSo, tenSV, khoa, diemTB);
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}