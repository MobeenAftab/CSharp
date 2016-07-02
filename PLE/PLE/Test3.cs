using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PLE
{
    public partial class Test3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Test3(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN + "_F";
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;";
        }

        int score = 0;
        int i = -1;
        int q = 1;

        string[] questions = new string[]
        {
          "A", "B", "C", "D", 
          "A", "B", "C", "D",
          "A", "B", "C", "D",
          "A", "B", "C", "D",
          "A", "B", "C", "D"
        };

        string[] possibleAnswers = { "A", "B", "C", "D", "E" };

        string[] quizAnswers = new string[]
        {
          "E", "A", "C", "C", 
          "C", "D", "B", "D",
          "B", "C", "B", "E",
          "D", "E", "D", "A",
          "A", "D", "B", "B"
        };

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_questionNumber.Text = Convert.ToString(q);

            if (i == questions.Length - 1)
            {
                MessageBox.Show("the Test has ended, here is your final score :" + score);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string querry = "update FINAL_TEST set Test3='" + lb_score.Text + "' where F_test_ID='" + lb_userN.Text + "'";

                    command.CommandText = querry;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();
                }

                string user = lb_userN.Text;
                user = user.Remove(user.Length - 2);
                connection.Dispose();
                this.Hide();
                TestHome TH = new TestHome(user);
                TH.ShowDialog();

            }
            else if (i < questions.Length)
            {
                i++;

                RBA.Text = possibleAnswers[0];
                RBB.Text = possibleAnswers[1];
                RBC.Text = possibleAnswers[2];
                RBD.Text = possibleAnswers[3];
                RBE.Text = possibleAnswers[4];

                btn_start.Visible = false;
                btn_start.Enabled = false;
                btn_submit.Visible = true;
                btn_submit.Enabled = true;
                btn_finish.Enabled = true;
                btn_finish.Visible = true;
            }
            else
            {
                MessageBox.Show("the test has ended, here is your final score :" + score);
                Application.Exit();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (getSelectedAnswer().Equals(quizAnswers[i]))
            {

                score++;
                q++;
                lb_score.Text = Convert.ToString(score);
                btn_submit.Enabled = false;
                btn_submit.Visible = false;
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_start.Text = "Next";
            }
            else
            {
                q++;
                btn_submit.Enabled = false;
                btn_submit.Visible = false;
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_start.Text = "Next";
            }
        }

        string getSelectedAnswer()
        {
            if (RBA.Checked)
                return RBA.Text.ToString();
            if (RBB.Checked)
                return RBB.Text.ToString();
            if (RBC.Checked)
                return RBC.Text.ToString();
            if (RBD.Checked)
                return RBD.Text.ToString();
            if (RBE.Checked)
                return RBE.Text.ToString();
            return "";
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the test has ended, here is your final score: " + score);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "update FINAL_TEST set Test3='" + lb_score.Text + "' where F_Test_ID='" + lb_userN.Text + "'";

                command.CommandText = querry;
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }

            string user = lb_userN.Text;
            user = user.Remove(user.Length - 2);
            connection.Dispose();
            this.Hide();
            TestHome TH = new TestHome(user);
            TH.ShowDialog();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"M:\Projects\Software Development\C#\PLE\sqa\2012.pdf");

        }

        private void Test3_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            btn_submit.Visible = false;
            btn_finish.Enabled = false;
            btn_finish.Visible = false;
        }

    }
}
