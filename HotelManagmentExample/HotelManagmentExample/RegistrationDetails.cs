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

namespace HotelManagmentExample
{
    public partial class RegistrationDetails : Form
    {
        string conn = @"Data Source=DESKTOP-257J0L9; initial Catalog= customer ; user id = sa ; password= sa9";
        DataClasses2DataContext ddd = new DataClasses2DataContext();
    
        public RegistrationDetails()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(conn);

                string FirstName = textBox1.Text;
                string LastName = textBox2.Text;
                string contect = textBox3.Text;
                string address = textBox4.Text;
                string email = textBox5.Text;
                string country = textBox6.Text;
                string jobtitle = textBox7.Text;

                connection.Open();
                string query = string.Format("insert into registration values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", FirstName, LastName, contect, address, email, country, jobtitle);
                SqlCommand cmd = new SqlCommand(query, connection);

                int result = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sucessfully Registered");

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void record()
        {
            using(ddd=new DataClasses2DataContext())
            {
                dataGridView1.DataSource = ddd.RegistrationDetails;
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(conn);
                string query = string.Format("delete from registration where Firstname='" + textBox1.Text + "' ");
                SqlCommand cmd = new SqlCommand(query, cn1);
                SqlDataAdapter asd = new SqlDataAdapter(query, cn1);
                cn1.Open();
                DataSet dt = new DataSet();
                asd.Fill(dt, "C_Name");

         


                MessageBox.Show("Deleted");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
        }
        void clear() {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string query = "select * from registration";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sad = new SqlDataAdapter(query, connection);
                DataSet dt = new DataSet();
                sad.Fill(dt, "staffdetail");
                dataGridView1.DataSource = dt.Tables[0];

                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void RegistrationDetails_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string query = string.Format("select * from registration");
            SqlCommand cmd = new SqlCommand(query,connection);
            SqlDataAdapter sad = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
   
}
