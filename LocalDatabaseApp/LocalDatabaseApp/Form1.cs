using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//this program will help you learn how to use a local 
//data base in c'# unlike before when ising access as 

namespace LocalDatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet1.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.employeesDataSet1.EmployeeInfo);
            //adding timer to program to load data from table
            timer1.Start();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //keyword here to add new items to database, ony the start
            //changes - the table name
            this.employeeInfoBindingSource.AddNew();
            //use this to add a new entry to a local database
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeesDataSet1);
            //use this to validate an edit to database
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            this.employeeInfoBindingSource.RemoveCurrent();
            //use this to remove item from database
        }

        //global variable for timer
        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter = employeeInfoBindingSource.Count;
            lb_status.Text = "there are " + counter.ToString()
                + " rows in your database";

            //removes the next and previous buttons if the database
            //has less than two rows
            if (counter < 2)
            {
                btn_next.Visible = false;
                btn_previous.Visible = false;
            }
                //shows the next and previous buttons if the database
                //has nore that two rows
              else
                    {
                        btn_next.Visible = true;
                        btn_previous.Visible = true;
                    }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //adding a button to move to next data base row

            employeeInfoBindingSource.MoveNext();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            //moving one row back in data base
            employeeInfoBindingSource.MovePrevious();
        }



        }
    }


