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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string query = "Select UserName, passwords from CustomerInfo Where UserName = '" + textBox1.Text.Trim() + "' and passwords = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Home H = new Home();
                H.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your Username and Password");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminlogin Al = new adminlogin();
            Al.Show();
            this.Hide();
        }
    }
}
