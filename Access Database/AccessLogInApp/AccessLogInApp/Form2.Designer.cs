namespace AccessLogInApp
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lb_EID = new System.Windows.Forms.Label();
            this.txt_EID = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_loadTable = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_loadChart = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.Label();
            this.btn_form3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(189, 63);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(100, 22);
            this.txt_Fname.TabIndex = 3;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Location = new System.Drawing.Point(189, 94);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(100, 22);
            this.txt_Lname.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(32, 146);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(131, 146);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lb_EID
            // 
            this.lb_EID.AutoSize = true;
            this.lb_EID.Location = new System.Drawing.Point(78, 31);
            this.lb_EID.Name = "lb_EID";
            this.lb_EID.Size = new System.Drawing.Size(87, 17);
            this.lb_EID.TabIndex = 8;
            this.lb_EID.Text = "Employee ID";
            // 
            // txt_EID
            // 
            this.txt_EID.Location = new System.Drawing.Point(189, 31);
            this.txt_EID.Name = "txt_EID";
            this.txt_EID.Size = new System.Drawing.Size(100, 22);
            this.txt_EID.TabIndex = 9;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(233, 146);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(356, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 52);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // btn_loadTable
            // 
            this.btn_loadTable.Location = new System.Drawing.Point(172, 175);
            this.btn_loadTable.Name = "btn_loadTable";
            this.btn_loadTable.Size = new System.Drawing.Size(97, 42);
            this.btn_loadTable.TabIndex = 14;
            this.btn_loadTable.Text = "Load table";
            this.btn_loadTable.UseVisualStyleBackColor = true;
            this.btn_loadTable.Click += new System.EventHandler(this.btn_loadTable_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 331);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Country";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(561, 192);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // btn_loadChart
            // 
            this.btn_loadChart.Location = new System.Drawing.Point(12, 289);
            this.btn_loadChart.Name = "btn_loadChart";
            this.btn_loadChart.Size = new System.Drawing.Size(95, 36);
            this.btn_loadChart.TabIndex = 16;
            this.btn_loadChart.Text = "Load Chart";
            this.btn_loadChart.UseVisualStyleBackColor = true;
            this.btn_loadChart.Click += new System.EventHandler(this.btn_loadChart_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.AutoSize = true;
            this.txt_userName.Location = new System.Drawing.Point(13, 13);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(0, 17);
            this.txt_userName.TabIndex = 17;
            // 
            // btn_form3
            // 
            this.btn_form3.Location = new System.Drawing.Point(67, 235);
            this.btn_form3.Name = "btn_form3";
            this.btn_form3.Size = new System.Drawing.Size(75, 23);
            this.btn_form3.TabIndex = 18;
            this.btn_form3.Text = "Form 3";
            this.btn_form3.UseVisualStyleBackColor = true;
            this.btn_form3.Click += new System.EventHandler(this.btn_form3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 542);
            this.Controls.Add(this.btn_form3);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.btn_loadChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_loadTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_EID);
            this.Controls.Add(this.lb_EID);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lb_EID;
        private System.Windows.Forms.TextBox txt_EID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_loadTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_loadChart;
        private System.Windows.Forms.Label txt_userName;
        private System.Windows.Forms.Button btn_form3;
    }
}