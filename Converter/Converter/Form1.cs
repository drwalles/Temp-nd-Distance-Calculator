using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
       
        double result;
        String line;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line = textBox1.Text;
            if (radioButton1.Checked == true)
            {
                //comboBox2.Hide();


                if (comboBox1.SelectedItem == "Celcius 2 Fahrenhit")
                {
                    result = Convert.ToDouble(line) * 1.8;
                    result = result + 32;
                    textBox2.Text = result.ToString();
                }
                else if (comboBox1.SelectedItem == "Fahrenhit 2 Celcius")
                {
                    result = Convert.ToDouble(line) - 32;
                    /*result = result *5;
                    result = result / 9;*/
                    result = result / 1.8;
                    textBox2.Text = result.ToString();
                }
            }
            else if (radioButton2.Checked == true)
            {
                //comboBox1.Hide();
                if (comboBox2.SelectedItem == "CentiMeter 2 Meter")
                {
                    line = textBox1.Text;
                    result = Convert.ToDouble(line);
                    result = result / 100;
                    textBox2.Text = result.ToString();
                }
                else if (comboBox2.SelectedItem == "CentiMeter 2 KiloMeter")
                {

                    line = textBox1.Text;
                    result = Convert.ToDouble(line);
                    result = result / 100000;
                    textBox2.Text = result.ToString();
                }
                else if (comboBox2.SelectedItem == "CentiMeter 2 Feet")
                {
                    line = textBox1.Text;
                    result = Convert.ToDouble(line);
                    result = result / 30.48;
                    textBox2.Text = result.ToString();
                }

            }
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Hide();
            comboBox2.Show();
            comboBox2.SelectedIndex = 0; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Hide();
            comboBox1.Show();
            comboBox1.SelectedIndex = 0;
        }
    }
}
