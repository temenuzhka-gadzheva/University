using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNodePad
{
    public partial class Form1 : Form
    {

        private FontDialog fontDialog;
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }


        private void SaveFile()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Textdocument|*.txt", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            streamWriter.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = new StreamWriter(filePath))
                        {
                            streamWriter.WriteLineAsync(richTextBox1.Text);
                        }
                    }

                }
            }
        }
        private void OpenFile()
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader stream = new StreamReader(openFile.FileName))
                    {
                        filePath = openFile.FileName;
                        Task<string> text = stream.ReadToEndAsync();
                        richTextBox1.Text = text.Result;
                    }
                }

            }
        }
        private void SaveFileAs()
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Textdocument|*.txt", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            streamWriter.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = new StreamWriter(filePath))
                        {
                            streamWriter.WriteLineAsync(richTextBox1.Text);
                        }
                    }

                }
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


            filePath = "";
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            richTextBox1.SelectionFont = new Font(fontDialog.Font.FontFamily,
            fontDialog.Font.Size, fontDialog.Font.Style);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.ShowDialog();
        }
    }
}
