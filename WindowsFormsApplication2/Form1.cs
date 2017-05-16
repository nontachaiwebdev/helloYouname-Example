using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int loop()
        {
            //System.Threading.Thread.Sleep(1000);
            for (var i = 1; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wnat to save name ?", "Submit Fullname", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Console.WriteLine(label3.Text);
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    int x = loop();
                    label3.Text = "Hello" + textBox1.Text + " " + textBox2.Text;
                }
            }
            else
            {
                label3.Text = "Please Try again!!!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
