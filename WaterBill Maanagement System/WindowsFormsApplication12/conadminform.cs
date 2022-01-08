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
    public partial class conadminform : UserControl
    {


        public conadminform()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
                con.Open();
                string query = "exec usp_insert '" + textBox1.Text + "', '" + textBox4.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Please Check your info Again!");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query2 = "select SerialID,months,consumptionamount,segmentNumber from consumption ";
            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query = "delete from consumption where SerialID = '" + textBox1.Text + "' and months ='" + textBox4.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("The Bill has been Removed");
            textBox1.Clear();
            textBox4.Clear();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query = "delete from consumption where SerialID = '" + textBox1.Text + "' and months ='" + textBox4.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("The Bill has been Removed");
            textBox1.Clear();
            textBox4.Clear();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
               
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox3.Clear();
                    return;

                }
                else 
                {
                    double x;
                    x = double.Parse(textBox2.Text);
                    double new_x;
                    new_x = x;
                    
                    
                    if (new_x <= 20.00 && new_x >= 0.00)
                    {
                        textBox3.Text = "1";
                    }
                    else if (new_x > 20.00 && new_x <= 40.00)
                    {
                        textBox3.Text = "2";
                    }
                    else if (new_x > 40.00 && new_x <= 80.00)
                    {
                        textBox3.Text = "3";
                    }
                    else if (new_x > 80.00 && new_x <= 120.00)
                    {
                        textBox3.Text = "4";
                    }
                    else if (new_x > 120.00 && new_x <= 160.00)
                    {
                        textBox3.Text = "5";
                    }
                    else
                    {
                        textBox3.Text = "6";
                    }
                }
            
            

        }


    }
}
