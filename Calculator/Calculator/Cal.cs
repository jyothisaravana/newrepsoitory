using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Cal : Form
    {
        string op;
        int result;
        int value1;
        int value2;
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
           
            
            this.textBox1.Text += "+";
            op = "+";
           

        }

        private void b_minus_Click(object sender, EventArgs e)
        {

           
            this.textBox1.Text += "-";
            op = "-";
           
        }

        private void equals_Click(object sender, EventArgs e)
        {

            string s1 = textBox1.Text;
            if (op == "+")
            {
                string[] array = s1.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);

                 value1 = Convert.ToInt32(array[0]);
                 value2 = Convert.ToInt32(array[1]);
                result = value1 + value2;
            }
            else if(op == "-")
            {
                string[] array = s1.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

                 value1 = Convert.ToInt32(array[0]);
                 value2 = Convert.ToInt32(array[1]);
                 result = value1 - value2;


            }
            else
            {
                MessageBox.Show("enter a valid operation");
            }

            textBox1.Text = Convert.ToString(result);
            
        }

        private void Clear_box_Click(object sender, EventArgs e)
        {

            textBox1.Clear();

        }
    }
}
