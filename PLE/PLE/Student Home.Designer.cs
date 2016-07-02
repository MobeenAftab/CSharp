namespace PLE
{
    partial class Student_Home
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.lb_userN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "student home";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(52, 73);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(268, 40);
            this.btn_calc.TabIndex = 1;
            this.btn_calc.Text = "Physics Calculator";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_quiz
            // 
            this.btn_quiz.Location = new System.Drawing.Point(52, 133);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(268, 40);
            this.btn_quiz.TabIndex = 2;
            this.btn_quiz.Text = "Physics Quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(52, 198);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(268, 40);
            this.btn_test.TabIndex = 3;
            this.btn_test.Text = "Physics Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.Location = new System.Drawing.Point(52, 262);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(268, 40);
            this.btn_overview.TabIndex = 4;
            this.btn_overview.Text = "User Profile";
            this.btn_overview.UseVisualStyleBackColor = true;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // lb_userN
            // 
            this.lb_userN.AutoSize = true;
            this.lb_userN.Location = new System.Drawing.Point(13, 13);
            this.lb_userN.Name = "lb_userN";
            this.lb_userN.Size = new System.Drawing.Size(0, 17);
            this.lb_userN.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_userN);
            this.Controls.Add(this.btn_overview);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_quiz);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label1);
            this.Name = "Student_Home";
            this.Text = "Student_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.Label lb_userN;
        private System.Windows.Forms.Button button1;
    }
}