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
    public partial class Quiz5 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Quiz5(string userN)
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
           "A charge of 6.242x10^18 electrons is about the same as ",
           "Farad is a unit of ",
           "An object which is elevated above sea level is said to have what kind of energy",
           "Materials which light cannot penetrated are referred to as",
           "What beam of light will remain the same distance apart?"
        };

        string[] possibleAnswers = new string[] 
        {
           "1 Volt", "1 coulomb", "1 ampere", "10 coulomb",
           "Capacitance", "Current", "Watt", "Charge",
           "Sound", "Thermal", "Kinetic", "Potential",
           "penumbra", "Opaque", "Transparent", "Translucent",
           "Convergent", "Ellipse", "Parallel", "Divergent"
        };

        string[] quizAnswers = new string[]
        {
            "1 coulomb",
            "Capacitance",
            "Potential",
            "Opaque",
            "Parallel"
        };

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (i == questions.Length - 1)
            {
                MessageBox.Show("the quiz has ended, here is your final score :" + score);
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    string querry = "update QUIZ set Quiz5='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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

                string querry = "update QUIZ set Quiz5='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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

        private void Quiz5_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            btn_submit.Visible = false;
            btn_finish.Enabled = false;
            btn_finish.Visible = false;
        }
    }
}
