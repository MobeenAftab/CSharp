namespace ScotiaAirline
{
    partial class Flight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_flight = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.txt_arr = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_conecction = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_closed = new System.Windows.Forms.RadioButton();
            this.rb_booking = new System.Windows.Forms.RadioButton();
            this.rb_boarding = new System.Windows.Forms.RadioButton();
            this.rb_check = new System.Windows.Forms.RadioButton();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Airport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival Airport";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // txt_flight
            // 
            this.txt_flight.Location = new System.Drawing.Point(157, 58);
            this.txt_flight.Name = "txt_flight";
            this.txt_flight.Size = new System.Drawing.Size(100, 22);
            this.txt_flight.TabIndex = 5;
            // 
            // txt_dep
            // 
            this.txt_dep.Location = new System.Drawing.Point(157, 87);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(100, 22);
            this.txt_dep.TabIndex = 6;
            // 
            // txt_arr
            // 
            this.txt_arr.Location = new System.Drawing.Point(157, 115);
            this.txt_arr.Name = "txt_arr";
            this.txt_arr.Size = new System.Drawing.Size(100, 22);
            this.txt_arr.TabIndex = 7;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(157, 143);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(100, 22);
            this.txt_state.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 131);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(447, 51);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(447, 166);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(447, 80);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(447, 109);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_conecction
            // 
            this.lb_conecction.AutoSize = true;
            this.lb_conecction.Location = new System.Drawing.Point(444, 21);
            this.lb_conecction.Name = "lb_conecction";
            this.lb_conecction.Size = new System.Drawing.Size(0, 17);
            this.lb_conecction.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_closed);
            this.groupBox1.Controls.Add(this.rb_booking);
            this.groupBox1.Controls.Add(this.rb_boarding);
            this.groupBox1.Controls.Add(this.rb_check);
            this.groupBox1.Location = new System.Drawing.Point(263, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // rb_closed
            // 
            this.rb_closed.AutoSize = true;
            this.rb_closed.Location = new System.Drawing.Point(30, 108);
            this.rb_closed.Name = "rb_closed";
            this.rb_closed.Size = new System.Drawing.Size(72, 21);
            this.rb_closed.TabIndex = 5;
            this.rb_closed.TabStop = true;
            this.rb_closed.Text = "Closed";
            this.rb_closed.UseVisualStyleBackColor = true;
            this.rb_closed.CheckedChanged += new System.EventHandler(this.rb_closed_CheckedChanged);
            // 
            // rb_booking
            // 
            this.rb_booking.AutoSize = true;
            this.rb_booking.Location = new System.Drawing.Point(30, 27);
            this.rb_booking.Name = "rb_booking";
            this.rb_booking.Size = new System.Drawing.Size(80, 21);
            this.rb_booking.TabIndex = 2;
            this.rb_booking.TabStop = true;
            this.rb_booking.Text = "Booking";
            this.rb_booking.UseVisualStyleBackColor = true;
            this.rb_booking.CheckedChanged += new System.EventHandler(this.rb_booking_CheckedChanged);
            // 
            // rb_boarding
            // 
            this.rb_boarding.AutoSize = true;
            this.rb_boarding.Location = new System.Drawing.Point(30, 81);
            this.rb_boarding.Name = "rb_boarding";
            this.rb_boarding.Size = new System.Drawing.Size(86, 21);
            this.rb_boarding.TabIndex = 4;
            this.rb_boarding.TabStop = true;
            this.rb_boarding.Text = "Boarding";
            this.rb_boarding.UseVisualStyleBackColor = true;
            this.rb_boarding.CheckedChanged += new System.EventHandler(this.rb_boarding_CheckedChanged);
            // 
            // rb_check
            // 
            this.rb_check.AutoSize = true;
            this.rb_check.Location = new System.Drawing.Point(30, 54);
            this.rb_check.Name = "rb_check";
            this.rb_check.Size = new System.Drawing.Size(83, 21);
            this.rb_check.TabIndex = 3;
            this.rb_check.TabStop = true;
            this.rb_check.Text = "Check In";
            this.rb_check.UseVisualStyleBackColor = true;
            this.rb_check.CheckedChanged += new System.EventHandler(this.rb_check_CheckedChanged);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(450, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 16;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 338);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_conecction);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_arr);
            this.Controls.Add(this.txt_dep);
            this.Controls.Add(this.txt_flight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Flight";
            this.Text = "Flight";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_flight;
        private System.Windows.Forms.TextBox txt_dep;
        private System.Windows.Forms.TextBox txt_arr;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_conecction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_closed;
        private System.Windows.Forms.RadioButton rb_booking;
        private System.Windows.Forms.RadioButton rb_boarding;
        private System.Windows.Forms.RadioButton rb_check;
        private System.Windows.Forms.Button btn_home;
    }
}