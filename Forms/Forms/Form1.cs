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

namespace Forms
{
    public partial class Form1 : Form
    {
        SqlConnection s1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\2016cse220\newrepsoitory\Forms\Forms\Properties\Database1.mdf; Integrated Security = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Save_Click(object sender, EventArgs e)
        {
            s1.Open();
            SqlCommand com = s1.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Employee values('" + ID.Text + "' , '" + Name.Text+ "','"+Salary.Text+"')";
            com.ExecuteNonQuery();
            s1.Close();
            MessageBox.Show("Saved");
            
                
        }

        private void Update_Click(object sender, EventArgs e)
        {

            s1.Open();
            SqlCommand com = s1.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update Employee Set Id = '206'where ";
            com.ExecuteNonQuery();
            s1.Close();
            MessageBox.Show("Data updated");

        }
    }
}
