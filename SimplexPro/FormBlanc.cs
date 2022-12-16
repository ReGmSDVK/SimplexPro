using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexPro
{
    public partial class FormBlanc : Form
    {
        private string FilePath;
        public FormBlanc()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                    FilePath = dialog.FileName;
                textBox1.Text = File.ReadAllText(FilePath);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FilePath))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                    if (dialog.ShowDialog()== DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        File.WriteAllText(FilePath, textBox1.Text);
                    }
            }
            File.WriteAllText(FilePath, textBox1.Text);
        }

        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            переносПоСловамToolStripMenuItem.Checked = !переносПоСловамToolStripMenuItem.Checked;
            textBox1.WordWrap = переносПоСловамToolStripMenuItem.Checked;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = dialog.FileName;
                    File.WriteAllText(FilePath, textBox1.Text);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void вЫрезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text += DateTime.Now;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = dialog.Font;
                }
            }
        }

        private void FormBlanc_Load(object sender, EventArgs e)
        {

        }

        private void FormBlanc_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
