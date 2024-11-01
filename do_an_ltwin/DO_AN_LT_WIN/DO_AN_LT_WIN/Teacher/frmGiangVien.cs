using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LT_WIN.Teacher
{
    public partial class frmGiangVien : Form
    {
        public bool isThoat = false;
        
        public frmGiangVien()
        {
            InitializeComponent();
        }


        private void btnQLKyThi_Click(object sender, EventArgs e)
        {
            uctTTKyThi userControl = new uctTTKyThi();

            // Xóa các điều khiển cũ trong Panel (nếu có)
            panel1.Controls.Clear();

            // Đặt kích thước của UserControl để khớp với Panel
            userControl.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel
            panel1.Controls.Add(userControl);
        }

        private void btnTraDiem_Click(object sender, EventArgs e)
        {
            uctFind userControl = new uctFind();

            // Xóa các điều khiển cũ trong Panel (nếu có)
            panel1.Controls.Clear();

            // Đặt kích thước của UserControl để khớp với Panel
            userControl.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel
            panel1.Controls.Add(userControl);
        }

        private void btnDeThi_Click(object sender, EventArgs e)
        {
            uctDeThi userControl = new uctDeThi();

            // Xóa các điều khiển cũ trong Panel (nếu có)
            panel1.Controls.Clear();

            // Đặt kích thước của UserControl để khớp với Panel
            userControl.Dock = DockStyle.Fill;

            // Thêm UserControl vào Panel
            panel1.Controls.Add(userControl);
        }

        public event EventHandler DangXuat;
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                isThoat = false; // Đặt isThoat = false để tránh thoát ứng dụng
                DangXuat?.Invoke(this, new EventArgs());
                this.Close(); // Đóng form hiện tại, sự kiện FormClosing sẽ không thoát ứng dụng
            }
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    isThoat = false;
                    Environment.Exit(0);
                }
            }
            else
            {
                e.Cancel = true; // Hủy việc đóng form
                this.Hide();     // Ẩn form hiện tại để quay lại màn hình đăng nhập
            }
        }
    }
}
