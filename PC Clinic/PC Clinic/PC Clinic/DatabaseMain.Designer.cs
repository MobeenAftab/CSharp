namespace PC_Clinic
{
    partial class DatabaseMain
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
            this.lb__userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loadStatus = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_action = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_techName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_techID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ClientSave = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_studentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_true = new System.Windows.Forms.Button();
            this.btn_false = new System.Windows.Forms.Button();
            this.dataGrid_true = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_true)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lb__userName
            // 
            this.lb__userName.AutoSize = true;
            this.lb__userName.Location = new System.Drawing.Point(17, 19);
            this.lb__userName.Name = "lb__userName";
            this.lb__userName.Size = new System.Drawing.Size(0, 17);
            this.lb__userName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PC Clinic";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 151);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_loadStatus
            // 
            this.btn_loadStatus.Location = new System.Drawing.Point(124, 217);
            this.btn_loadStatus.Name = "btn_loadStatus";
            this.btn_loadStatus.Size = new System.Drawing.Size(432, 26);
            this.btn_loadStatus.TabIndex = 3;
            this.btn_loadStatus.Text = "Load Open Projects";
            this.btn_loadStatus.UseVisualStyleBackColor = true;
            this.btn_loadStatus.Click += new System.EventHandler(this.btn_loadStatus_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 435);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_loadStatus);
            this.tabPage1.Controls.Add(this.lb__userName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PC clininc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_edit);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.lb_action);
            this.tabPage2.Controls.Add(this.btn_save);
            this.tabPage2.Controls.Add(this.txt_techName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_techID);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Technician";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(283, 202);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 202);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(391, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 132);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_action
            // 
            this.lb_action.AutoSize = true;
            this.lb_action.Location = new System.Drawing.Point(223, 28);
            this.lb_action.Name = "lb_action";
            this.lb_action.Size = new System.Drawing.Size(135, 17);
            this.lb_action.TabIndex = 7;
            this.lb_action.Text = "Command validation";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(63, 202);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_techName
            // 
            this.txt_techName.Location = new System.Drawing.Point(185, 116);
            this.txt_techName.Name = "txt_techName";
            this.txt_techName.Size = new System.Drawing.Size(100, 22);
            this.txt_techName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_techID
            // 
            this.txt_techID.Location = new System.Drawing.Point(185, 71);
            this.txt_techID.Name = "txt_techID";
            this.txt_techID.Size = new System.Drawing.Size(100, 22);
            this.txt_techID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Technician ID ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btn_ClientSave);
            this.tabPage3.Controls.Add(this.txt_phone);
            this.tabPage3.Controls.Add(this.txt_email);
            this.tabPage3.Controls.Add(this.txt_sname);
            this.tabPage3.Controls.Add(this.txt_studentID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(711, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clients";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Command validation";
            // 
            // btn_ClientSave
            // 
            this.btn_ClientSave.Location = new System.Drawing.Point(369, 54);
            this.btn_ClientSave.Name = "btn_ClientSave";
            this.btn_ClientSave.Size = new System.Drawing.Size(108, 38);
            this.btn_ClientSave.TabIndex = 8;
            this.btn_ClientSave.Text = "Add Client";
            this.btn_ClientSave.UseVisualStyleBackColor = true;
            this.btn_ClientSave.Click += new System.EventHandler(this.btn_ClientSave_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(191, 180);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(191, 142);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 6;
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(191, 106);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(100, 22);
            this.txt_sname.TabIndex = 5;
            // 
            // txt_studentID
            // 
            this.txt_studentID.Location = new System.Drawing.Point(191, 65);
            this.txt_studentID.Name = "txt_studentID";
            this.txt_studentID.Size = new System.Drawing.Size(100, 22);
            this.txt_studentID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student ID";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.dataGrid_true);
            this.tabPage4.Controls.Add(this.btn_false);
            this.tabPage4.Controls.Add(this.btn_true);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(711, 406);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tickets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_true
            // 
            this.btn_true.Location = new System.Drawing.Point(17, 290);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(118, 52);
            this.btn_true.TabIndex = 0;
            this.btn_true.Text = "Finished";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click);
            // 
            // btn_false
            // 
            this.btn_false.Location = new System.Drawing.Point(17, 73);
            this.btn_false.Name = "btn_false";
            this.btn_false.Size = new System.Drawing.Size(118, 52);
            this.btn_false.TabIndex = 1;
            this.btn_false.Text = "On going";
            this.btn_false.UseVisualStyleBackColor = true;
            this.btn_false.Click += new System.EventHandler(this.btn_false_Click);
            // 
            // dataGrid_true
            // 
            this.dataGrid_true.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_true.Location = new System.Drawing.Point(162, 20);
            this.dataGrid_true.Name = "dataGrid_true";
            this.dataGrid_true.RowTemplate.Height = 24;
            this.dataGrid_true.Size = new System.Drawing.Size(533, 173);
            this.dataGrid_true.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(162, 231);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(533, 161);
            this.dataGridView3.TabIndex = 3;
            // 
            // DatabaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "DatabaseMain";
            this.Text = "DatabaseMain";
            this.Load += new System.EventHandler(this.DatabaseMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_true)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb__userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_loadStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_techName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_techID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_action;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ClientSave;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_studentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGrid_true;
        private System.Windows.Forms.Button btn_false;
        private System.Windows.Forms.Button btn_true;
    }
}