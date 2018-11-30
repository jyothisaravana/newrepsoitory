using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_management
{
    public partial class Form1 : Form
    {

        SqlConnection s1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\2016cse220\newrepsoitory\Library_management\Library_management\Login_details.mdf;Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void u_name_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void Login_Click(object sender, EventArgs e)
        {

            string selectString = "Select u_name,p_word"+"from Login_Details"+"Where u_name="'+u_name.Text+"'And p_word = "'+p_word.text+"";
            
            

        }
    }
}
