using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
            slidepanel2.Height = button1.Height;
            slidepanel2.Top = button1.Top;
            homepageadmin1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = button1.Height;
            slidepanel2.Top = button1.Top;
            homepageadmin1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = button2.Height;
            slidepanel2.Top = button2.Top;
            conadminform1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel2.Height = button3.Height;
            slidepanel2.Top = button3.Top;
            debtsadminpage1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void debtsadminpage1_Load(object sender, EventArgs e)
        {

        }

        private void debtsadminpage1_Load_1(object sender, EventArgs e)
        {
       
        }
    }
}
