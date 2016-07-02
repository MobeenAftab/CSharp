using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScotiaAirline
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_passanger_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Passanger P = new Passanger();
            P.ShowDialog();
             
        }

        private void btn_flight_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flight F = new Flight();
            F.ShowDialog();
        }

        private void btn_seat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seats S = new Seats();
            S.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
