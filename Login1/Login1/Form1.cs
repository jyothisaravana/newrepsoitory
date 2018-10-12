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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            




        }

        private void login_Click(object sender, EventArgs e)
        {
            if (admin.Checked == true)
            {
                if (user_name.Text == "Priya"||user_name.Text == "priya" && Pass_word.Text == "Admin100"||Pass_word.Text == "admin100")
                {
                    MessageBox.Show("Your login is successful as Admin");
                }
                else
                    MessageBox.Show("Invaid username and password");
                user_name.Clear();
                Pass_word.Clear();
                admin.Checked = false;
            }
            else if (student.Checked == true)
            {
                if (user_name.Text == "Jyothi" || user_name.Text == "jyothi" && Pass_word.Text == "2016cse220" || Pass_word.Text == "2016CSE220")
                {
                    MessageBox.Show("Your login is successful as Student");
                }
                else
                    MessageBox.Show("Invaid username and password");
                user_name.Clear();
                Pass_word.Clear();
                student.Checked = false;
            }
            else if (faculty.Checked == true)
            {
                if (user_name.Text == "Ankitha"||user_name.Text == "ankitha" && Pass_word.Text == "PUF100"||Pass_word.Text == "puf100")
                {
                    MessageBox.Show("Your login is successful as Faculty");
                }
                else
                    MessageBox.Show("Invaid username and password");
                user_name.Clear();
                Pass_word.Clear();
                faculty.Checked = false;
            }
            else
            {
                MessageBox.Show("Select the radio button");
                user_name.Clear();
                Pass_word.Clear();
                admin.Checked = false;
                student.Checked = false;
                faculty.Checked = false;
            }

        }
    }
}
