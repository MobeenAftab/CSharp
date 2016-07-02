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
    public partial class Seats : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Seats()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=M:\Projects\Software Development\C#\ScotiaAirline\Airline.accdb;
                                            Persist Security Info=False";
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

               txt_seat.Text = row.Cells[0].Value.ToString();
               txt_plan.Text = row.Cells[1].Value.ToString();
               txt_status.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT Seat.Seat_ID, Seat.Seatplan, Seat.Status, Passanger.Passanger_ID, Passanger.Type, Passanger.Price, Passanger.Flight_ID " +
                        "FROM Passanger INNER JOIN Seat ON Passanger.[Passanger_ID] = Seat.[Seat_ID] " +
                        "ORDER BY Passanger.Flight_ID";


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

        private void btn_total_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT Flight_ID, SUM(Price) AS 'TOTALPRICE' FROM Passanger " +
                        "GROUP BY Flight_ID";


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

        private void rb_free_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_free.Checked)
            {
                txt_status.Text = "free";

            }
            else
            {
                txt_status.Text = "";
            }
        }

        private void rb_reserved_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_reserved.Checked)
            {
                txt_status.Text = "reserved";

            }
            else
            {
                txt_status.Text = "";
            }
        }

        private void tb_booked_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_booked.Checked)
            {
                txt_status.Text = "booked";

            }
            else
            {
                txt_status.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "INSERT INTO Seat (Seat_ID, Seatplan, Status)" +
                     "values ('" + txt_seat.Text + "', '" + txt_plan.Text + "', '" + txt_status.Text + "')";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "seat Saved";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
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
                string query = "UPDATE Seat SET Seatplan='" + txt_plan.Text + "', Status='" + txt_status.Text + "'" +
                     "WHERE Seat_ID='" + txt_seat.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "seat edited";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "DELETE FROM Seat WHERE Seat_ID='" + txt_seat.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "seat deleted";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT * FROM Seat " +
                        "ORDER BY Seat_ID";


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

        private void btn_home_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            this.Hide();
            MainMenu AH = new MainMenu();
            AH.ShowDialog();
        }

        private void btn_frees_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_frees_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Seat WHERE Status= 'free'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;

                }
                MessageBox.Show("there are " + count.ToString() + " free seats avlible");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btn_reserved_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Seat WHERE Status= 'reserved'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;

                }
                MessageBox.Show("there are " + count.ToString() + " reserved seats ");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void brn_booked_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Seat WHERE Status= 'booked'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;

                }
                MessageBox.Show("there are " + count.ToString() + " booked seats ");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
    }
}
