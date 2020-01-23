namespace WindowsFormsApplication1
{
    partial class frmKidsMovies
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
            this.lateFeeKM = new System.Windows.Forms.TextBox();
            this.noOfDaysLateKM = new System.Windows.Forms.TextBox();
            this.currentDateKM = new System.Windows.Forms.DateTimePicker();
            this.dueDateKM = new System.Windows.Forms.DateTimePicker();
            this.returnKM = new System.Windows.Forms.Button();
            this.calculateKM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frmCBBoxKM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMovie = new System.Windows.Forms.Button();
            this.noOfMoviesKM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lateFeeKM
            // 
            this.lateFeeKM.Location = new System.Drawing.Point(143, 232);
            this.lateFeeKM.Name = "lateFeeKM";
            this.lateFeeKM.ReadOnly = true;
            this.lateFeeKM.Size = new System.Drawing.Size(200, 20);
            this.lateFeeKM.TabIndex = 18;
            // 
            // noOfDaysLateKM
            // 
            this.noOfDaysLateKM.Location = new System.Drawing.Point(143, 187);
            this.noOfDaysLateKM.Name = "noOfDaysLateKM";
            this.noOfDaysLateKM.ReadOnly = true;
            this.noOfDaysLateKM.Size = new System.Drawing.Size(200, 20);
            this.noOfDaysLateKM.TabIndex = 15;
            // 
            // currentDateKM
            // 
            this.currentDateKM.Enabled = false;
            this.currentDateKM.Location = new System.Drawing.Point(143, 66);
            this.currentDateKM.Name = "currentDateKM";
            this.currentDateKM.Size = new System.Drawing.Size(200, 20);
            this.currentDateKM.TabIndex = 13;
            // 
            // dueDateKM
            // 
            this.dueDateKM.Location = new System.Drawing.Point(143, 22);
            this.dueDateKM.Name = "dueDateKM";
            this.dueDateKM.Size = new System.Drawing.Size(200, 20);
            this.dueDateKM.TabIndex = 11;
            // 
            // returnKM
            // 
            this.returnKM.Location = new System.Drawing.Point(250, 275);
            this.returnKM.Name = "returnKM";
            this.returnKM.Size = new System.Drawing.Size(93, 23);
            this.returnKM.TabIndex = 16;
            this.returnKM.Text = "&Return Button";
            this.returnKM.UseVisualStyleBackColor = true;
            this.returnKM.Click += new System.EventHandler(this.returnKM_Click);
            // 
            // calculateKM
            // 
            this.calculateKM.Location = new System.Drawing.Point(143, 275);
            this.calculateKM.Name = "calculateKM";
            this.calculateKM.Size = new System.Drawing.Size(75, 23);
            this.calculateKM.TabIndex = 19;
            this.calculateKM.Text = "&Calculate Button";
            this.calculateKM.UseVisualStyleBackColor = true;
            this.calculateKM.Click += new System.EventHandler(this.calculateKM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "&Late Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "&Number of Days Late";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "&Curent Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "&Due Date";
            // 
            // frmCBBoxKM
            // 
            this.frmCBBoxKM.FormattingEnabled = true;
            this.frmCBBoxKM.Location = new System.Drawing.Point(143, 149);
            this.frmCBBoxKM.Name = "frmCBBoxKM";
            this.frmCBBoxKM.Size = new System.Drawing.Size(200, 21);
            this.frmCBBoxKM.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Customer Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "No of Movies";
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(268, 111);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(75, 23);
            this.addMovie.TabIndex = 24;
            this.addMovie.Text = "Add Movie";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // noOfMoviesKM
            // 
            this.noOfMoviesKM.AutoSize = true;
            this.noOfMoviesKM.Location = new System.Drawing.Point(140, 116);
            this.noOfMoviesKM.Name = "noOfMoviesKM";
            this.noOfMoviesKM.Size = new System.Drawing.Size(13, 13);
            this.noOfMoviesKM.TabIndex = 25;
            this.noOfMoviesKM.Text = "0";
            // 
            // frmKidsMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 334);
            this.Controls.Add(this.noOfMoviesKM);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.frmCBBoxKM);
            this.Controls.Add(this.lateFeeKM);
            this.Controls.Add(this.noOfDaysLateKM);
            this.Controls.Add(this.currentDateKM);
            this.Controls.Add(this.dueDateKM);
            this.Controls.Add(this.returnKM);
            this.Controls.Add(this.calculateKM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKidsMovies";
            this.Text = "frmKidsMovies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lateFeeKM;
        private System.Windows.Forms.TextBox noOfDaysLateKM;
        private System.Windows.Forms.DateTimePicker currentDateKM;
        private System.Windows.Forms.DateTimePicker dueDateKM;
        private System.Windows.Forms.Button returnKM;
        private System.Windows.Forms.Button calculateKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frmCBBoxKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMovie;
        private System.Windows.Forms.Label noOfMoviesKM;
    }
}