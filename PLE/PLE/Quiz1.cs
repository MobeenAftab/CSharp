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
    public partial class Quiz1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Quiz1(string userN)
        {
            InitializeComponent();
            //lb_userN2.Text= userN;
            lb_userN.Text = userN+"_Q";
            
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;";
        }
        
        int score = 0;
        int i = -1;
        int a = 0;
        
        

        string[] questions = new string[]
        {
            "A worker is pulling on the handle of a cart, the cart cab best be described as a force having",
            "A car travels 90 meters due north in 15 seconds; it then travels another 40 meters south in 5 seconds. " +
            "Give the cars average velocity during this 20 second interval.",
            "A brick falls from rest freely, calculate how far the brick will travel in 3 seconds",
            "If there are no forces acting on an object currently in motion, the object will",
            "20 newton’s are pulling down a 5 kilogram mass held by a spring scale. What is the size of the force exerted by the mass on the spring scale?"
        };

        string[] possibleAnswers = new string[] 
        {
            "Magnitude", "Direction", "Magnitude and direction", "neither",
            "2.5m/s", "6m/s", "9m/s", "1m/s",
            "15m", "35m", "44m", "90m",
            "Slow down and stop", "Change direction", "Accelerate uniformly", "Continue with constant velocity",
            "50N", "20N", "60N", "10N"

        };

        string[] quizAnswers = new string[]
        {
            "Magnitude and direction",
            "2.5m/s",
            "44m",
            "Continue with constant velocity",
            "20N"

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

                    string querry = "update QUIZ set Quiz1='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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

                string querry = "update QUIZ set Quiz1='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";
               
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

        private void Quiz1_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            btn_submit.Visible = false;
            btn_finish.Enabled = false;
            btn_finish.Visible = false;
        }
    }
}
