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
    public partial class Admin : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Admin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string querry = "insert into ADMIN (admin_ID,admin_pass) values('"+txt_id.Text+"', '"+txt_pass.Text+"')";
                command.CommandText = querry; 

                command.ExecuteNonQuery();
             
                lb_check.Text = "Save Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "update ADMIN set admin_pass='" + txt_pass.Text + "' where admin_ID='" + txt_id.Text + "' ";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                lb_check.Text = "Edit Successful";
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

                string querry = "delete from ADMIN where admin_ID='" + txt_id.Text + "' ";
                command.CommandText = querry;

                command.ExecuteNonQuery();
                lb_check.Text = "Delete Successful";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        { 
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select admin_ID from ADMIN";
                command.CommandText = querry;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select * from ADMIN where admin_ID= '" + listBox1.Text + "'";
                command.CommandText = querry;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txt_id.Text = reader["admin_ID"].ToString();
                    txt_pass.Text = reader["admin_pass"].ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
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
