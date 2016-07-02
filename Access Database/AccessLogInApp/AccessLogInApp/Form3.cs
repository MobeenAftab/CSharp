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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\Access Database\EmployeeInfo.accdb;
                                            Persist Security Info=False;"; 
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_true_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table WHERE (((EmployeeData_Table.IsClient)=Yes))";   //selecting our database table, if you only want to show select data in the grid view
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

        private void btn_false_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from EmployeeData_Table WHERE (((EmployeeData_Table.IsClient)=no))";   //selecting our database table, if you only want to show select data in the grid view
                command.CommandText = query;                        // change your SQL qury to filter the information you want
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command); //'dataAdapter != keyword, self decalred vairbable
                DataTable dataTable = new DataTable();  //'dataTable != keyword
                dataAdapter.Fill(dataTable);    //using the data adapter to fill in the data table. '.Fill' = keyword
                dataGrid_false.DataSource = dataTable;  // making the gird view = the data table by usinsg keyword '.DataSource'
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
