﻿using System;
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
    public partial class OverView : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public OverView()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PLE\PLE database.accdb;
                                            Persist Security Info=False;";
        }

        private void OverView_Load(object sender, EventArgs e)
        {

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT USER_ACCOUNT.UserName, USER_ACCOUNT.User_ID, FINAL_TEST.F_Test_ID, FINAL_TEST.[Test 1], FINAL_TEST.[Test 2], FINAL_TEST.[Test 3] " +
                                "FROM FINAL_TEST INNER JOIN USER_ACCOUNT ON FINAL_TEST.[F_Test_ID] = USER_ACCOUNT.[F_Test_ID];";
                command.CommandText = querry;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_test.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT USER_ACCOUNT.User_ID, USER_ACCOUNT.UserName, QUIZ.Quiz_ID, QUIZ.[Quiz 1], QUIZ.[Quiz 2], QUIZ.[Quiz 3], QUIZ.[Quiz 4], QUIZ.[Quiz 5]" +
                                "FROM QUIZ INNER JOIN USER_ACCOUNT ON QUIZ.[Quiz_ID] = USER_ACCOUNT.[Quiz_ID];";
                command.CommandText = querry;

                OleDbDataAdapter da2 = new OleDbDataAdapter(command);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView_test.DataSource = dt2;

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
