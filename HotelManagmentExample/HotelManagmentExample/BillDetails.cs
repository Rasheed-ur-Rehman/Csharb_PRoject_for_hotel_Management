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

    public partial class BillDetails : Form
    {
        int SimpleRoom = 20000;
        int Vip = 3500;
        int doublee = 18000;
        string conn = @"Data Source =DESKTOP-257J0L9; initial Catalog=customer; user id = sa ; password= sa9";

        DataClasses1DataContext bh = new DataClasses1DataContext();


        public BillDetails()
        {
            InitializeComponent();
        }

        private void BillDetails_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string query = string.Format("select * from GustInformation ");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox1.Items.Add(dr["id"].ToString());

            }


            connection.Close();
            if (textBox7.Text==SimpleRoom.ToString()) {

                textBox13.Text = "nice job" ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
            e.Graphics.DrawString("WELCOME TO HOTEL MANAGEMENT SYSTEM", new Font("Arial", 14, FontStyle.Bold), Brushes.Black
                , new Point(100, 20));
            e.Graphics.DrawString("PHONE NO  : 0581458020", new Font("Arial", 14, FontStyle.Bold), Brushes.Black
                , new Point(510, 60));

            e.Graphics.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 60));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(25, 110));

            e.Graphics.DrawString("Clint ID  : " + comboBox1.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 150));

            e.Graphics.DrawString("Clint Name  : " + textBox2.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 190));

            e.Graphics.DrawString("Clint Address: " + textBox5.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 230));

            e.Graphics.DrawString("Room type   : " + textBox7.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 270));

            e.Graphics.DrawString("Room No   : " + textBox8.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 310));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------",
               new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 330));

            e.Graphics.DrawString("Total   : " + textBox14.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, 360));

            e.Graphics.DrawString("Others charges   : " + textBox12.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, 400));

            e.Graphics.DrawString("__________",
               new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(430, 415));

            e.Graphics.DrawString("Total charges    : " + textBox13.Text.Trim(),
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, 450));



            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 490));

            e.Graphics.DrawString("Aurth Signatury. ",
                new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 550));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string query = string.Format("select * from GustInformation where id='" + comboBox1.Text + "'");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Name"].ToString();
                textBox3.Text = dr["Country"].ToString();
                textBox4.Text = dr["P_no"].ToString();
                textBox5.Text = dr["Address"].ToString();
                textBox7.Text=dr["Room_type"].ToString();
                textBox8.Text = dr["Roon_no"].ToString();
                textBox6.Text = dr["Gender"].ToString();
                textBox9.Text = dr["No_Person"].ToString();
                textBox10.Text = dr["children"].ToString();
                textBox11.Text=dr["stayin"].ToString();
                maskedTextBox1.Text=dr["chectin"].ToString();
        

            }

            if(textBox7.Text.Equals("VIPRoom")){
                int m = Convert.ToInt32(textBox11.Text);
                
                int total = Vip * m;
                textBox13.Text = total.ToString();

            } if (textBox7.Text.Equals("SimpleRoom"))
            {
                int mm = Convert.ToInt32(textBox11.Text);

                int totall = SimpleRoom * mm;

                textBox13.Text = totall.ToString();

            } if (textBox7.Text.Equals("DubelBed"))
            {

                int mn = Convert.ToInt32(textBox11.Text);
                int totalll=doublee*mn;
                textBox13.Text = totalll.ToString();
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
             
           
        }

        private void textBox12_KeyUp(object sender, KeyEventArgs e)
        {
            int m = Convert.ToInt32(textBox12.Text);
            int p = Convert.ToInt32(textBox13.Text);

            int total = p + m;
            textBox14.Text = total.ToString();
        }
    }
}
