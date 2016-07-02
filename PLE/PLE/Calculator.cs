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
    public partial class Calculator : Form
    {
        public Calculator(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN;
        }

        int D;
        int V;
        int T;

        private void btn_cal_Click(object sender, EventArgs e)
        {
            

            if(rb_D.Checked == true)
            {
               
                D = (Convert.ToInt32(txt_v.Text) * Convert.ToInt32(txt_T.Text));
                lb_ans.Text = "The Answer is: " + Convert.ToString(D);
                //MessageBox.Show("the answer is " + D);
            }
            else if (rb_T.Checked == true)
            {
                T = (Convert.ToInt32(txt_D.Text) / Convert.ToInt32(txt_v.Text));
                lb_ans.Text = "The Answer is: " + Convert.ToString(T);
                //MessageBox.Show("the answer is " + T);
            }
            else if (rb_v.Checked == true)
            {
                V = (Convert.ToInt32(txt_D.Text) / Convert.ToInt32(txt_T.Text));
                lb_ans.Text = "The Answer is: " + Convert.ToString(V);
                //MessageBox.Show("the answer is " + V);
            }
            else
            {
                MessageBox.Show("please select a formula to calculate");
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Home SH = new Student_Home(lb_userN.Text);
            SH.ShowDialog();
        }
    }
}
