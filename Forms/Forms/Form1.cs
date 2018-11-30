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
using System.IO;


namespace Forms
{
    public partial class Form1 : Form
    {
        int i = 2;
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

        private void Sel_image_Click(object sender, EventArgs e)
        {

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openfile.FileName;

            }
        }

        private void Save_img_Click(object sender, EventArgs e)
        {
            
            s1.Open();
            Byte[] mypic = File.ReadAllBytes(openfile.FileName);
            SqlCommand cm = new SqlCommand("insert into Image2 values(" + i + ",@pic)", s1);
            //cm.CommandType = CommandType.Text;

            SqlParameter pr = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cm.Parameters.Add(pr);
            try
            {
                cm.ExecuteNonQuery();

            }
            catch (Exception e2)
            {
                MessageBox.Show("change id");
            }
            MessageBox.Show("saved");
            i = i++;
            s1.Close();






        }

        private void Show_Click(object sender, EventArgs e)
        {
            s1.Open();
            SqlDataAdapter s = new SqlDataAdapter("select photo from Image2 where id='" + textBox1.Text + "'", s1);
            DataTable dt = new DataTable();
            s.Fill(dt);
            byte[] mydata = new byte[0];
            mydata = (byte[])dt.Rows[0][1];
            MemoryStream ms = new MemoryStream(mydata);
            Img_view.Image = Image.FromStream(ms);
            s1.Close();
        }
    }
}
