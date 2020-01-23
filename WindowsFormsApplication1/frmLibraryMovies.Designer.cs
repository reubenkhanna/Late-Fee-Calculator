namespace WindowsFormsApplication1
{
    partial class frmLibraryMovies
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
            this.lateFeeLM = new System.Windows.Forms.TextBox();
            this.noOfDaysLateLM = new System.Windows.Forms.TextBox();
            this.currentDateLM = new System.Windows.Forms.DateTimePicker();
            this.dueDateLM = new System.Windows.Forms.DateTimePicker();
            this.returnLM = new System.Windows.Forms.Button();
            this.calculateLM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.frmCBBoxLM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noOfMovieLM = new System.Windows.Forms.Label();
            this.addMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lateFeeLM
            // 
            this.lateFeeLM.Location = new System.Drawing.Point(134, 223);
            this.lateFeeLM.Name = "lateFeeLM";
            this.lateFeeLM.ReadOnly = true;
            this.lateFeeLM.Size = new System.Drawing.Size(200, 20);
            this.lateFeeLM.TabIndex = 18;
            // 
            // noOfDaysLateLM
            // 
            this.noOfDaysLateLM.Location = new System.Drawing.Point(134, 183);
            this.noOfDaysLateLM.Name = "noOfDaysLateLM";
            this.noOfDaysLateLM.ReadOnly = true;
            this.noOfDaysLateLM.Size = new System.Drawing.Size(200, 20);
            this.noOfDaysLateLM.TabIndex = 15;
            // 
            // currentDateLM
            // 
            this.currentDateLM.Enabled = false;
            this.currentDateLM.Location = new System.Drawing.Point(134, 62);
            this.currentDateLM.Name = "currentDateLM";
            this.currentDateLM.Size = new System.Drawing.Size(200, 20);
            this.currentDateLM.TabIndex = 13;
            // 
            // dueDateLM
            // 
            this.dueDateLM.Location = new System.Drawing.Point(134, 22);
            this.dueDateLM.Name = "dueDateLM";
            this.dueDateLM.Size = new System.Drawing.Size(200, 20);
            this.dueDateLM.TabIndex = 11;
            // 
            // returnLM
            // 
            this.returnLM.Location = new System.Drawing.Point(241, 278);
            this.returnLM.Name = "returnLM";
            this.returnLM.Size = new System.Drawing.Size(93, 23);
            this.returnLM.TabIndex = 16;
            this.returnLM.Text = "&Return Button";
            this.returnLM.UseVisualStyleBackColor = true;
            this.returnLM.Click += new System.EventHandler(this.returnLM_Click);
            // 
            // calculateLM
            // 
            this.calculateLM.Location = new System.Drawing.Point(134, 278);
            this.calculateLM.Name = "calculateLM";
            this.calculateLM.Size = new System.Drawing.Size(75, 23);
            this.calculateLM.TabIndex = 19;
            this.calculateLM.Text = "&Calculate Button";
            this.calculateLM.UseVisualStyleBackColor = true;
            this.calculateLM.Click += new System.EventHandler(this.calculateLM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "&Late Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "&Number of Days Late";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "&Curent Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "&Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Customer Type";
            // 
            // frmCBBoxLM
            // 
            this.frmCBBoxLM.FormattingEnabled = true;
            this.frmCBBoxLM.Location = new System.Drawing.Point(134, 142);
            this.frmCBBoxLM.Name = "frmCBBoxLM";
            this.frmCBBoxLM.Size = new System.Drawing.Size(200, 21);
            this.frmCBBoxLM.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "No of Movies";
            // 
            // noOfMovieLM
            // 
            this.noOfMovieLM.AutoSize = true;
            this.noOfMovieLM.Location = new System.Drawing.Point(131, 110);
            this.noOfMovieLM.Name = "noOfMovieLM";
            this.noOfMovieLM.Size = new System.Drawing.Size(13, 13);
            this.noOfMovieLM.TabIndex = 29;
            this.noOfMovieLM.Text = "0";
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(259, 105);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(75, 23);
            this.addMovie.TabIndex = 28;
            this.addMovie.Text = "Add Movie";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // frmLibraryMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 324);
            this.Controls.Add(this.noOfMovieLM);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.frmCBBoxLM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lateFeeLM);
            this.Controls.Add(this.noOfDaysLateLM);
            this.Controls.Add(this.currentDateLM);
            this.Controls.Add(this.dueDateLM);
            this.Controls.Add(this.returnLM);
            this.Controls.Add(this.calculateLM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLibraryMovies";
            this.Text = "Library Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lateFeeLM;
        private System.Windows.Forms.TextBox noOfDaysLateLM;
        private System.Windows.Forms.DateTimePicker currentDateLM;
        private System.Windows.Forms.DateTimePicker dueDateLM;
        private System.Windows.Forms.Button returnLM;
        private System.Windows.Forms.Button calculateLM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox frmCBBoxLM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noOfMovieLM;
        private System.Windows.Forms.Button addMovie;
    }
}