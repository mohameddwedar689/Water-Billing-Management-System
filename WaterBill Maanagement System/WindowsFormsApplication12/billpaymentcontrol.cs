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
    public partial class billpaymentcontrol : UserControl
    {
        public billpaymentcontrol()
        {
            InitializeComponent();
        }

        private void billpaymentcontrol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7T5LDH2; Initial Catalog=waterbillproject; Integrated Security = true");
            con.Open();
            string query2 = "select c.SerialID,c.UserName,c.Address,s.months,s.consumptionamount,s.segmentNumber,s.price from CustomerInfo c inner join consumption s on c.SerialID = s.SerialID where c.SerialID = '" + serialtxt.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Please Enter the right SerialID");
               
                
            }
            else
            {

                dataGridView1.DataSource = dt;
            
            }
            
            
            
            






        }

        private void serialtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width , this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp , new Rectangle(0,0, this.dataGridView1.Width , this.dataGridView1.Height));
            e.Graphics.DrawImage(objBmp ,50,200);
            e.Graphics.DrawString(label1.Text, new Font("Verdana",20,FontStyle.Bold),Brushes.Black, new Point(300,30));
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
    }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        }
}
