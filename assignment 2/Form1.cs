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
                double resistor = double.Parse(textBox8.Text);
                double resistor2 = double.Parse(textBox9.Text);
                double answer = 1.0 / (1.0 / resistor + 1.0 / resistor2 + 1.0);

            }

            catch
            {
                MessageBox.Show("your mother is deceased");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double resistor = double.Parse(textBox12.Text);
                double resistor2 = double.Parse(textBox11.Text);
                double answer = resistor + resistor2;
                label11.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("try again muppet boy");
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double res = double.Parse(textBox13.Text);
                double res2 = double.Parse(textBox14.Text);
                double res3 = double.Parse(textBox15.Text);
                double answer = 1.0 / (1.0 / res + 1.0 / res2 + 1.0 / res3);
                label13.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("muppet you lad eeeeeee");
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double resistor = double.Parse(textBox10.Text);
                double resistor2 = double.Parse(textBox16.Text);
                double resistor3 = double.Parse(textBox17.Text);
                double resistor4 = double.Parse(textBox18.Text);
                double answer = resistor + resistor2;
                label11.Text = answer.ToString();
        
            }
            catch
            {
                MessageBox.Show("its britney bitch");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double resis = double.Parse(textBox19.Text); 
                double resis2 = double.Parse(textBox20.Text); 
                double resis3 = double.Parse(textBox21.Text);
                double resis4 = double.Parse(textBox22.Text);
                double answer = 1.0 / (1.0 / resis + 1.0 / resis2 + 1.0 / resis3 + 1.0 / resis4);
                label13.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("unlucky son");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double resistorr = double.Parse(textBox23.Text);
                double resistorr2 = double.Parse(textBox24.Text);
                double resistorr3 = double.Parse(textBox25.Text);
                double resistorr4 = double.Parse(textBox26.Text);
                double resistorr5 = double.Parse(textBox27.Text);
                double answer = resistorr + resistorr2 + resistorr3 + resistorr4 + resistorr5;
                label18.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("bonjour madam we seem to have a problem");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(textBox28.Text);
                double r2 = double.Parse(textBox29.Text);
                double r3 = double.Parse(textBox30.Text);
                double r4 = double.Parse(textBox31.Text);
                double r5 = double.Parse(textBox32.Text);
                double answer = 1.0 / (1.0 / r + 1.0 / r2 + 1.0 / r3 + 1.0 / r4 + 1.0 / r5);
                label13.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("sorry mate");
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

                                          