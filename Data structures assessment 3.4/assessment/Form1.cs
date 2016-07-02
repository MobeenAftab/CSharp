using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DSA3_4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> extensions;// = new Dictionary<string,string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void FileExtensions_Load(object sender, System.EventArgs e)
        {
            // make data dictonairy
            extensions = new Dictionary<string, string>();
        }

        private void btnAddnewEntry_Click(object sender, EventArgs e)
        {
            //assigning text boxes and variables
            string strExtension = txtnewExt.Text;
            string strProgram = txtNewProgram.Text;

            //checkis if box is blank
            if (strExtension == "" || strProgram == "")
            {
                MessageBox.Show("Input was not valid");
            }
            //existing extentions
            else if (extensions.ContainsKey(strExtension))
            {
                MessageBox.Show("Key is already in use");
            }
            else
            {
                //adds to dictionary
                extensions.Add(strExtension, strProgram);
                txtnewExt.Clear();
                txtNewProgram.Clear(); 
                txtDisplay.Clear();
                //output addition to user
                txtDisplay.Text = ("The value " + strExtension + " has been added to the program " + strProgram);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //takes user input
            string strExt = txtExtension.Text;
            string strProg = txtNewProgram.Text;

            if (strExt == "")
            {
                MessageBox.Show("No Value has been added");
            }
            //remove from dictonary
            else if (extensions.Remove(strExt))
            {
                MessageBox.Show("The Value will now be removed");

            }
            else
            {
                MessageBox.Show("There is no entry with this extension " + strExt);
                txtExtension.Focus();
            }
            //clear user inputs
            txtExtension.Clear();
            txtnewExt.Clear();
            txtNewProgram.Clear();
            txtDisplay.Clear();


        }

        private void btnlistall_Click(object sender, EventArgs e)
        {
            //clears text boxes
            txtDisplay.Clear();
            txtNewProgram.Clear();
            txtnewExt.Clear();
            txtExtension.Clear();
            //store user inputs as variables
            string strExt = txtnewExt.Text;
            string strProg = txtNewProgram.Text;

            //show previous extions
            foreach(KeyValuePair<string, string> exten in extensions)
            {
                txtDisplay.AppendText("File Extension: " + exten.Key + " " + " Opens with program: " + exten.Value + "\n" );
            }
           
        }

        private void btnFindProgram_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            string key = "";
            string value = "";

            if (txtExtension.Text == "")
            {
                MessageBox.Show("TextBox is blank please enter a value");
            }
            else
            {
                //stored value as key
                key = txtExtension.Text;
            }
            //find stored value key
            if(extensions.TryGetValue(key, out value))
            {
                //display output to listbox
                txtDisplay.AppendText("File Extension: " + key + " Opens with: " + value);
            }
            else
            {
                MessageBox.Show("Program for the extension does not exist");

            }



        }
        //deletes values
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //delete message box
            if (MessageBox.Show("Are you sure you want to continue?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //empty the dictionary
                extensions.Clear();
                MessageBox.Show("The Dictionary has been cleared");
            }
            txtDisplay.Clear();
            txtExtension.Clear();
            txtnewExt.Clear();
            txtNewProgram.Clear();
 
        }

        public void readData()
        {
            var serializer = new BinaryFormatter();

            //read data from file
            using( var stream = File.OpenRead("datafile.txt"))
            {
                extensions = (Dictionary<string,string>)serializer.Deserialize(stream);
            }

        }
    }
}
