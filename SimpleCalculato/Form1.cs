using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }
        string Total;
        double num1;
        double num2;
        int temp1;
        int temp2;
        string option;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += button0.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text += option;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text += option;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text += option;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text += option;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            int operatorIndex = expression.IndexOf(option);

            if (operatorIndex == -1)
            {
                MessageBox.Show("Invalid expression.");
                return;
            }

            string operand1 = expression.Substring(0, operatorIndex);
            string operand2 = expression.Substring(operatorIndex + 1);

            if (!double.TryParse(operand1, out num1) || !double.TryParse(operand2, out num2))
            {
                MessageBox.Show("Invalid numbers.");
                return;
            }



            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Division by zero error.");
                        return;
                    }
                    result = num1 / num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;
            }

            label1.Text = result.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            label1.Text = string.Empty;
            //input = string.Empty;
            num1 = num2 = result = 0;
            option = string.Empty;
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }
    }
}
