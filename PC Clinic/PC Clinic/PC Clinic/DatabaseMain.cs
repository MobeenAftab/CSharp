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
    public partial class DatabaseMain : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public DatabaseMain(string txt_username)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\PC Clinic\PCClinic.accdb; Persist Security Info=False;";
            lb__userName.Text = "Welcome user: " + txt_username;
        }

        private void DatabaseMain_Load(object sender, EventArgs e)
        {//cannot add second list box as this here will only allowe me to select one table source. if i had another form there would be no problem
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Technician_Table";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {   //list box controller
                    listBox1.Items.Add(reader["Full_Name"].ToString());

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }

        private void btn_loadStatus_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Ticket_Table WHERE (((ticket_Table.Status)=no))";   
                command.CommandText = query;                        
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command); 
                DataTable dataTable = new DataTable();  
                dataAdapter.Fill(dataTable);    
                dataGridView1.DataSource = dataTable; 
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
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
                command.CommandText = "insert into Technician_Table (College_ID,Full_Name) values('" + txt_techID.Text + "','" + txt_techName.Text + "')";
                command.ExecuteNonQuery();
                lb_action.Text = "data saved";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
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
                string query = "select * from Technician_Table where Full_Name = '" + listBox1.Text + "' ";   //selecting our database table
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();    //this command reads the values from the database

                while (reader.Read())
                {   //same results could be achived by making textbox.text = database info instead of string. both work
                    txt_techID.Text = reader["College_ID"].ToString();
                    txt_techName.Text = reader["Full_Name"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connection.Close();
            }
        }

        private void btn_ClientSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Customer_Table (Student_ID,Client_Full_Name,Email,Telephone) values('" + txt_studentID.Text + "','" + txt_sname.Text + "','" + txt_email.Text + "'," + txt_phone.Text + ")";
                //Email,Telephone ,'" + txt_email.Text + "'," + txt_phone + "
                command.ExecuteNonQuery();
                MessageBox.Show("data saved");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
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
                string query = "delete from Technician_Table where College_ID = '" + txt_techID.Text + "'"; // TODO i think i need '' around the "" because this is not an int, its text
                MessageBox.Show(query);
                command.CommandText = query;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Technician_Table set Full_Name = '" + txt_techName.Text + "' where college_ID ='" + txt_techID.Text + "'";
                MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("data Edited");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_false_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Ticket_Table WHERE (((Ticket_Table.Status)=no))";   //selecting our database table, if you only want to show select data in the grid view
                command.CommandText = query;                        // change your SQL qury to filter the information you want
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command); //'dataAdapter != keyword, self decalred vairbable
                DataTable dataTable = new DataTable();  //'dataTable != keyword
                dataAdapter.Fill(dataTable);    //using the data adapter to fill in the data table. '.Fill' = keyword
                dataGrid_true.DataSource = dataTable;  // making the gird view = the data table by usinsg keyword '.DataSource'
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_true_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Ticket_Table WHERE (((Ticket_Table.Status)=Yes))";   //selecting our database table, if you only want to show select data in the grid view
                command.CommandText = query;                        // change your SQL qury to filter the information you want
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command); //'dataAdapter != keyword, self decalred vairbable
                DataTable dataTable = new DataTable();  //'dataTable != keyword
                dataAdapter.Fill(dataTable);    //using the data adapter to fill in the data table. '.Fill' = keyword
                dataGrid_true.DataSource = dataTable;  // making the gird view = the data table by usinsg keyword '.DataSource'
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
