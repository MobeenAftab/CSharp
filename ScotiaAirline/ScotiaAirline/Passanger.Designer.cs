namespace ScotiaAirline
{
    partial class Passanger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_dis = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.tb_business = new System.Windows.Forms.RadioButton();
            this.rb_island = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_islander = new System.Windows.Forms.Label();
            this.lb_company = new System.Windows.Forms.Label();
            this.txt_passanger = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_islander = new System.Windows.Forms.TextBox();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.lb_Type = new System.Windows.Forms.Label();
            this.txt_flightID = new System.Windows.Forms.TextBox();
            this.txt_Pname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_conecction = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passanger Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_dis);
            this.groupBox1.Controls.Add(this.rb_normal);
            this.groupBox1.Controls.Add(this.tb_business);
            this.groupBox1.Controls.Add(this.rb_island);
            this.groupBox1.Location = new System.Drawing.Point(135, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rb_dis
            // 
            this.rb_dis.AutoSize = true;
            this.rb_dis.Location = new System.Drawing.Point(30, 108);
            this.rb_dis.Name = "rb_dis";
            this.rb_dis.Size = new System.Drawing.Size(91, 21);
            this.rb_dis.TabIndex = 5;
            this.rb_dis.TabStop = true;
            this.rb_dis.Text = "Disscount";
            this.rb_dis.UseVisualStyleBackColor = true;
            this.rb_dis.CheckedChanged += new System.EventHandler(this.rb_dis_CheckedChanged);
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Location = new System.Drawing.Point(30, 27);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(74, 21);
            this.rb_normal.TabIndex = 2;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Normal";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // tb_business
            // 
            this.tb_business.AutoSize = true;
            this.tb_business.Location = new System.Drawing.Point(30, 81);
            this.tb_business.Name = "tb_business";
            this.tb_business.Size = new System.Drawing.Size(86, 21);
            this.tb_business.TabIndex = 4;
            this.tb_business.TabStop = true;
            this.tb_business.Text = "Business";
            this.tb_business.UseVisualStyleBackColor = true;
            this.tb_business.CheckedChanged += new System.EventHandler(this.tb_business_CheckedChanged);
            // 
            // rb_island
            // 
            this.rb_island.AutoSize = true;
            this.rb_island.Location = new System.Drawing.Point(30, 54);
            this.rb_island.Name = "rb_island";
            this.rb_island.Size = new System.Drawing.Size(87, 21);
            this.rb_island.TabIndex = 3;
            this.rb_island.TabStop = true;
            this.rb_island.Text = "Islannder";
            this.rb_island.UseVisualStyleBackColor = true;
            this.rb_island.CheckedChanged += new System.EventHandler(this.rb_island_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passanger ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // lb_islander
            // 
            this.lb_islander.AutoSize = true;
            this.lb_islander.Location = new System.Drawing.Point(15, 274);
            this.lb_islander.Name = "lb_islander";
            this.lb_islander.Size = new System.Drawing.Size(114, 17);
            this.lb_islander.TabIndex = 5;
            this.lb_islander.Text = "Islander Address";
            // 
            // lb_company
            // 
            this.lb_company.AutoSize = true;
            this.lb_company.Location = new System.Drawing.Point(15, 355);
            this.lb_company.Name = "lb_company";
            this.lb_company.Size = new System.Drawing.Size(108, 17);
            this.lb_company.TabIndex = 6;
            this.lb_company.Text = "Company Name";
            // 
            // txt_passanger
            // 
            this.txt_passanger.Location = new System.Drawing.Point(130, 51);
            this.txt_passanger.Name = "txt_passanger";
            this.txt_passanger.Size = new System.Drawing.Size(100, 22);
            this.txt_passanger.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(130, 107);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 9;
            // 
            // txt_islander
            // 
            this.txt_islander.Location = new System.Drawing.Point(15, 301);
            this.txt_islander.Name = "txt_islander";
            this.txt_islander.Size = new System.Drawing.Size(100, 22);
            this.txt_islander.TabIndex = 10;
            // 
            // txt_company
            // 
            this.txt_company.Location = new System.Drawing.Point(18, 381);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(100, 22);
            this.txt_company.TabIndex = 11;
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(15, 330);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(0, 17);
            this.lb_price.TabIndex = 12;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(130, 79);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 22);
            this.txt_type.TabIndex = 14;
            // 
            // lb_Type
            // 
            this.lb_Type.AutoSize = true;
            this.lb_Type.Location = new System.Drawing.Point(15, 78);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(40, 17);
            this.lb_Type.TabIndex = 13;
            this.lb_Type.Text = "Type";
            // 
            // txt_flightID
            // 
            this.txt_flightID.Location = new System.Drawing.Point(130, 163);
            this.txt_flightID.Name = "txt_flightID";
            this.txt_flightID.Size = new System.Drawing.Size(100, 22);
            this.txt_flightID.TabIndex = 18;
            // 
            // txt_Pname
            // 
            this.txt_Pname.Location = new System.Drawing.Point(130, 135);
            this.txt_Pname.Name = "txt_Pname";
            this.txt_Pname.Size = new System.Drawing.Size(100, 22);
            this.txt_Pname.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Flight ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Passanger Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 167);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(262, 16);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(127, 29);
            this.btn_load.TabIndex = 20;
            this.btn_load.Text = "Load Passangers";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(525, 224);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 38);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(631, 224);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 38);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(737, 224);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 38);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_conecction
            // 
            this.lb_conecction.AutoSize = true;
            this.lb_conecction.Location = new System.Drawing.Point(259, 224);
            this.lb_conecction.Name = "lb_conecction";
            this.lb_conecction.Size = new System.Drawing.Size(0, 17);
            this.lb_conecction.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Load Flights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(314, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(523, 110);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(130, 191);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 22);
            this.txt_status.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Flight Status";
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(710, 388);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(127, 29);
            this.btn_home.TabIndex = 29;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Passanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 429);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_conecction);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_flightID);
            this.Controls.Add(this.txt_Pname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.txt_islander);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_passanger);
            this.Controls.Add(this.lb_company);
            this.Controls.Add(this.lb_islander);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Passanger";
            this.Text = "Passanger";
            this.Load += new System.EventHandler(this.Passanger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_dis;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.RadioButton tb_business;
        private System.Windows.Forms.RadioButton rb_island;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_islander;
        private System.Windows.Forms.Label lb_company;
        private System.Windows.Forms.TextBox txt_passanger;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_islander;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.TextBox txt_flightID;
        private System.Windows.Forms.TextBox txt_Pname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_conecction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_home;
    }
}