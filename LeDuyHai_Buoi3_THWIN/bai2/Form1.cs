using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class WORD_MINI : Form
    {
        private string savedFilePath = "";
        public WORD_MINI()
        {
            InitializeComponent();
            this.KeyDown += WORD_MINI_keydown;
        }

        private void WORD_MINI_keydown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.B)
                {
                    // Xử lý khi nhấn tổ hợp phím Ctrl + B
                    if (richTextBox1.SelectionFont.Bold) richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                    else richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.I)
                {
                    // Xử lý khi nhấn tổ hợp phím Ctrl + I
                    tst_bold.PerformClick();
                }
                else if (e.KeyCode == Keys.U)
                {
                    // Xử lý khi nhấn tổ hợp phím Ctrl + U
                    tstU.PerformClick();
                }
            }

        }

        private void fontTuyChinh_click(object sender, EventArgs e)
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
        private void load_font()
        {
            foreach (FontFamily item in new InstalledFontCollection().Families)
            {
                tsCbbFont.Items.Add(item.Name);
            }
            tsCbbFont.SelectedText = "Tahoma";
        }
        private void loadSize()
        {
            int[] sz = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            tsCbbSize.ComboBox.DataSource = sz;
            tsCbbSize.SelectedItem = 14;
        }
        private void WORD_MINI_Load(object sender, EventArgs e)
        {
            
            load_font();
            loadSize();
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void tst_bold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
        }

        private void tst_I_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Italic);
        }

        private void tstU_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
        }

        private void tst_GachNgang_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Strikeout)
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style & ~FontStyle.Strikeout);
            else
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
        }

        private void tst_fileMoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn tạo với văn bản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Tahoma",14,FontStyle.Regular);
            tsCbbFont.SelectedItem = "Tahoma";
            tsCbbSize.SelectedItem = 14;
            savedFilePath = "";
        }

        private void tst_luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savedFilePath) && !(Path.GetExtension(savedFilePath).Equals(".txt", StringComparison.OrdinalIgnoreCase)))
            {
                try
                {
                    richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Title = "Lưu tập tin văn bản";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.Filter = "RichText files|*.rtf";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = saveFileDialog.FileName;
                    try
                    {
                        richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void createFileNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savedFilePath) && !(Path.GetExtension(savedFilePath).Equals(".txt", StringComparison.OrdinalIgnoreCase)))
            {
                try
                {
                    richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Title = "Lưu tập tin văn bản";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.Filter = "RichText files|*.rtf";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = saveFileDialog.FileName;
                    try
                    {
                        richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                savedFilePath = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        richTextBox1.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        richTextBox1.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }
                    MessageBox.Show("Tập tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savedFilePath) && !(Path.GetExtension(savedFilePath).Equals(".txt", StringComparison.OrdinalIgnoreCase)))
            {
                try
                {
                    richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.Title = "Lưu tập tin văn bản";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.Filter = "RichText files|*.rtf";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = saveFileDialog.FileName;
                    try
                    {
                        richTextBox1.SaveFile(savedFilePath, RichTextBoxStreamType.RichText);
                        MessageBox.Show("Tập tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Close();
        }

        private void tsCbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox toolStripComboBoxFont = (ToolStripComboBox)sender;
            string selectedFontName = toolStripComboBoxFont.SelectedItem.ToString();
            float selectedFontSize = richTextBox1.Font.Size;
            FontStyle selectedFontStyle = richTextBox1.Font.Style;
            if (richTextBox1.SelectionFont.Bold)
            {
                selectedFontStyle |= FontStyle.Bold;
            }
            if (richTextBox1.SelectionFont.Italic)
            {
                selectedFontStyle |= FontStyle.Italic;
            }
            if (richTextBox1.SelectionFont.Underline)
            {
                selectedFontStyle |= FontStyle.Underline;
            }
            richTextBox1.Font = new Font(selectedFontName, selectedFontSize, selectedFontStyle);

        }

        private void tsCbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox toolStripComboBoxSize = (ToolStripComboBox)sender;
            string selectedFontName = richTextBox1.Font.ToString();
            float selectedFontSize = float.Parse(toolStripComboBoxSize.SelectedItem.ToString());
            FontStyle selectedFontStyle = richTextBox1.Font.Style;
            if (richTextBox1.SelectionFont.Bold)
            {
                selectedFontStyle |= FontStyle.Bold;
            }
            if (richTextBox1.SelectionFont.Italic)
            {
                selectedFontStyle |= FontStyle.Italic;
            }
            if (richTextBox1.SelectionFont.Underline)
            {
                selectedFontStyle |= FontStyle.Underline;
            }
            richTextBox1.Font = new Font(selectedFontName, selectedFontSize, selectedFontStyle);
        }
    }
}
