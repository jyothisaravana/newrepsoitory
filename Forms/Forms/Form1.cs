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
            com.CommandText = "Update Employee Set Name = @p1 , Salary = @s1 WHERE Id = @p2 ";
            com.Parameters.AddWithValue("@p2", ID.Text);
            com.Parameters.AddWithValue("@p1", Name.Text.Trim());
            com.Parameters.AddWithValue("@s1", Salary.Text.Trim());
            com.ExecuteNonQuery();
            s1.Close();
            MessageBox.Show("Data updated");

        }

        private void Display_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee", s1);
            s1.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            s1.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete Employee where Id=@p1", s1);
            s1.Open();
            cmd.Parameters.AddWithValue("@p1", ID.Text.Trim()); ;
            cmd.ExecuteNonQuery();
            s1.Close();
            MessageBox.Show("Record deleted successfully");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
