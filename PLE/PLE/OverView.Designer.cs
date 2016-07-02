namespace PLE
{
    partial class OverView
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
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_quiz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_test = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(16, 69);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(92, 31);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_quiz
            // 
            this.btn_quiz.Location = new System.Drawing.Point(16, 134);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(92, 31);
            this.btn_quiz.TabIndex = 1;
            this.btn_quiz.Text = "Quiz";
            this.btn_quiz.UseVisualStyleBackColor = true;
            this.btn_quiz.Click += new System.EventHandler(this.btn_quiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Profile overview";
            // 
            // dataGridView_test
            // 
            this.dataGridView_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_test.Location = new System.Drawing.Point(114, 51);
            this.dataGridView_test.Name = "dataGridView_test";
            this.dataGridView_test.RowTemplate.Height = 24;
            this.dataGridView_test.Size = new System.Drawing.Size(677, 337);
            this.dataGridView_test.TabIndex = 3;
            this.dataGridView_test.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_test_CellContentClick);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(643, 13);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(147, 23);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Admin Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // OverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 400);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.dataGridView_test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quiz);
            this.Controls.Add(this.btn_test);
            this.Name = "OverView";
            this.Text = "OverView";
            this.Load += new System.EventHandler(this.OverView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_quiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_test;
        private System.Windows.Forms.Button btn_home;

        public System.Windows.Forms.DataGridViewCellEventHandler dataGridView_test_CellContentClick { get; set; }
    }
}