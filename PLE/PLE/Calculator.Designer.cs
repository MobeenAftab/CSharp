namespace PLE
{
    partial class Calculator
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
            this.rb_D = new System.Windows.Forms.RadioButton();
            this.rb_T = new System.Windows.Forms.RadioButton();
            this.rb_v = new System.Windows.Forms.RadioButton();
            this.txt_T = new System.Windows.Forms.TextBox();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.btn_cal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ans = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.lb_userN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rb_D
            // 
            this.rb_D.AutoSize = true;
            this.rb_D.Location = new System.Drawing.Point(73, 96);
            this.rb_D.Name = "rb_D";
            this.rb_D.Size = new System.Drawing.Size(65, 21);
            this.rb_D.TabIndex = 0;
            this.rb_D.TabStop = true;
            this.rb_D.Text = "D=VT";
            this.rb_D.UseVisualStyleBackColor = true;
            // 
            // rb_T
            // 
            this.rb_T.AutoSize = true;
            this.rb_T.Location = new System.Drawing.Point(154, 96);
            this.rb_T.Name = "rb_T";
            this.rb_T.Size = new System.Drawing.Size(69, 21);
            this.rb_T.TabIndex = 1;
            this.rb_T.TabStop = true;
            this.rb_T.Text = "T=D/V";
            this.rb_T.UseVisualStyleBackColor = true;
            // 
            // rb_v
            // 
            this.rb_v.AutoSize = true;
            this.rb_v.Location = new System.Drawing.Point(241, 96);
            this.rb_v.Name = "rb_v";
            this.rb_v.Size = new System.Drawing.Size(69, 21);
            this.rb_v.TabIndex = 2;
            this.rb_v.TabStop = true;
            this.rb_v.Text = "V=D/T";
            this.rb_v.UseVisualStyleBackColor = true;
            // 
            // txt_T
            // 
            this.txt_T.Location = new System.Drawing.Point(210, 212);
            this.txt_T.Name = "txt_T";
            this.txt_T.Size = new System.Drawing.Size(100, 22);
            this.txt_T.TabIndex = 3;
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(210, 156);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(100, 22);
            this.txt_D.TabIndex = 4;
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(210, 184);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(100, 22);
            this.txt_v.TabIndex = 5;
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(220, 290);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(90, 36);
            this.btn_cal.TabIndex = 6;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "D=VT Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "T";
            // 
            // lb_ans
            // 
            this.lb_ans.AutoSize = true;
            this.lb_ans.Location = new System.Drawing.Point(73, 255);
            this.lb_ans.Name = "lb_ans";
            this.lb_ans.Size = new System.Drawing.Size(0, 17);
            this.lb_ans.TabIndex = 11;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(13, 320);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(83, 23);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // lb_userN
            // 
            this.lb_userN.AutoSize = true;
            this.lb_userN.Location = new System.Drawing.Point(13, 13);
            this.lb_userN.Name = "lb_userN";
            this.lb_userN.Size = new System.Drawing.Size(0, 17);
            this.lb_userN.TabIndex = 13;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 355);
            this.Controls.Add(this.lb_userN);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lb_ans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_v);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.txt_T);
            this.Controls.Add(this.rb_v);
            this.Controls.Add(this.rb_T);
            this.Controls.Add(this.rb_D);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_D;
        private System.Windows.Forms.RadioButton rb_T;
        private System.Windows.Forms.RadioButton rb_v;
        private System.Windows.Forms.TextBox txt_T;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.TextBox txt_v;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ans;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lb_userN;

        
    }
}