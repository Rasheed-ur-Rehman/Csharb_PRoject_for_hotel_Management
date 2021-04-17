using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentExample
{
    public partial class CustomerDetails : Form
    {
        string connection = @"Data Source =DESKTOP-257J0L9; initial Catalog=customer; user id = sa ; password= sa9"; 
        DataClasses1DataContext db = new DataClasses1DataContext();

        
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            using(db=new DataClasses1DataContext())
            {
                CustomerDetail cc = new CustomerDetail()
                {
                    Cus_id=textBox1.Text,
                    Cus_Name=textBox2.Text,
                    Cus_Address=textBox3.Text,
                    Cus_Phone=textBox4.Text,
                    Cus_dateofbirth=maskedTextBox1.Text,
                    Cus_Email=textBox6.Text


                };
                //db.CustomerDetails.InsertOnSubmit(cc);
               

            }
            //record();
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                string address = textBox3.Text;
                string phone = textBox4.Text;
                string dob = maskedTextBox1.Text;
                string email = textBox6.Text;


                SqlConnection conn = new SqlConnection(connection);
                string query = string.Format("insert into customer1 values({0},'{1}','{2}','{3}','{4}','{5}')", id, name, address, phone, dob, email);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int result = cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Sucessfully Ragestered");


                clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Field Required Fill the form ");
                clear();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(connection);
                string query = string.Format("delete from customer1 where id='" + textBox7.Text + "' ");
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(connection);
                string query = string.Format("select * from customer1 ");
                SqlCommand cmd = new SqlCommand(query, cn1);
                SqlDataAdapter asd = new SqlDataAdapter(query, cn1);
                cn1.Open();
                DataSet dt = new DataSet();
                asd.Fill(dt, "C_Name");

                dataGridView1.DataSource = dt.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        void clear()
        {
         textBox1.Text=textBox2.Text=textBox3.Text=textBox4.Text=textBox6.Text=textBox7.Text="";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connection);
            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from customer1 where C_Name like('" + textBox7.Text + "%')";
            //cmd.ExecuteNonQuery();
            //DataTable tb = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(tb);
            //dataGridView1.DataSource = tb;

            //conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn1 = new SqlConnection(connection);
                string query = string.Format("select * from customer1 where  id ='" + textBox7.Text + "'");
                SqlCommand cmd = new SqlCommand(query, cn1);
                SqlDataAdapter asd = new SqlDataAdapter(query, cn1);
                cn1.Open();
                DataSet dt = new DataSet();
                asd.Fill(dt, "C_Name");

                dataGridView1.DataSource = dt.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
      
    }
   
}