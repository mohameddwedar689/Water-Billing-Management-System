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

namespace WindowsFormsApplication12
{
    public partial class signup : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Insert into Table CustomerInfo
            SqlCommand cmd = new SqlCommand("insert into CustomerInfo values ('" + textBox6.Text + "', '" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            // object from Home Screen Page
            Home H = new Home();
            H.Show();
            this.Hide();
            
        }
    }
}
