namespace PLE
{
    partial class TestHome
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
            this.btn_test1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_userN = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_test1
            // 
            this.btn_test1.Location = new System.Drawing.Point(24, 102);
            this.btn_test1.Name = "btn_test1";
            this.btn_test1.Size = new System.Drawing.Size(268, 40);
            this.btn_test1.TabIndex = 2;
            this.btn_test1.Text = "SQA Past paper 2014";
            this.btn_test1.UseVisualStyleBackColor = true;
            this.btn_test1.Click += new System.EventHandler(this.btn_test1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQA past papers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "SQA Past paper 2013";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "SQA Past paper 2012";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_userN
            // 
            this.lb_userN.AutoSize = true;
            this.lb_userN.Location = new System.Drawing.Point(13, 13);
            this.lb_userN.Name = "lb_userN";
            this.lb_userN.Size = new System.Drawing.Size(0, 17);
            this.lb_userN.TabIndex = 6;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(13, 320);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // TestHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 355);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.lb_userN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_test1);
            this.Name = "TestHome";
            this.Text = "TestHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_userN;
        private System.Windows.Forms.Button btn_home;
    }
}