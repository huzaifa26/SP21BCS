using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var firstNumber = int.Parse(ibFirst.Text);
            var secondNumber = int.Parse(ibSecond.Text);
            //firstNumber = int.Parse(ibFirst.Text)
            //secondNumber = int.Parse(ibSecond.Text);
            var result = firstNumber + secondNumber;
            ibResult.Text = result.ToString();


        }
    }
}
