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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ".text file |*.txt";
            saveFileDialog1.ShowDialog();
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        //Open file code
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var readData = new StreamReader(openFileDialog1.FileName);
            textBox1.Text = readData.ReadLine();
        }
    }
}


//File.WriteAllText(saveFileDialog1.fileName, txtContent.Text);