using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLE
{
    public partial class TestHome : Form
    {
        public TestHome(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN;
        }

        private void btn_test1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test1 T1 = new Test1(lb_userN.Text);
            T1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test2 T2 = new Test2(lb_userN.Text);
            T2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test3 T3 = new Test3(lb_userN.Text);
            T3.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Home T3 = new Student_Home(lb_userN.Text);
            T3.ShowDialog();
        }
    }
}
