using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text; // Fetch text from textBox1
            if (inputText.ToUpper() == "NAMA_PRAKTIKAN")
            {
                label1.Text = "Halo NAMA_PRAKTIKAN"; // Assign text to label1's Text property
            }
            else
            {
                label1.Text = "HALO " + inputText; // Assign text to label1's Text property
            }
        }
    }
}
