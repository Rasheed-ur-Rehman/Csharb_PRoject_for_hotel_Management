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
    public partial class StaffDetails : Form
    {
        string conn = @"Data Source=DESKTOP-257J0L9 ; initial Catalog=customer; user id=sa; password=sa9";
        DataClasses2DataContext db = new DataClasses2DataContext();
        public StaffDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string query = string.Format("select * from staffdetail");
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sad = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sad.Fill(dt);
                dataGridView1.DataSource = dt;

                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                textBox4.Text = "12000";
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox1.Text;
                string Address = textBox2.Text;
                string education = textBox3.Text;
                string Experience = textBox4.Text;
                string Joining = textBox6.Text;
                string basicSalary = textBox5.Text;
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string query = string.Format("insert into staffdetail values('{0}','{1}','{2}','{3}','{4}')", Name, Address, education, Joining, basicSalary);
                SqlCommand cmd = new SqlCommand(query, connection);
                int result = cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Successfully Created");
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(conn);
                string query = string.Format("delete from staffdetail where id='" + textBox7.Text + "' ");
                SqlCommand cmd = new SqlCommand(query, cn1);
                SqlDataAdapter asd = new SqlDataAdapter(query, cn1);
                cn1.Open();
                DataSet dt = new DataSet();
                asd.Fill(dt, "C_Name");

                dataGridView1.DataSource = dt.Tables[0];
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string query = "select * from staffdetail";
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

        public void record()
        {

        }
        void clear()
        {

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                string query = "select * from staffdetail where id='" + textBox7.Text + "'";
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

        private void StaffDetails_Load(object sender, EventArgs e)
        {


        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (textBox4.Text == Text)
            {
                textBox8.Visible = true;
                label7.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == Text)
            {
                textBox8.Visible = true;
                label7.Visible = true;
                textBox8.Show();
            }
        }
    }
}
