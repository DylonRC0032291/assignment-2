using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double re4 = double.Parse(textBox5.Text);
                double re5 = double.Parse(textBox6.Text);
                double re6 = double.Parse(textBox7.Text);
                double answer = + re4 + re5 + re6;
                label6.Text = answer.ToString();

            }
            catch
            {
                MessageBox.Show("ye ma's dead");
            }


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double re4 = double.Parse(textBox5.Text);
                double re5 = double.Parse(textBox6.Text);
                double re6 = double.Parse(textBox7.Text);
                double answer = re4 + re5 + re6;
                label3.Text = answer.ToString();


            }
            catch
            {
                MessageBox.Show("ye ma's dead");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double ree = double.Parse(textBox8.Text);
                double reee = double.Parse(textBox9.Text);
                double reeee = double.Parse(textBox10.Text);
                double fraction1 = 1.0 / (1.0 / ree + 1.0 / reee + 1.0 / reeee);
                label8.Text = fraction1.ToString();
            }

            catch
            {
                MessageBox.Show("your mother is deceased");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}

