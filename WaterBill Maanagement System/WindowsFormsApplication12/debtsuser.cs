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
    public partial class debtsuser : UserControl
    {
        public debtsuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query = " select D.SerialID,D.months,c.price from Debts D inner join consumption c on D.SerialID=c.SerialID where D.SerialID= '" + serialtxt.Text + "'and D.months = c.months";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("NO Due payment requered");


            }
            else
            {

                dataGridView1.DataSource = dt;

            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
