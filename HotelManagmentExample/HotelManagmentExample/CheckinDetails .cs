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
    public partial class OrderProduct : Form
    {
        string conn = @"Data Source =DESKTOP-257J0L9; initial Catalog=customer; user id = sa ; password= sa9";
        public static string id;
        public static string name;
        public static string cuntery;
        public static string phone;
        public static string address;
        public static string gender;
        public static string roomtype;
        public static string roomNo;
        public static string personNo;
        public static string children;
        public static string stayingday;
        public OrderProduct()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh-mm-dd-mm-yyyy";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(conn);

                int id = Convert.ToInt32(textBox1.Text);
                string name = textBox2.Text;
                string cuntery = comboBox1.Text;
                int phone = Convert.ToInt32(textBox3.Text);
                string address = textBox4.Text;
                string gender = comboBox2.Text;
                string roomtype = comboBox3.Text;
                int roomNo = Convert.ToInt32(textBox5.Text);
                int personNo = Convert.ToInt32(textBox6.Text);
                string children = comboBox4.Text;
                string checkin = dateTimePicker1.Text;
                int stayin = Convert.ToInt32(textBox7.Text);
                string chectout = dateTimePicker2.Text;
                string query = string.Format("insert into GustInformation values({0},'{1}','{2}',{3},'{4}','{5}','{6}',{7},{8},'{9}','{10}',{11},'{12}')", id, name, cuntery, phone, address, gender, roomtype, roomNo, personNo, children, checkin, stayin, chectout);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                int result = cmd.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Sucessfully Ragestered");

            }
            catch (Exception ex)
               
            {

                
                MessageBox.Show(ex.Message);
            }
            clear();

          
            }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderProduct_Load(object sender, EventArgs e)
        {

        }
        void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = "";

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
        
    }
   
}
//, address, gender, roomtype, roomNo, personNo, children, stayingday, chectout