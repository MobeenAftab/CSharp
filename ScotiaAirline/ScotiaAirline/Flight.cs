using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ScotiaAirline
{
    public partial class Flight : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Flight()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\ScotiaAirline\Airline.accdb;
                                            Persist Security Info=False;";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                txt_flight.Text = row.Cells[0].Value.ToString();
                txt_dep.Text = row.Cells[1].Value.ToString();
                txt_arr.Text = row.Cells[2].Value.ToString();
                txt_state.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "select * from Flight";
                command.CommandText = querry;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
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
                string query = "INSERT INTO Flight (Flight_ID, Departure, Arrival, State)" +
                     "values ('"+txt_flight.Text+"', '"+txt_dep.Text+"', '"+txt_arr.Text+"', '"+txt_state.Text+"')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "flight Saved";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void rb_booking_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_booking.Checked)
            {
                txt_state.Text = "booking";
            }
            else
            {
                txt_state.Text = "";
            }
        }

        private void rb_check_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_check.Checked)
            {
                txt_state.Text = "checkin";
            }
            else
            {
                txt_state.Text = "";
            }
        }

        private void rb_boarding_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_boarding.Checked)
            {
                txt_state.Text = "boarding";
            }
            else
            {
                txt_state.Text = "";
            }
        }

        private void rb_closed_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_closed.Checked)
            {
                txt_state.Text = "closed";
            }
            else
            {
                txt_state.Text = "";
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "UPDATE Flight SET Departure='" + txt_dep.Text + "'," +
                     "Arrival='" + txt_arr.Text + "', State='" + txt_state.Text + "' WHERE Flight_ID='" + txt_flight.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "flight updated";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
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
                string query = "DELETE FROM Flight WHERE Flight_ID='" + txt_flight.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "flight deleted";
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
            MainMenu AH = new MainMenu();
            AH.ShowDialog();
        }
    }
}
