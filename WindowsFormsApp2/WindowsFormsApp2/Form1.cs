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

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public int lengthOfTextWhileSaving;
        public int length;
        public string textBeforeSaving;

        //Save file Method/Function
        public void SaveFile()
        {
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName == "")
            {
                MessageBox.Show("You did not select any file");
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                lengthOfTextWhileSaving = textBox1.Text.Length;
                label1.Text = saveFileDialog1.FileName;
                textBeforeSaving = textBox1.Text;
            }
        }
        

        public Form1()
        {
            InitializeComponent();
        }


        //Save as method call.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            
        }

        //Save code
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            saveFileDialog1.FileName = "Untitled" + counter + "txt";
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            counter++;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Open file code.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                if (label1.Text.Contains("*"))
                {
                    DialogResult result = MessageBox.Show("do you want to discard the changes?", "Unsaved Changes Alert", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        //do nothing
                    }
                    if (result == DialogResult.Yes)
                    {
                        openFileDialog1.Filter = "tet fi| *.txt";
                        openFileDialog1.ShowDialog();
                        textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                        //label1.Text = openFileDialog1.FileName;
                    }
                }
            }
            else
            {

            }
            }

        //Save or unsaves Asterisk on bottom right of screen.
        private void Textbox1_keyUp(object sender, KeyEventArgs e)
        {
            label2.Text = textBox1.Text.Length.ToString() + " Letters";

            if (textBeforeSaving != textBox1.Text)
            {
                label1.Text = saveFileDialog1.FileName + "*";
            }

            if (textBeforeSaving == textBox1.Text)
            {
                label1.Text = saveFileDialog1.FileName;
            }

            if(textBox1.Text.Length == 0)
            {
                label1.Text = "";
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

 
        //Cross button event handler
        private void FC(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                DialogResult result1 = MessageBox.Show("Document unsaved. Do you want to Save and close the document", "Unsaved Changes Alert", MessageBoxButtons.YesNo);
                if (textBeforeSaving != textBox1.Text)
                {
                    if (result1 == DialogResult.Yes)
                    {
                        SaveFile();
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }

            }

        }


        //Exit option in Menu bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
