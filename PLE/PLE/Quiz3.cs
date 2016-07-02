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
    public partial class Quiz3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Quiz3(string userN)
        {
            InitializeComponent();
            lb_userN.Text = userN + "_Q";
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;";
        }

        int score = 0;
        int i = -1;
        int a = 0;

        string[] questions = new string[]
        {
            "Which one of the following is a scalar quantity?",
            "Which one is a unit of power?",
            "Calculate the decrease of potential energy on an object of mass 20kg falling from a height of 50cm",
            "An object of 15N is elevated from ground to 0.22m above its resting position. Calculate the objects gravitational potential energy",
            "The kinetic energy of a free falling object can be described as "
        };

        string[] possibleAnswers = new string[] 
        {
            "Displacement", "Acceleration", "Electric field", "Work",
            "Joule", "Watt", "Newton m/s", "Horsepower",
            "98J", "900J", "980J", "980J",
            "30J", "40J", "3.3J", "10J",
            "Decreasing", "Increasing", "No change", "None"

        };

        string[] quizAnswers = new string[]
        {
            "Work",
            "Watt",
            "98J",
            "3.3J",
            "No change"
        };

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_userN2.Visible = false;

            if (i == questions.Length - 1)
            {
                MessageBox.Show("the quiz has ended, here is your final score :" + score);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string querry = "update QUIZ set Quiz3='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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
                Student_Home QH1 = new Student_Home(user);
                QH1.ShowDialog();

            }
            else if (i < questions.Length)
            {
                i++;
                //txtScore.Text = score;

                lb_question.Text = questions[i];

                RBA.Text = possibleAnswers[a];
                a++;
                RBB.Text = possibleAnswers[a];
                a++;
                RBC.Text = possibleAnswers[a];
                a++;
                RBD.Text = possibleAnswers[a];
                a++;

                btn_start.Visible = false;
                btn_start.Enabled = false;
                btn_submit.Visible = true;
                btn_submit.Enabled = true;
                btn_finish.Enabled = true;
                btn_finish.Visible = true;
            }

            else
            {
                MessageBox.Show("the quiz has ended, here is your final score :" + score);
                Application.Exit();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (getSelectedAnswer().Equals(quizAnswers[i]))
            {
                //MessageBox.Show("Correct");
                score++;
                lb_score.Text = Convert.ToString(score);
                btn_submit.Enabled = false;
                btn_submit.Visible = false;
                btn_start.Visible = true;
                btn_start.Enabled = true;
                btn_start.Text = "Next";
            }
            else
            {
                //MessageBox.Show("Incorrect");
                //score--;
                //txtScore.Text = Convert.ToString(score);
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
            return "";
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the quiz has ended, here is your final score: " + score);
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "update QUIZ set Quiz3='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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
            Student_Home QH1 = new Student_Home(user);
            QH1.ShowDialog();
        }

        private void Quiz3_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            btn_submit.Visible = false;
            btn_finish.Enabled = false;
            btn_finish.Visible = false;
        }
    }
}
