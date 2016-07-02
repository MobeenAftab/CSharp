namespace PLE
{
    partial class QuizHome
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
            this.btn_quiz1 = new System.Windows.Forms.Button();
            this.lb_userN = new System.Windows.Forms.Label();
            this.btn_quiz2 = new System.Windows.Forms.Button();
            this.btn_quiz3 = new System.Windows.Forms.Button();
            this.btn_quiz4 = new System.Windows.Forms.Button();
            this.btn_quiz5 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz selection";
            // 
            // btn_quiz1
            // 
            this.btn_quiz1.Location = new System.Drawing.Point(48, 77);
            this.btn_quiz1.Name = "btn_quiz1";
            this.btn_quiz1.Size = new System.Drawing.Size(263, 39);
            this.btn_quiz1.TabIndex = 1;
            this.btn_quiz1.Text = "Quiz 1: kinematics and statics";
            this.btn_quiz1.UseVisualStyleBackColor = true;
            this.btn_quiz1.Click += new System.EventHandler(this.btn_quiz1_Click);
            // 
            // lb_userN
            // 
            this.lb_userN.AutoSize = true;
            this.lb_userN.Location = new System.Drawing.Point(13, 13);
            this.lb_userN.Name = "lb_userN";
            this.lb_userN.Size = new System.Drawing.Size(0, 17);
            this.lb_userN.TabIndex = 2;
            // 
            // btn_quiz2
            // 
            this.btn_quiz2.Location = new System.Drawing.Point(48, 137);
            this.btn_quiz2.Name = "btn_quiz2";
            this.btn_quiz2.Size = new System.Drawing.Size(263, 39);
            this.btn_quiz2.TabIndex = 3;
            this.btn_quiz2.Text = "Quiz 2: dynamics and momentum";
            this.btn_quiz2.UseVisualStyleBackColor = true;
            this.btn_quiz2.Click += new System.EventHandler(this.btn_quiz2_Click);
            // 
            // btn_quiz3
            // 
            this.btn_quiz3.Location = new System.Drawing.Point(48, 201);
            this.btn_quiz3.Name = "btn_quiz3";
            this.btn_quiz3.Size = new System.Drawing.Size(263, 39);
            this.btn_quiz3.TabIndex = 4;
            this.btn_quiz3.Text = "Quiz 3: Power and energy";
            this.btn_quiz3.UseVisualStyleBackColor = true;
            this.btn_quiz3.Click += new System.EventHandler(this.btn_quiz3_Click);
            // 
            // btn_quiz4
            // 
            this.btn_quiz4.Location = new System.Drawing.Point(48, 266);
            this.btn_quiz4.Name = "btn_quiz4";
            this.btn_quiz4.Size = new System.Drawing.Size(263, 48);
            this.btn_quiz4.TabIndex = 5;
            this.btn_quiz4.Text = "Quiz 4 : Static electricity and electric current";
            this.btn_quiz4.UseVisualStyleBackColor = true;
            this.btn_quiz4.Click += new System.EventHandler(this.btn_quiz4_Click);
            // 
            // btn_quiz5
            // 
            this.btn_quiz5.Location = new System.Drawing.Point(48, 330);
            this.btn_quiz5.Name = "btn_quiz5";
            this.btn_quiz5.Size = new System.Drawing.Size(263, 48);
            this.btn_quiz5.TabIndex = 6;
            this.btn_quiz5.Text = "Quiz 5: Mixed Selection";
            this.btn_quiz5.UseVisualStyleBackColor = true;
            this.btn_quiz5.Click += new System.EventHandler(this.btn_quiz5_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(13, 386);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // QuizHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 421);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_quiz5);
            this.Controls.Add(this.btn_quiz4);
            this.Controls.Add(this.btn_quiz3);
            this.Controls.Add(this.btn_quiz2);
            this.Controls.Add(this.lb_userN);
            this.Controls.Add(this.btn_quiz1);
            this.Controls.Add(this.label1);
            this.Name = "QuizHome";
            this.Text = "QuizHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quiz1;
        private System.Windows.Forms.Label lb_userN;
        private System.Windows.Forms.Button btn_quiz2;
        private System.Windows.Forms.Button btn_quiz3;
        private System.Windows.Forms.Button btn_quiz4;
        private System.Windows.Forms.Button btn_quiz5;
        private System.Windows.Forms.Button btn_home;
    }
}