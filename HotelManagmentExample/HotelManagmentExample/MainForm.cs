using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentExample
{
    public partial class MainForm : Form

    {
        public static string na;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;

            timer1.Start();

            CustomerDetails cus = new CustomerDetails();
            cus.MdiParent = this;
            cus.StartPosition = FormStartPosition.Manual;
            cus.Location =new  Point(10, 160);
            cus.Show();


        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDetails cc = new CustomerDetails();
            cc.MdiParent = this;
            cc.StartPosition = FormStartPosition.Manual;
            cc.Location = new Point(10,160);
            cc.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffDetails st = new StaffDetails();
            st.MdiParent = this;
            st.StartPosition = FormStartPosition.Manual;
            st.Location = new Point(10,160);
            st.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProduct o = new OrderProduct();
            o.MdiParent = this;
            o.StartPosition = FormStartPosition.Manual;
            o.Location = new Point(10, 150);
            o.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationDetails r = new RegistrationDetails();
            r.MdiParent = this;
            r.StartPosition = FormStartPosition.Manual;
            r.Location = new Point(10,160);
            r.Show();

           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }

            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }

            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if(pictureBox6.Visible==true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BillDetails db = new BillDetails();
            db.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void staffToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void staffToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void staffToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
