using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DemSoLuongNamNu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboNGANH.SelectedIndex = 0;
        }

        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null && dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = textBoxMSSV.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = textBoxHoTen.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = radioNam.Checked ? "Nam" : "Nữ";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(textBox_DTB.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = comboNGANH.Text;
        }



        private void textBoxMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboNGANH_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvQLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    textBoxMSSV.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                    textBoxHoTen.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                    {
                        radioNam.Checked = true;
                    }
                    else
                    {
                        radioNu.Checked = true;
                    }
                    textBox_DTB.Text = dgvStudent.Rows[e.RowIndex ].Cells[3].Value.ToString();
                    label_ChuyenNganh.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
        }

        private void buttonThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMSSV.Text == "" || textBoxHoTen.Text == "" || textBox_DTB.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectedRow = GetSelectedRow(textBoxMSSV.Text);
                if(selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                DemSoLuongNamNu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(textBoxMSSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("KHông tìm thấy MSSV cần xóa");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK);
                        DemSoLuongNamNu();
                    }
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DemSoLuongNamNu()
        {
            int soNam = 0;
            int soNu = 0;

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[2].Value != null)
                {
                    if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nam")
                    {
                        soNam++;
                    }
                    else if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nữ")
                    {
                        soNu++;
                    }
                }
            }
            tongnam.Text = soNam.ToString();
            tongnu.Text = soNu.ToString();
        }

        private void tongnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    textBoxMSSV.Text = row.Cells[0].Value.ToString();
                    textBoxHoTen.Text = row.Cells[1].Value.ToString();
                    if (row.Cells[2].Value.ToString() == "Nam")
                    {
                        radioNam.Checked = true;
                    }
                    else
                    {
                        radioNu.Checked = true;
                    }
                    textBox_DTB.Text = row.Cells[3].Value.ToString();
                    comboNGANH.Text = row.Cells[4].Value.ToString();
                }
            }
        }
    }
}
