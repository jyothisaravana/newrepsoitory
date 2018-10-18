using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form1 obj2 = new Form1();
            obj2.Show();
            this.Close();
        }

        private void Button_click_Click(object sender, EventArgs e)
        {
            string n = name_text.Text;
            string id = id_text.Text;
            string p = prog_text.Text;
            string b = br_text.Text;
            string s = sec_text.Text;
            string y = year_text.Text;
            if (name_text.Text == "")
            {
                MessageBox.Show("Enter you name");
            }
           else if (id_text.Text == "")
            {
                MessageBox.Show("Enter you Idno");

            }
            else if (prog_text.Text == "")
            {
                MessageBox.Show("Enter you Program");

            }
           else  if (br_text.Text == "")
            {
                MessageBox.Show("Enter you branch");

            }
           else if (sec_text.Text == "")
            {
                MessageBox.Show("Enter you Section ");

            }
          else  if(year_text.Text =="")
            {

                MessageBox.Show("Enter your year");
            }
            else

            MessageBox.Show("you have entered all");
        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (name_text.Text == "")
            {
                MessageBox.Show("Enter you name");
            }
            else if (id_text.Text == "")
            {
                MessageBox.Show("Enter you Idno");

            }
            else if (prog_text.Text == "")
            {
                MessageBox.Show("Enter you Program");

            }
            else if (br_text.Text == "")
            {
                MessageBox.Show("Enter you branch");

            }
            else if (sec_text.Text == "")
            {
                MessageBox.Show("Enter you Section ");

            }
            else if (year_text.Text == "")
            {

                MessageBox.Show("Enter your year");
            }
            else
            {
                
                Form3 obj3 = new Form3();
                obj3.Show();
            }



        }
    }
}
