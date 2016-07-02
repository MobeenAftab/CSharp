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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                lb_check.Text = "Connection Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM USER_ACCOUNT WHERE Username='" + txt_username.Text + "' and stu_pass='" + txt_password.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count++;
                
            }
            if (count == 1)
            {
                MessageBox.Show("Student Username and password is correct");
                string userN = txt_username.Text;
                connection.Close();
                connection.Dispose();
                this.Hide();
                Student_Home ST = new Student_Home(userN);
                ST.ShowDialog();
                
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate and password ");
            }
            else
            {
                MessageBox.Show("Username and password not correct");
            }

            connection.Close();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM ADMIN WHERE Admin_ID='" + txt_username.Text + "' and admin_pass='" + txt_password.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count++;
                
            }
            if (count == 1)
            {
                MessageBox.Show("Admin Username and password is correct");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Admin_Home AH = new Admin_Home();
                AH.ShowDialog();
                
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate and password ");
            }
            else
            {
                MessageBox.Show("Username and password not correct");
            }

            connection.Close();
               
        }
    }
}
  