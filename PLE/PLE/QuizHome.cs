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
    public partial class QuizHome : Form
    {
        public QuizHome(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN;
        }

        private void btn_quiz1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz1 Q1 = new Quiz1(lb_userN.Text);
            Q1.ShowDialog();
        }

        private void btn_quiz2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz2 Q2 = new Quiz2(lb_userN.Text);
            Q2.ShowDialog();
        }

        private void btn_quiz3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz3 Q3 = new Quiz3(lb_userN.Text);
            Q3.ShowDialog();
        }

        private void btn_quiz4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz4 Q4 = new Quiz4(lb_userN.Text);
            Q4.ShowDialog();
        }

        private void btn_quiz5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quiz5 Q5 = new Quiz5(lb_userN.Text);
            Q5.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Home T3 = new Student_Home(lb_userN.Text);
            T3.ShowDialog();
        }
    }
}
