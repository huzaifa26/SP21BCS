using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.IO;

namespace databaseeeeeeee
{
    public partial class Form1 : Form
    {
        public string dessert;
        public Form1()
        {
            InitializeComponent();
        }

        public void NewForm()
        {
            this.Hide();
            Form1 NewWindow = new Form1(); 
            NewWindow.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = Directory.GetCurrentDirectory();
            string direcPath = Path.Combine(filepath, "database.db");

            using (SqliteConnection myDBconnection = new SqliteConnection($"Filename={direcPath}"))
            {

                myDBconnection.Open();

                SqliteCommand dataInsertCommand = new SqliteCommand();
                dataInsertCommand.Connection = myDBconnection;

                dataInsertCommand.CommandType = CommandType.Text;

                dataInsertCommand.CommandText = "INSERT INTO user VALUES (NULL, @name, @count, @mainCourse, @dessert)";

                dataInsertCommand.Parameters.AddWithValue("@name", textBox1.Text);
                dataInsertCommand.Parameters.AddWithValue("@count", int.Parse(textBox2.Text));
                dataInsertCommand.Parameters.AddWithValue("@mainCourse", comboBox1.Text);
                dataInsertCommand.Parameters.AddWithValue("@dessert", dessert);

                try
                {
                    dataInsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Order Placed successfully");
                    NewForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not successfull");
                }


                myDBconnection.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dessert = "Kheer";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dessert = "Halwa";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dessert = "Fruit chat";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dessert = "Custard";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
