using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc1
{
    public partial class Form1 : Form
    {
        int a = 0;
        int b = 0;
        bool first = false;
        char sign='q';
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!first)
            {
                a = a * 10 + Convert.ToInt32(button.Text);
            }
            else
            {
                b = b * 10 + Convert.ToInt32(button.Text);
            }
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            Button button=(Button)sender;
            if (sign.Equals('q'))
            {
                first = true;
            }
            else
            {
                CalcButton_Click(CalcButton, e);
            }
            sign = button.Text[0];
            textBox1.Text = textBox1.Text + sign.ToString();   
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            if (first && !sign.Equals('q'))
            {
                try
                {

                    a = Calc1.Calculate(a, b, sign);
                    textBox1.Text = a.ToString();
                    sign = 'q';
                    b = 0;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Незя делить на 0");
                    CancelButton_Click(CancelButton, e);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Неопознанная операция");
                    CancelButton_Click(CancelButton, e);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            a = b = 0;
            sign = 'q';
            first = false;
            textBox1.Text = "";
        }
    }
}
