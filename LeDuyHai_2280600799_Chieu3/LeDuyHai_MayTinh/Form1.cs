using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_MayTinh
{
    public partial class Form1 : Form
    {
        private float soA, soB;
        public Form1()
        {
            InitializeComponent();
            offButtom();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private float tonghaiso(float x, float y)
        {
            return x + y;
        }

        private float truhaiso(float x, float y)
        {
            return x - y;
        }

        private float nhanhaiso(float x, float y)
        {
            return x * y;
        }

        private float chiahaiso(float x, float y)
        {
            return x / y;
        }
        //hàm kiểm tra xem người dùng đã nhập chưa
        private bool checkNull()
        {
            if(txt_b.Text.Trim() == "" || txt_a.Text.Trim() == "")
                return true;
            return false;
        }
        //hàm reset buttom
        private void resetButtom()
        {
            btn_cong.BackColor = Color.White;
            btn_tru.BackColor = Color.White;
            btn_nhan.BackColor = Color.White;
            btn_chia.BackColor = Color.White;
        }
        //hàm ẩn các buttom
        private void offButtom()
        {
            btn_cong.Enabled = false;
            btn_tru.Enabled = false;
            btn_nhan.Enabled = false;
            btn_chia.Enabled = false;
        }

        //hàm hiện các buttom
        private void onButtom()
        {
            btn_cong.Enabled = true;
            btn_tru.Enabled = true;
            btn_nhan.Enabled = true;
            btn_chia.Enabled = true;
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            soA = float.Parse(txt_a.Text.Trim());
            soB = float.Parse(txt_b.Text.Trim());
            if (soB == 0)
            {
                MessageBox.Show("Phải nhập khác 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetButtom();
                btn_chia.BackColor = Color.DeepPink;
                soA = float.Parse(txt_a.Text.Trim());
                soB = float.Parse(txt_b.Text.Trim());
                txt_kq.Text = chiahaiso(soA, soB).ToString();
            }
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != (char)('\b')))
            {
                e.Handled = true;
                MessageBox.Show("Không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            if(!checkNull())
            {
                onButtom();
            }
            else
            {
                offButtom();
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_kq.Text = txt_a.Text = txt_b.Text = string.Empty;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Chưa nhập đủ giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetButtom();
                btn_tru.BackColor = Color.DeepPink;
                soA = float.Parse(txt_a.Text.Trim());
                soB = float.Parse(txt_b.Text.Trim());
                txt_kq.Text = truhaiso(soB, soA).ToString();
            }
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Chưa nhập đủ giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetButtom();
                btn_nhan.BackColor = Color.DeepPink;
                soA = float.Parse(txt_a.Text.Trim());
                soB = float.Parse(txt_b.Text.Trim());
                txt_kq.Text = nhanhaiso(soB, soA).ToString();
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Chưa nhập đủ giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resetButtom();
                btn_cong.BackColor = Color.DeepPink;
                soA = float.Parse(txt_a.Text.Trim());
                soB = float.Parse(txt_b.Text.Trim());
                txt_kq.Text = tonghaiso(soB, soA).ToString();
            }    
        }
    }
}
