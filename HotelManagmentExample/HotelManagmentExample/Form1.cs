using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentExample
{
    public partial class Form1 : Form
    {
        public static string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            if(textBox1.Text=="Admin" && textBox2.Text=="admin")
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Email/Password requride");
            }



            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int value = progressBar1.Value;
            if (value > 99)
            {
                timer1.Enabled = false;
                this.panel1.Hide();
                this.Show();


            }
            else
            {
                value = +5;
                progressBar1.Value += value;

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}