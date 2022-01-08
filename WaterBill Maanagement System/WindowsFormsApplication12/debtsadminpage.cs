using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication12
{
    public partial class debtsadminpage : UserControl
    {
        public debtsadminpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
                con.Open();
                string query = "insert into Debts values ('" + serialtxt.Text + "', '" + debttxt.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                serialtxt.Clear();
                debttxt.Clear();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check your info Again!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
                con.Open();
                string query = "delete from Debts where SerialID = '" + serialtxt.Text + "' and months ='" + debttxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                serialtxt.Clear();
                debttxt.Clear();
                MessageBox.Show("The Bill has been Removed");
                con.Close();
               
            }
            catch (Exception)
            {
                MessageBox.Show(" please check SerialID and Date Again!");
            
            }
          
        }
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query2 = "select * from  Debts ";
            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
