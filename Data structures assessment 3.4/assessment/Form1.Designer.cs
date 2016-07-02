namespace DSA3_4
{
    partial class Form1
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
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindProgram = new System.Windows.Forms.Button();
            this.btnlistall = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtnewExt = new System.Windows.Forms.TextBox();
            this.txtNewProgram = new System.Windows.Forms.TextBox();
            this.btnAddnewEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(460, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Extention";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(92, 126);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(128, 22);
            this.txtExtension.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter file extension";
            // 
            // btnFindProgram
            // 
            this.btnFindProgram.Location = new System.Drawing.Point(69, 185);
            this.btnFindProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindProgram.Name = "btnFindProgram";
            this.btnFindProgram.Size = new System.Drawing.Size(178, 26);
            this.btnFindProgram.TabIndex = 4;
            this.btnFindProgram.Text = "Find Default Program";
            this.btnFindProgram.UseVisualStyleBackColor = true;
            this.btnFindProgram.Click += new System.EventHandler(this.btnFindProgram_Click);
            // 
            // btnlistall
            // 
            this.btnlistall.Location = new System.Drawing.Point(69, 221);
            this.btnlistall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlistall.Name = "btnlistall";
            this.btnlistall.Size = new System.Drawing.Size(178, 26);
            this.btnlistall.TabIndex = 5;
            this.btnlistall.Text = "List All";
            this.btnlistall.UseVisualStyleBackColor = true;
            this.btnlistall.Click += new System.EventHandler(this.btnlistall_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 255);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Current Entry";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(69, 291);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(178, 26);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Entries";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(939, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edit File Extension Defaults";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(939, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add Entry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(942, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Extension";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(942, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Program";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(307, 100);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(565, 154);
            this.txtDisplay.TabIndex = 14;
            // 
            // txtnewExt
            // 
            this.txtnewExt.Location = new System.Drawing.Point(1018, 155);
            this.txtnewExt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnewExt.Name = "txtnewExt";
            this.txtnewExt.Size = new System.Drawing.Size(89, 22);
            this.txtnewExt.TabIndex = 15;
            // 
            // txtNewProgram
            // 
            this.txtNewProgram.Location = new System.Drawing.Point(1018, 182);
            this.txtNewProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewProgram.Name = "txtNewProgram";
            this.txtNewProgram.Size = new System.Drawing.Size(89, 22);
            this.txtNewProgram.TabIndex = 16;
            // 
            // btnAddnewEntry
            // 
            this.btnAddnewEntry.Location = new System.Drawing.Point(940, 209);
            this.btnAddnewEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddnewEntry.Name = "btnAddnewEntry";
            this.btnAddnewEntry.Size = new System.Drawing.Size(167, 26);
            this.btnAddnewEntry.TabIndex = 17;
            this.btnAddnewEntry.Text = "Add New Entry";
            this.btnAddnewEntry.UseVisualStyleBackColor = true;
            this.btnAddnewEntry.Click += new System.EventHandler(this.btnAddnewEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 340);
            this.Controls.Add(this.btnAddnewEntry);
            this.Controls.Add(this.txtNewProgram);
            this.Controls.Add(this.txtnewExt);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnlistall);
            this.Controls.Add(this.btnFindProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "File Extension";
            this.Load += new System.EventHandler(this.FileExtensions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindProgram;
        private System.Windows.Forms.Button btnlistall;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtnewExt;
        private System.Windows.Forms.TextBox txtNewProgram;
        private System.Windows.Forms.Button btnAddnewEntry;
    }
}

