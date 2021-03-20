using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_2
{
    public partial class Form1 : Form
    {
        double a = 0;//operand1
        double b = 0;//operand2
        double result = 0;
        bool c = true;
        string opr = "";//operator

        public Form1()
        {
            InitializeComponent();
        }


        private void button0_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += "9";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            c = true;
            opr = "+";
            a = Double.Parse(label_Result.Text);
            
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            b = Double.Parse(label_Result.Text);
            c = true;
            switch (opr)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if(b == 0)
                    {
                        label_Result.Text = "";
                        MessageBox.Show("The divisor could not be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        result = a / b;
                    }
                    break;
            }
            label_Result.Text = result + "";
        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            c = true;
            opr = "-";
            a = Double.Parse(label_Result.Text);
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (c)
            {
                label_Result.Text = "";
                c = false;
            }
            label_Result.Text += ".";
        }

        private void button_Multi_Click(object sender, EventArgs e)
        {
            c = true;
            opr = "*";
            a = Double.Parse(label_Result.Text);
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            c = true;
            opr = "/";
            a = Double.Parse(label_Result.Text);
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            label_Result.Text = "0";
            c = true;
        }
    }
}
