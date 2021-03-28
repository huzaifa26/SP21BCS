using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName == "")
            {
                MessageBox.Show("You did not select any file");
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
            

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text.Contains("*")) { } else
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
