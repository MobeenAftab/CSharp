using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PC_Clinic
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PC Clinic\PCClinic.accdb; Persist Security Info=False;";
                                           
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection Successful";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Technician_Table where College_ID='" + txt_username.Text + "' and Full_Name='" + txt_password.Text + "'";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    DatabaseMain Form2 = new DatabaseMain(txt_username.Text);
                    Form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid log in, please try again");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error " + ex);
                
            }
            {

            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
