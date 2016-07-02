using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLE
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void btn_stuAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAcc ST = new AdminAcc();
            ST.ShowDialog();
        }

        private void btn_adminAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin AC = new Admin();
            AC.ShowDialog();
        }

        private void btn_stuProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            OverView OV = new OverView();
            OV.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye-Bye");
            Application.Exit();
        }
    }
}
