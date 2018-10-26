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

namespace window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.database1DataSet1.Table);
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\\Database1.mdf; Integrated Security = True";
            string selectCommand = "Select * from dbo.[Table]";//we have used [] becaues we have used Table as object name . 

            //create a new data adapter based on the specified entry.

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            DataGridView.Datasource = bs;
            
        }

    }
}
