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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (username_text.Text == "Jyothi" || username_text.Text == "jyothi" && password_text.Text == "2016cse220")
            {
                MessageBox.Show("Login successful");
                username_text.Clear();
                password_text.Clear();
                Cal obj = new Cal();
                obj.Show();
                
            }
            else if(username_text.Text == "" && password_text.Text == "")
            {
                MessageBox.Show("Please enter the fields");
            }
            else
            {
                MessageBox.Show("Please enter the correct detials");
                username_text.Clear();
                password_text.Clear();
            }
            
                    
        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
