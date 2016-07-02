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
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form2(string userName)   //passing in value from form 1 (log in page username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\Access Database\EmployeeInfo.accdb;
                                            Persist Security Info=False;"; 
            //label displaying logged in user name from form 1 to form 2.

        }

        private void Form2_Load(object sender, EventArgs e)
        {   //using combo box to display data from the data base and a list box
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select FIRST_NAME from EmployeeData_Table";   //selecting our database table
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();    //this command reads the values from the database

                while (reader.Read())   //while read = true
                {   //this displays all first names values in our databas column and converts it to string
                    comboBox1.Items.Add(reader["FIRST_NAME"].ToString());   //displaying via combo box
                    listBox1.Items.Add(reader["FIRST_NAME"].ToString());    //displaying via list box

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();  //command to access database, variable 'command' is user declared, not a keyword but the rest is
                command.Connection = connection;    //in this case '.Conecction' is a keyword
                command.CommandText = "insert into EmployeeData_Table (FIRST_NAME,LAST_NAME) values('" + txt_Fname.Text + "','" + txt_Lname.Text + "')";   //writing a querry to access databas
                command.ExecuteNonQuery(); //executing querry - use this any time you want to insert, update or delete
                MessageBox.Show("data saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            
        }
        //editing data from database by using employee_id column
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update EmployeeData_Table set FIRST_NAME = '"+ txt_Fname.Text +"' ,LAST_NAME = '"+txt_Lname.Text+"'" +
                               "where Employee_ID ="+txt_EID.Text+""; //creating a string variable named 'query' to store our sql database command for easy execution
                MessageBox.Show(query);
                command.CommandText = query;   //using 'query' vairable to execute declared comand above
                command.ExecuteNonQuery();
                MessageBox.Show("data Edited");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        //deleting data from database by using employee_id column
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from EmployeeData_Table where Employee_ID = "+txt_EID.Text+"";
                MessageBox.Show(query);
                command.CommandText = query;   //using 'query' vairable to execute declared comand above
                command.ExecuteNonQuery();
                MessageBox.Show("data deleted");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using combo box to display data from the data base but this time showing more data in text boxes
            //this block of code can be easily recycled and only changed where needed like variable names and item names you chose
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table where FIRST_NAME = '" + comboBox1 .Text+ "' ";   //selecting our database table
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();    //this command reads the values from the database

                while (reader.Read())   
                {   //same results could be achived by making textbox.text = database info instead of string. both work
                    txt_EID.Text = reader["Employee_ID"].ToString();
                    txt_Fname.Text = reader["FIRST_NAME"].ToString();
                    txt_Lname.Text = reader["LAST_NAME"].ToString();    //using text box just to show for example
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table where FIRST_NAME = '" + listBox1.Text + "' ";   //selecting our database table
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();    //this command reads the values from the database

                while (reader.Read())
                {   //same results could be achived by making textbox.text = database info instead of string. both work
                    txt_EID.Text = reader["Employee_ID"].ToString();
                    txt_Fname.Text = reader["FIRST_NAME"].ToString();
                    txt_Lname.Text = reader["LAST_NAME"].ToString();    //using text box just to show for example
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        //displaying database info in a data grid view
        private void btn_loadTable_Click(object sender, EventArgs e)
        {
             try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table";   //selecting our database table, if you only want to show select data in the grid view
                command.CommandText = query;                        // change your SQL qury to filter the information you want
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command); //'dataAdapter != keyword, self decalred vairbable
                DataTable dataTable = new DataTable();  //'dataTable != keyword
                dataAdapter.Fill(dataTable);    //using the data adapter to fill in the data table. '.Fill' = keyword
                dataGridView1.DataSource = dataTable;  // making the gird view = the data table by usinsg keyword '.DataSource'
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        
        }
        //displaying data vai a chart
        private void btn_loadChart_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table";   //selecting our database table
                command.CommandText = query;                        // change your SQL qury to filter the information you want
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chart1.Series["Country"].Points.AddXY(reader["Country"].ToString(), reader["FIRST_NAME"].ToString());  
                                                                                //use this to plot points in chart, series = what ever you called it
                }                                                               //'Points.AddXY(reader["Country"]' code to ploint points on graph, reader is self
                                                                                //declared vairable and within [] = column of data i want to display
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides the current form open   
            Form3 f3 = new Form3();    // passing user onto form 3 where they can see who is a client and who isnt
            f3.ShowDialog();
        }
    }
}
