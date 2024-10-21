using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "8";
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            toolStripComboBox2.Items.Clear();
            int[] ComboBox = { 8, 9, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int i in ComboBox)
            {
                toolStripComboBox2.Items.Add(i.ToString());
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular);

            richTextBox1.ForeColor = Color.Black;

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            richTextBox1.DeselectAll();
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.Font = new Font("Arial", 12, FontStyle.Regular);

            richTextBox1.ForeColor = Color.Black;

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

            richTextBox1.DeselectAll();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                // Lấy tên font từ ComboBox
                string selectedFont = toolStripComboBox1.SelectedItem.ToString();

                // Giữ nguyên các thuộc tính khác như kích thước và kiểu font
                float currentSize = richTextBox1.SelectionFont.Size;
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                // Áp dụng font mới cho văn bản được chọn
                richTextBox1.SelectionFont = new Font(selectedFont, currentSize, currentStyle);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }

            private void toolStripButton4_Click(object sender, EventArgs e)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

            }

            private void toolStripButton5_Click(object sender, EventArgs e)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                // Lấy kích thước mới từ ComboBox (giả định toolStripComboBox2 chứa kích thước font)
                float selectedSize = float.Parse(toolStripComboBox2.SelectedItem.ToString());

                // Giữ nguyên các thuộc tính khác như font family và kiểu font
                string currentFontFamily = richTextBox1.SelectionFont.FontFamily.Name;
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;

                // Áp dụng cỡ chữ mới cho văn bản được chọn
                richTextBox1.SelectionFont = new Font(currentFontFamily, selectedSize, currentStyle);
            }
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Lọc tệp chỉ hiển thị .txt và tất cả tệp
            openFileDialog.Title = "Open Text File";

            // Nếu người dùng chọn OK trong hộp thoại
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đọc nội dung của tệp tin đã chọn
                string filePath = openFileDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(filePath); // Đọc toàn bộ tệp

                // Hiển thị nội dung tệp vào RichTextBox
                richTextBox1.Text = fileContent;
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Lọc tệp để chỉ hiển thị .txt và tất cả tệp
            saveFileDialog.Title = "Save Text File";

            // Nếu người dùng chọn OK trong hộp thoại
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp tin đã chọn
                string filePath = saveFileDialog.FileName;

                // Ghi nội dung của RichTextBox vào tệp
                System.IO.File.WriteAllText(filePath, richTextBox1.Text); // Ghi toàn bộ nội dung vào tệp
            }
        }

        private void tspItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
        }

        private void tspUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }
    }
}