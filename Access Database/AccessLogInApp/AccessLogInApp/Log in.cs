using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
 
namespace AccessLogInApp
{
    public partial class Form1 : Form
    {
        //connection string for access database (global decleration
        private OleDbConnection connection = new OleDbConnection();
        //variable 'connection' is a self declared variable not a keyword so you could rename it anything you wish
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\Access Database\EmployeeInfo.accdb;
                                            Persist Security Info=False;";      //database file path
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try     //first attempt to connect to database
            {  
                connection.Open();  //opeing database
                checkConnection.Text = "Connection Successful"; //testing database connection with lable
                connection.Close();

            }
            catch(Exception ex) //catch exeption in case database error occurs
            {
                MessageBox.Show("Eroor " + ex); //shows errors on pop up 
            }
        }

        //programing log in button to check database for valid log in username and password
        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();  //command to access database, variable 'command' is user declared, not a keyword but the rest is
            command.Connection = connection;    //in this case '.Conecction' is a keyword
            command.CommandText = "select * from EmployeeData_Table where Username='"+ txt_username.Text + "' and Password='"+ txt_password.Text +"'";   //writing a querry to access databas
            OleDbDataReader reader = command.ExecuteReader();    //executing querry - use this any time you want to get information from your database, goes with select statment 'reader' != keyword
            
            int count = 0;  //count the number of results coming from the querry
            while (reader.Read())   //unless read is true it will continue reading in database
            {
                count = count + 1; //could be re-written as count++ to increment by 1
            }
            //TODO a second log in attempt crashes the system. might want to watch out for that**
            //checking valid log in and opeing new form
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct");
                connection.Close(); //close database after log in
                connection.Dispose();  //gets rid of all the resources used in this form  
                this.Hide(); //hides the current form open   
                Form2 f2 = new Form2(txt_username.Text);    //transfer user login into second form. 'f2' is object i created based on the second form, could rename to anything //(txt_username.Text) = passing username to form 2
                f2.ShowDialog();    //brings up the second form. use this block of code to close and open forms
            }
            else  if (count > 1)  //this if statment will chck the database to see if a user name and password have been repeated, acts as a saftey net
            {
                MessageBox.Show("Duplicate and password ");
            }
            else
            {
                MessageBox.Show("Username and password not correct");
            }

            
        }
    }
}
