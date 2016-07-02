using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buisiness_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void table_ContactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDatabaseDataSet.Table_Contacts' table. You can move, or remove it, as needed.
            this.table_ContactsTableAdapter.Fill(this.contactsDatabaseDataSet.Table_Contacts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.table_ContactsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_ContactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactsDatabaseDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.table_ContactsBindingSource.RemoveCurrent();
        }
    }
}
