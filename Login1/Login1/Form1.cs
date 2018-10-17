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
                if (user_name.Text == "Priya"||user_name.Text == "priya" && Pass_word.Text == "Admin100"|| Pass_word.Text == "admin100")
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
                if (user_name.Text == "Jyothi" || user_name.Text == "jyothi" && Pass_word.Text== "2016cse220" || Pass_word.Text == "2016CSE220")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Clear_field_Click(object sender, EventArgs e)
        {
            add_sum.Clear();
            Num_1.Clear();
            Num_2.Clear();
            
        }

        private void radio_add_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void Perform_operation_Click(object sender, EventArgs e)
        {
            if (Radio_add.Checked == true)
            {
                int x = Convert.ToInt32(Num_1.Text);
                int y = Convert.ToInt32(Num_2.Text);
                int z = x + y;
                add_sum.Text = Convert.ToString(z);
                Radio_add.Checked = false;
            }
            else if (Radio_sub.Checked == true)
            {
                int x = Convert.ToInt32(Num_1.Text);
                int y = Convert.ToInt32(Num_2.Text);
                int z = x - y;
                add_sum.Text = Convert.ToString(z);
                Radio_sub.Checked = false;
            }
            else if (Radio_mul.Checked == true)
            {
                int x = Convert.ToInt32(Num_1.Text);
                int y = Convert.ToInt32(Num_2.Text);
                int z = x * y;
                add_sum.Text = Convert.ToString(z);
                Radio_mul.Checked = false;
            }
            else if (Radio_div.Checked == true)
            {
                int x = Convert.ToInt32(Num_1.Text);
                int y = Convert.ToInt32(Num_2.Text);
                int z = x / y;
                add_sum.Text = Convert.ToString(z);
                Radio_div.Checked = false;
            }
            else
            {
                MessageBox.Show("Select a valid operations");
                Radio_add.Checked = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pass_word_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Choice_Click(object sender, EventArgs e)
        {
            string Choice = Combo_box.Text;
            MessageBox.Show("You have selected:" + Choice);
        }

        private void List_item_Click(object sender, EventArgs e)
        {
            string S = List_box.Text;
            MessageBox.Show("You have selected:" + S);
            
        }

        private void next_Click(object sender, EventArgs e)
        {
            
            Form2 obj = new Form2();
            obj.Show();
            
            
        }
    }
}
