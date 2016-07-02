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
    public partial class Passanger : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Passanger()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Projects\Software Development\C#\ScotiaAirline\Airline.accdb;
                                            Persist Security Info=False;"; 
        }

        private void Passanger_Load(object sender, EventArgs e)
        {
            txt_company.Visible = false;
            txt_islander.Visible = false;
            lb_company.Visible = false;
            lb_islander.Visible = false;
        }

        private void rb_island_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_island.Checked)
            {
                txt_islander.Visible = true;
                lb_islander.Visible = true;
                lb_price.Text = "10% Disscount";
                txt_type.Text = "islander";
                txt_price.Text = "90";
            }
            else 
            {
                txt_islander.Visible = false;
                lb_islander.Visible = false;
                lb_price.Text = "";
                txt_type.Text = "";
                txt_price.Text = "";
            }
        }

        private void tb_business_CheckedChanged(object sender, EventArgs e)
        {
            if(tb_business.Checked)
            {
                txt_company.Visible = true;
                lb_company.Visible = true;
                lb_price.Text = "25% Disscount";
                txt_type.Text = "business";
                txt_price.Text = "75";
            }
            else
            {
                txt_company.Visible = false;
                lb_company.Visible = false;
                lb_price.Text = "";
                txt_type.Text = "";
                txt_price.Text = "";
            }
        }

        private void rb_dis_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dis.Checked) 
            { 
                lb_price.Text = "5% Disscount";
                txt_type.Text = "disscount";
                txt_price.Text = "95";
            }
            else 
            { 
                lb_price.Text = "";
                txt_type.Text = "";
                txt_price.Text = "";
            }
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_normal.Checked)
            {
                lb_price.Text = "No Disscount";
                txt_type.Text = "normal";
                txt_price.Text = "100";
            }
            else
            {
                lb_price.Text = "";
                txt_type.Text = "";
                txt_price.Text = "";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if((txt_status.Text == "checkin") || (txt_status.Text ==  "booking"))
                    {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        string query = "INSERT INTO Passanger (Passanger_ID, Type, Price, CompanyName, IslanderAddress, PassangerName, Flight_ID)" +
                             "values ('" + txt_passanger.Text + "', '" + txt_type.Text + "', '" + txt_price.Text + "','" + txt_company.Text + "', '" + txt_islander.Text + "','" + txt_Pname.Text + "','" + txt_flightID.Text + "')";
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                        connection.Close();
                        lb_conecction.Text = "Passanger Saved";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connection.Close();
                    }
                }
            else if ((txt_status.Text == "boarding") || (txt_status.Text == "closed"))
            {
                MessageBox.Show("the flight is no longer avalible for booking or reservation");
            }
            else { MessageBox.Show("please select a valid flight number"); }
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

                txt_passanger.Text = row.Cells[0].Value.ToString();
                txt_type.Text = row.Cells[1].Value.ToString();
                txt_price.Text = row.Cells[2].Value.ToString();
                txt_company.Text = row.Cells[3].Value.ToString();
                txt_islander.Text = row.Cells[4].Value.ToString();
                txt_Pname.Text = row.Cells[5].Value.ToString();
                txt_flightID.Text = row.Cells[8].Value.ToString();
                txt_status.Text = row.Cells[9].Value.ToString();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Visible = true;
                //dataGridView2.Visible = false;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT Passanger.Passanger_ID, Passanger.Type, Passanger.Price, Passanger.CompanyName, Passanger.IslanderAddress, Passanger.PassangerName, Seat.Seat_ID, Seat.Seatplan AS Seat_Seatplan, Flight.Flight_ID, Flight.State " +
                                "FROM (Flight INNER JOIN Passanger ON Flight.[Flight_ID] = Passanger.[Flight_ID]) INNER JOIN Seat ON Passanger.[Passanger_ID] = Seat.[Seat_ID]";

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               //dataGridView1.Visible = false;
                //dataGridView2.Visible = true;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                string querry = "SELECT * FROM Flight";
                command.CommandText = querry;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;

            foreach (DataGridViewCell selectedCell in dataGridView2.SelectedCells)
            {
                cell = selectedCell;
                break;
            }

            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                txt_flightID.Text = row.Cells[0].Value.ToString();
                txt_status.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ((txt_status.Text == "checkin") || (txt_status.Text == "booking"))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "UPDATE Passanger SET Type= '" + txt_type.Text + "', Price='" + txt_price.Text + "',  CompanyName='" + txt_company.Text + "', " + 
                         "IslanderAddress='" + txt_islander.Text + "', PassangerName= '"+txt_Pname.Text+"', Flight_ID='" + txt_flightID.Text + "' " +
                         "WHERE Passanger_ID= '" + txt_passanger.Text + "'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    connection.Close();
                    lb_conecction.Text = "Edit Successful";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();
                }
            }
            else if ((txt_status.Text == "boarding") || (txt_status.Text == "closed"))
            {
                MessageBox.Show("the flight is no longer avalible for booking or reservation");
            }
            else { MessageBox.Show("please select a valid flight number"); }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "DELETE FROM Passanger WHERE Passanger_ID= '" + txt_passanger.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                lb_conecction.Text = "Delete Successful";
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
