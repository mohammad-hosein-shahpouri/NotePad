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

namespace NotePad
{
    public partial class Form1 : Form
    {
        static string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(path);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = textBox1.Text;
                File.WriteAllText(saveFileDialog1.FileName, data);
                path = saveFileDialog1.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            path = null;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
                File.WriteAllText(path, textBox1.Text);
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var data = textBox1.Text;
                File.WriteAllText(saveFileDialog1.FileName, data);
                path = saveFileDialog1.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] data;
                data = File.ReadAllLines(openFileDialog1.FileName);
                listBox1.Items.AddRange(data);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0;
                textBox1.Text = (a / b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }
    }
}
