namespace ScotiaAirline
{
    partial class MainMenu
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
            this.btn_flight = new System.Windows.Forms.Button();
            this.btn_seat = new System.Windows.Forms.Button();
            this.btn_passanger = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main munu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select from an option below";
            // 
            // btn_flight
            // 
            this.btn_flight.Location = new System.Drawing.Point(161, 126);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(96, 36);
            this.btn_flight.TabIndex = 2;
            this.btn_flight.Text = "Flight";
            this.btn_flight.UseVisualStyleBackColor = true;
            this.btn_flight.Click += new System.EventHandler(this.btn_flight_Click);
            // 
            // btn_seat
            // 
            this.btn_seat.Location = new System.Drawing.Point(161, 168);
            this.btn_seat.Name = "btn_seat";
            this.btn_seat.Size = new System.Drawing.Size(96, 40);
            this.btn_seat.TabIndex = 3;
            this.btn_seat.Text = "Seats";
            this.btn_seat.UseVisualStyleBackColor = true;
            this.btn_seat.Click += new System.EventHandler(this.btn_seat_Click);
            // 
            // btn_passanger
            // 
            this.btn_passanger.Location = new System.Drawing.Point(161, 214);
            this.btn_passanger.Name = "btn_passanger";
            this.btn_passanger.Size = new System.Drawing.Size(96, 39);
            this.btn_passanger.TabIndex = 4;
            this.btn_passanger.Text = "Passanger";
            this.btn_passanger.UseVisualStyleBackColor = true;
            this.btn_passanger.Click += new System.EventHandler(this.btn_passanger_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(365, 279);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(84, 33);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 324);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_passanger);
            this.Controls.Add(this.btn_seat);
            this.Controls.Add(this.btn_flight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_flight;
        private System.Windows.Forms.Button btn_seat;
        private System.Windows.Forms.Button btn_passanger;
        private System.Windows.Forms.Button btn_logout;
    }
}