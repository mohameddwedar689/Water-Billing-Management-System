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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void adminpassw_Click(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true";
            SqlConnection cnn = new SqlConnection(connetionString);
            cnn.Open();
            string query = "Select  pass  from adminpass Where  pass = '" + adminpass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                adminhome ad1 = new adminhome();
                ad1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your Password");
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
