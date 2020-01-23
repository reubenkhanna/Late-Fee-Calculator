namespace WindowsFormsApplication1
{
    partial class frmNewReleases
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateNR = new System.Windows.Forms.Button();
            this.returnNR = new System.Windows.Forms.Button();
            this.dueDateNR = new System.Windows.Forms.DateTimePicker();
            this.currentDateNR = new System.Windows.Forms.DateTimePicker();
            this.noOfDaysLateNR = new System.Windows.Forms.TextBox();
            this.lateFeeNR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.frmCBBoxNR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noOfMoviesNR = new System.Windows.Forms.Label();
            this.addMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Curent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Number of Days Late";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Late Fee";
            // 
            // calculateNR
            // 
            this.calculateNR.Location = new System.Drawing.Point(136, 273);
            this.calculateNR.Name = "calculateNR";
            this.calculateNR.Size = new System.Drawing.Size(75, 23);
            this.calculateNR.TabIndex = 9;
            this.calculateNR.Text = "&Calculate Button";
            this.calculateNR.UseVisualStyleBackColor = true;
            this.calculateNR.Click += new System.EventHandler(this.calculateNR_Click);
            // 
            // returnNR
            // 
            this.returnNR.Location = new System.Drawing.Point(243, 273);
            this.returnNR.Name = "returnNR";
            this.returnNR.Size = new System.Drawing.Size(93, 23);
            this.returnNR.TabIndex = 5;
            this.returnNR.Text = "&Return Button";
            this.returnNR.UseVisualStyleBackColor = true;
            this.returnNR.Click += new System.EventHandler(this.returnNR_Click);
            // 
            // dueDateNR
            // 
            this.dueDateNR.Location = new System.Drawing.Point(136, 23);
            this.dueDateNR.Name = "dueDateNR";
            this.dueDateNR.Size = new System.Drawing.Size(200, 20);
            this.dueDateNR.TabIndex = 1;
            // 
            // currentDateNR
            // 
            this.currentDateNR.Enabled = false;
            this.currentDateNR.Location = new System.Drawing.Point(136, 63);
            this.currentDateNR.Name = "currentDateNR";
            this.currentDateNR.Size = new System.Drawing.Size(200, 20);
            this.currentDateNR.TabIndex = 3;
            // 
            // noOfDaysLateNR
            // 
            this.noOfDaysLateNR.Location = new System.Drawing.Point(136, 184);
            this.noOfDaysLateNR.Name = "noOfDaysLateNR";
            this.noOfDaysLateNR.ReadOnly = true;
            this.noOfDaysLateNR.Size = new System.Drawing.Size(200, 20);
            this.noOfDaysLateNR.TabIndex = 5;
            // 
            // lateFeeNR
            // 
            this.lateFeeNR.Location = new System.Drawing.Point(136, 224);
            this.lateFeeNR.Name = "lateFeeNR";
            this.lateFeeNR.ReadOnly = true;
            this.lateFeeNR.Size = new System.Drawing.Size(200, 20);
            this.lateFeeNR.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Customer Type";
            // 
            // frmCBBoxNR
            // 
            this.frmCBBoxNR.FormattingEnabled = true;
            this.frmCBBoxNR.Location = new System.Drawing.Point(136, 143);
            this.frmCBBoxNR.Name = "frmCBBoxNR";
            this.frmCBBoxNR.Size = new System.Drawing.Size(200, 21);
            this.frmCBBoxNR.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "No of Movies";
            // 
            // noOfMoviesNR
            // 
            this.noOfMoviesNR.AutoSize = true;
            this.noOfMoviesNR.Location = new System.Drawing.Point(133, 111);
            this.noOfMoviesNR.Name = "noOfMoviesNR";
            this.noOfMoviesNR.Size = new System.Drawing.Size(13, 13);
            this.noOfMoviesNR.TabIndex = 33;
            this.noOfMoviesNR.Text = "0";
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(261, 106);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(75, 23);
            this.addMovie.TabIndex = 32;
            this.addMovie.Text = "Add Movie";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // frmNewReleases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 318);
            this.Controls.Add(this.noOfMoviesNR);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.frmCBBoxNR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lateFeeNR);
            this.Controls.Add(this.noOfDaysLateNR);
            this.Controls.Add(this.currentDateNR);
            this.Controls.Add(this.dueDateNR);
            this.Controls.Add(this.returnNR);
            this.Controls.Add(this.calculateNR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewReleases";
            this.Text = "New Releases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateNR;
        private System.Windows.Forms.Button returnNR;
        private System.Windows.Forms.DateTimePicker dueDateNR;
        private System.Windows.Forms.DateTimePicker currentDateNR;
        private System.Windows.Forms.TextBox noOfDaysLateNR;
        private System.Windows.Forms.TextBox lateFeeNR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox frmCBBoxNR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label noOfMoviesNR;
        private System.Windows.Forms.Button addMovie;
    }
}