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
    public partial class Quiz2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Quiz2(string userN)
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
            "A force of 10 N accelerates an object at 5 m/s2, what amount of force would be required to move the same object at 1m/s2",
            "A 2.0x10^3 Kg mass object is traveling at a constant speed of 12m/s around a circular curve of radius 30 meters. " +
            " What is the size of the objects acceleration as it goes round the curve.",
            "Work done against friction on a horizontal sliding box depends mostly on",
            "An object of mass 1200 Kg is traveling at 10m/s2 collides with a wall and is brought to rest in 0.10s. give the average size of force acting on the object bringing it to rest.",
            "An object traveling at 4m/s travels 72m in what time?"
        };

        string[] possibleAnswers = new string[] 
        {
            "1N", "2N", "4N", "10N",
            "0.4m/s2", "800m/s2", "4.8m/s2", "100m/s2",
            "Time taken", "Speed of the box", "Direction of motion", "Distance the box is moved",
            "1.2x10^5N", "1.2x10^1N", "1.2x10^6N", "1.2x10^7N",
            "38s", "200s", "18s", "23s"

        };

        string[] quizAnswers = new string[]
        {
            "2N",
            "4.8m/s2",
            "Speed of the box",
            "1.2x10^5N",
            "18s"
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

                    string querry = "update QUIZ set Quiz2='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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

                string querry = "update QUIZ set Quiz2='" + lb_score.Text + "' where Quiz_ID='" + lb_userN.Text + "'";

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

        private void Quiz2_Load(object sender, EventArgs e)
        {
            btn_submit.Enabled = false;
            btn_submit.Visible = false;
            btn_finish.Enabled = false;
            btn_finish.Visible = false;
        }
    }
}
