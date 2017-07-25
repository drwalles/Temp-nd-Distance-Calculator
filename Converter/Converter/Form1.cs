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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            line = textBox1.Text;

            if (comboBox1.SelectedItem == "Meter")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                line = textBox1.Text;
                result = Convert.ToDouble(line);
                result = result / 100;
                textBox2.Text = result.ToString();
            }
            else if (comboBox1.SelectedItem == "KiloMeter")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                line = textBox1.Text;
                result = Convert.ToDouble(line);
                result = result / 100000;
                textBox2.Text = result.ToString();
            }
            else if (comboBox1.SelectedItem == "Feet")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                line = textBox1.Text;
                result = Convert.ToDouble(line);
                result = result / 30.48;
                textBox2.Text = result.ToString();
            }


            else if (radioButton1.Checked)
            {
                result = Convert.ToDouble(line) * 1.8;
                result = result + 32;
                textBox2.Text = result.ToString();
            }
            else if (radioButton2.Checked)
            {
                result = Convert.ToDouble(line) - 32;
                /*result = result *5;
                result = result / 9;*/
                result = result / 1.8;
                textBox2.Text = result.ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
