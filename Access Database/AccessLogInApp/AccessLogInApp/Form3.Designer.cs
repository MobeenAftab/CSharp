namespace AccessLogInApp
{
    partial class Form3
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
            this.btn_true = new System.Windows.Forms.Button();
            this.btn_false = new System.Windows.Forms.Button();
            this.dataGrid_true = new System.Windows.Forms.DataGridView();
            this.dataGrid_false = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_true)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_false)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_true
            // 
            this.btn_true.Location = new System.Drawing.Point(12, 12);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(136, 47);
            this.btn_true.TabIndex = 0;
            this.btn_true.Text = "client true";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click);
            // 
            // btn_false
            // 
            this.btn_false.Location = new System.Drawing.Point(12, 198);
            this.btn_false.Name = "btn_false";
            this.btn_false.Size = new System.Drawing.Size(136, 47);
            this.btn_false.TabIndex = 1;
            this.btn_false.Text = "client false";
            this.btn_false.UseVisualStyleBackColor = true;
            this.btn_false.Click += new System.EventHandler(this.btn_false_Click);
            // 
            // dataGrid_true
            // 
            this.dataGrid_true.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_true.Location = new System.Drawing.Point(175, 12);
            this.dataGrid_true.Name = "dataGrid_true";
            this.dataGrid_true.RowTemplate.Height = 24;
            this.dataGrid_true.Size = new System.Drawing.Size(462, 180);
            this.dataGrid_true.TabIndex = 2;
            // 
            // dataGrid_false
            // 
            this.dataGrid_false.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_false.Location = new System.Drawing.Point(175, 198);
            this.dataGrid_false.Name = "dataGrid_false";
            this.dataGrid_false.RowTemplate.Height = 24;
            this.dataGrid_false.Size = new System.Drawing.Size(462, 216);
            this.dataGrid_false.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 426);
            this.Controls.Add(this.dataGrid_false);
            this.Controls.Add(this.dataGrid_true);
            this.Controls.Add(this.btn_false);
            this.Controls.Add(this.btn_true);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_true)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_false)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_true;
        private System.Windows.Forms.Button btn_false;
        private System.Windows.Forms.DataGridView dataGrid_true;
        private System.Windows.Forms.DataGridView dataGrid_false;
    }
}