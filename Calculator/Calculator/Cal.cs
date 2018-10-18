using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Cal : Form
    {
        double FNum;
        string op;
        double SNum;
        double Result;
        public Cal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
           this.textBox1.Text += x;

        }

        private void b2_Click(object sender, EventArgs e)
        {
            int y = 2;
            this.textBox1.Text += y;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int z = 3;
            this.textBox1.Text +=z;

        }

        private void b4_Click(object sender, EventArgs e)
        {
            int a = 4;
            this.textBox1.Text += a;

        }

        private void b5_Click(object sender, EventArgs e)
        {
            int b = 5;
            this.textBox1.Text += b;

        }

        private void b_plus_Click(object sender, EventArgs e)
        {
            FNum = Con
            
            this.textBox1.Text += "+";
            op = "+";

        }

        private void b_minus_Click(object sender, EventArgs e)
        {

            FNum = Convert.ToDouble(textBox1.Text);
         
            textBox1.Text += "-";
            SecondNumber = Convert.ToDouble(textBox1.Text);
            op = "-";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                Result = (FNum + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                
            }
            if (op == "-")
            {
                Result = (FNum - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FNum = Result;
            }



        }
    }
}
