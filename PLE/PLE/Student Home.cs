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
    public partial class Student_Home : Form
    {
        public Student_Home(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN;
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentOverview SO = new StudentOverview(lb_userN.Text);
            SO.ShowDialog();
                
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestHome TH = new TestHome(lb_userN.Text);
            TH.ShowDialog();
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuizHome QH = new QuizHome(lb_userN.Text);
            QH.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye-Bye");
            Application.Exit();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator C = new Calculator(lb_userN.Text);
            C.ShowDialog();
        }
    }
}
