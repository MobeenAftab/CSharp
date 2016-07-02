namespace ScotiaAirline
{
    partial class Seats
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_seat = new System.Windows.Forms.TextBox();
            this.txt_plan = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_free = new System.Windows.Forms.RadioButton();
            this.tb_booked = new System.Windows.Forms.RadioButton();
            this.rb_reserved = new System.Windows.Forms.RadioButton();
            this.lb_conecction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_frees = new System.Windows.Forms.Button();
            this.btn_reserved = new System.Windows.Forms.Button();
            this.brn_booked = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seating Plan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(15, 194);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(117, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load All";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(309, 194);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 3;
            this.btn_total.Text = "total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(455, 65);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(455, 94);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(456, 123);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_seat
            // 
            this.txt_seat.Location = new System.Drawing.Point(285, 65);
            this.txt_seat.Name = "txt_seat";
            this.txt_seat.Size = new System.Drawing.Size(100, 22);
            this.txt_seat.TabIndex = 7;
            // 
            // txt_plan
            // 
            this.txt_plan.Location = new System.Drawing.Point(285, 93);
            this.txt_plan.Name = "txt_plan";
            this.txt_plan.Size = new System.Drawing.Size(100, 22);
            this.txt_plan.TabIndex = 8;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(285, 121);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 22);
            this.txt_status.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seat ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seat Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_free);
            this.groupBox1.Controls.Add(this.tb_booked);
            this.groupBox1.Controls.Add(this.rb_reserved);
            this.groupBox1.Location = new System.Drawing.Point(15, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rb_free
            // 
            this.rb_free.AutoSize = true;
            this.rb_free.Location = new System.Drawing.Point(30, 27);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(58, 21);
            this.rb_free.TabIndex = 2;
            this.rb_free.TabStop = true;
            this.rb_free.Text = "Free";
            this.rb_free.UseVisualStyleBackColor = true;
            this.rb_free.CheckedChanged += new System.EventHandler(this.rb_free_CheckedChanged);
            // 
            // tb_booked
            // 
            this.tb_booked.AutoSize = true;
            this.tb_booked.Location = new System.Drawing.Point(30, 81);
            this.tb_booked.Name = "tb_booked";
            this.tb_booked.Size = new System.Drawing.Size(77, 21);
            this.tb_booked.TabIndex = 4;
            this.tb_booked.TabStop = true;
            this.tb_booked.Text = "Booked";
            this.tb_booked.UseVisualStyleBackColor = true;
            this.tb_booked.CheckedChanged += new System.EventHandler(this.tb_booked_CheckedChanged);
            // 
            // rb_reserved
            // 
            this.rb_reserved.AutoSize = true;
            this.rb_reserved.Location = new System.Drawing.Point(30, 54);
            this.rb_reserved.Name = "rb_reserved";
            this.rb_reserved.Size = new System.Drawing.Size(90, 21);
            this.rb_reserved.TabIndex = 3;
            this.rb_reserved.TabStop = true;
            this.rb_reserved.Text = "Reserved";
            this.rb_reserved.UseVisualStyleBackColor = true;
            this.rb_reserved.CheckedChanged += new System.EventHandler(this.rb_reserved_CheckedChanged);
            // 
            // lb_conecction
            // 
            this.lb_conecction.AutoSize = true;
            this.lb_conecction.Location = new System.Drawing.Point(622, 69);
            this.lb_conecction.Name = "lb_conecction";
            this.lb_conecction.Size = new System.Drawing.Size(0, 17);
            this.lb_conecction.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load Seats only";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(728, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 16;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_frees
            // 
            this.btn_frees.Location = new System.Drawing.Point(693, 54);
            this.btn_frees.Name = "btn_frees";
            this.btn_frees.Size = new System.Drawing.Size(109, 23);
            this.btn_frees.TabIndex = 17;
            this.btn_frees.Text = "free seats";
            this.btn_frees.UseVisualStyleBackColor = true;
            this.btn_frees.Click += new System.EventHandler(this.btn_frees_Click_1);
            // 
            // btn_reserved
            // 
            this.btn_reserved.Location = new System.Drawing.Point(694, 83);
            this.btn_reserved.Name = "btn_reserved";
            this.btn_reserved.Size = new System.Drawing.Size(109, 23);
            this.btn_reserved.TabIndex = 18;
            this.btn_reserved.Text = "reserved";
            this.btn_reserved.UseVisualStyleBackColor = true;
            this.btn_reserved.Click += new System.EventHandler(this.btn_reserved_Click);
            // 
            // brn_booked
            // 
            this.brn_booked.Location = new System.Drawing.Point(694, 112);
            this.brn_booked.Name = "brn_booked";
            this.brn_booked.Size = new System.Drawing.Size(109, 23);
            this.brn_booked.TabIndex = 19;
            this.brn_booked.Text = "booked";
            this.brn_booked.UseVisualStyleBackColor = true;
            this.brn_booked.Click += new System.EventHandler(this.brn_booked_Click);
            // 
            // Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 425);
            this.Controls.Add(this.brn_booked);
            this.Controls.Add(this.btn_reserved);
            this.Controls.Add(this.btn_frees);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_conecction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_plan);
            this.Controls.Add(this.txt_seat);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Seats";
            this.Text = "Seats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_seat;
        private System.Windows.Forms.TextBox txt_plan;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_free;
        private System.Windows.Forms.RadioButton tb_booked;
        private System.Windows.Forms.RadioButton rb_reserved;
        private System.Windows.Forms.Label lb_conecction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_frees;
        private System.Windows.Forms.Button btn_reserved;
        private System.Windows.Forms.Button brn_booked;
    }
}