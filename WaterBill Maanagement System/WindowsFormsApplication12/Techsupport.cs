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
    public partial class Techsupport : UserControl
    {
        public Techsupport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query = "insert into techsupport values '"+textBox1.Text+"'";
            MessageBox.Show("We have received your problem and will respond as soon as possible");
            textBox1.Clear();

        }
    }
}
