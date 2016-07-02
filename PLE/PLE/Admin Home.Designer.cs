namespace PLE
{
    partial class Admin_Home
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
            this.btn_stuAcc = new System.Windows.Forms.Button();
            this.btn_adminAcc = new System.Windows.Forms.Button();
            this.btn_stuProfile = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator home";
            // 
            // btn_stuAcc
            // 
            this.btn_stuAcc.Location = new System.Drawing.Point(30, 75);
            this.btn_stuAcc.Name = "btn_stuAcc";
            this.btn_stuAcc.Size = new System.Drawing.Size(200, 37);
            this.btn_stuAcc.TabIndex = 2;
            this.btn_stuAcc.Text = "Student Accounts";
            this.btn_stuAcc.UseVisualStyleBackColor = true;
            this.btn_stuAcc.Click += new System.EventHandler(this.btn_stuAcc_Click);
            // 
            // btn_adminAcc
            // 
            this.btn_adminAcc.Location = new System.Drawing.Point(30, 126);
            this.btn_adminAcc.Name = "btn_adminAcc";
            this.btn_adminAcc.Size = new System.Drawing.Size(200, 37);
            this.btn_adminAcc.TabIndex = 3;
            this.btn_adminAcc.Text = "Administration Accounts";
            this.btn_adminAcc.UseVisualStyleBackColor = true;
            this.btn_adminAcc.Click += new System.EventHandler(this.btn_adminAcc_Click);
            // 
            // btn_stuProfile
            // 
            this.btn_stuProfile.Location = new System.Drawing.Point(30, 175);
            this.btn_stuProfile.Name = "btn_stuProfile";
            this.btn_stuProfile.Size = new System.Drawing.Size(200, 37);
            this.btn_stuProfile.TabIndex = 4;
            this.btn_stuProfile.Text = "Student Profile Overview";
            this.btn_stuProfile.UseVisualStyleBackColor = true;
            this.btn_stuProfile.Click += new System.EventHandler(this.btn_stuProfile_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(179, 221);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(91, 35);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 268);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_stuProfile);
            this.Controls.Add(this.btn_adminAcc);
            this.Controls.Add(this.btn_stuAcc);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Home";
            this.Text = "Admin_Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stuAcc;
        private System.Windows.Forms.Button btn_adminAcc;
        private System.Windows.Forms.Button btn_stuProfile;
        private System.Windows.Forms.Button btn_logout;
    }
}