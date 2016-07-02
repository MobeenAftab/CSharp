namespace PLE
{
    partial class StudentOverview
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
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_userN = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student overview";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(12, 108);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(89, 36);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_quiz
            // 
            this.btn_quiz.Location = new System.Drawing.Point(12, 174);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(89, 33);
            this.btn_quiz.TabIndex = 2;
            this.btn_quiz.Text = "quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_userN
            // 
            this.lb_userN.AutoSize = true;
            this.lb_userN.Location = new System.Drawing.Point(111, 74);
            this.lb_userN.Name = "lb_userN";
            this.lb_userN.Size = new System.Drawing.Size(0, 17);
            this.lb_userN.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(587, 7);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // StudentOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 256);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lb_userN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_quiz);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.label1);
            this.Name = "StudentOverview";
            this.Text = "StudentOverview";
            this.Load += new System.EventHandler(this.StudentOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_userN;
        private System.Windows.Forms.Button btn_home;
    }
}