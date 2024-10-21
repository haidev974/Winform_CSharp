using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTTK
{
    public partial class Form1 : Form
    {
        private int stt = 0;
        public Form1()
        {
            InitializeComponent();
            TinhTongTien();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int GetSelectedRow(string stk)
        {
            for (int i = 0; i < dataGridView_SDTTTK.Rows.Count; i++)
            {
                if (dataGridView_SDTTTK.Rows[i].Cells[1].Value != null && dataGridView_SDTTTK.Rows[i].Cells[1].Value.ToString() == stk)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dataGridView_SDTTTK.Rows[selectedRow].Cells[0].Value = stt;
            dataGridView_SDTTTK.Rows[selectedRow].Cells[1].Value = textBox_stk.Text;
            dataGridView_SDTTTK.Rows[selectedRow].Cells[2].Value = textBox_ten.Text;
            dataGridView_SDTTTK.Rows[selectedRow].Cells[3].Value = textBox_diachi.Text;
            dataGridView_SDTTTK.Rows[selectedRow].Cells[4].Value = textBox_soTien.Text;
        }

        private void button_them_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_stk.Text == "" || textBox_ten.Text == "" || textBox_diachi.Text == "" || textBox_diachi.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                int selectedRow = GetSelectedRow(textBox_stk.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dataGridView_SDTTTK.Rows.Add();
                    stt++;
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                TinhTongTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(textBox_stk.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy số tài khoản cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        dataGridView_SDTTTK.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa tài khoàn thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    CapNhatSTT();
                    TinhTongTien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_SDTTTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_SDTTTK.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    textBox_stk.Text = row.Cells[1].Value.ToString();
                    textBox_ten.Text = row.Cells[2].Value.ToString();
                    textBox_diachi.Text = row.Cells[3].Value.ToString();
                    textBox_soTien.Text = row.Cells[4].Value.ToString();
                }
            }
        }
        private void TinhTongTien()
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dataGridView_SDTTTK.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    decimal soTien;
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out soTien))
                    {
                        tongTien += soTien;
                    }
                }
            }

            textBox_TongTien.Text = " " + tongTien.ToString();
        }
        private void CapNhatSTT()
        {
            for (int i = 0; i < dataGridView_SDTTTK.Rows.Count; i++)
            {
                dataGridView_SDTTTK.Rows[i].Cells[0].Value = i + 1;
            }
        }

    }
}
