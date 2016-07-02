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
    public partial class AdminAcc : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public AdminAcc()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;"; 
        }

        private void StudentAcc_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select UserName from USER_ACCOUNT";
                command.CommandText = querry;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into USER_ACCOUNT (User_ID, UserName, stu_pass, F_Test_ID, Quiz_ID)" + 
                     "values ('" + txt_id.Text + "', '" + txt_username.Text + "', '" + txt_password.Text + "', '" + txt_test.Text + "', '" + txt_quiz.Text + "')";

                command.ExecuteNonQuery();
                //MessageBox.Show("data saved");
                lb_save.Text = "Save Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
      
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "update USER_ACCOUNT set UserName='" + txt_username.Text + "' ,stu_pass='" + txt_password.Text + "'," +
                    "F_Test_ID='" + txt_test.Text + "',Quiz_ID='" + txt_quiz.Text + "' where User_ID=" + txt_id.Text + " ";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                lb_edit.Text = "Edit Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "delete from USER_ACCOUNT where User_ID=" + txt_id.Text + " ";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                lb_del.Text = "Delete Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select * from USER_ACCOUNT where UserName= '" + comboBox1.Text + "'";
                command.CommandText = querry;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_id.Text = reader["User_ID"].ToString();
                    txt_username.Text = reader["UserName"].ToString();
                    txt_password.Text = reader["stu_pass"].ToString();
                    txt_test.Text = reader["F_Test_ID"].ToString();
                    txt_quiz.Text = reader["Quiz_ID"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select * from USER_ACCOUNT";
                command.CommandText = querry;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_id.Text = row.Cells[0].Value.ToString();
                txt_username.Text = row.Cells[1].Value.ToString();
                txt_password.Text = row.Cells[2].Value.ToString();
                txt_test.Text = row.Cells[3].Value.ToString();
                txt_quiz.Text = row.Cells[4].Value.ToString();
            }
             */
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;

            foreach(DataGridViewCell selectedCell in dataGridView1.SelectedCells) 
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                txt_id.Text = row.Cells[0].Value.ToString();
                txt_username.Text = row.Cells[1].Value.ToString();
                txt_password.Text = row.Cells[2].Value.ToString();
                txt_test.Text = row.Cells[3].Value.ToString();
                txt_quiz.Text = row.Cells[4].Value.ToString();
            }
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            this.Hide();
            Admin_Home AH = new Admin_Home();
            AH.ShowDialog();
        }
    }
}
