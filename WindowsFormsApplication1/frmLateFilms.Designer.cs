namespace WindowsFormsApplication1
{
    partial class frmLateFilms
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
            this.frmOkBtn = new System.Windows.Forms.Button();
            this.frmCancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frmFilmNameTB = new System.Windows.Forms.TextBox();
            this.addMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmOkBtn
            // 
            this.frmOkBtn.Location = new System.Drawing.Point(188, 86);
            this.frmOkBtn.Name = "frmOkBtn";
            this.frmOkBtn.Size = new System.Drawing.Size(75, 23);
            this.frmOkBtn.TabIndex = 0;
            this.frmOkBtn.Text = "Ok";
            this.frmOkBtn.UseVisualStyleBackColor = true;
            this.frmOkBtn.Click += new System.EventHandler(this.frmOkBtn_Click);
            // 
            // frmCancelBtn
            // 
            this.frmCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.frmCancelBtn.Location = new System.Drawing.Point(314, 86);
            this.frmCancelBtn.Name = "frmCancelBtn";
            this.frmCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.frmCancelBtn.TabIndex = 1;
            this.frmCancelBtn.Text = "Cancel";
            this.frmCancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Film Name";
            // 
            // frmFilmNameTB
            // 
            this.frmFilmNameTB.Location = new System.Drawing.Point(148, 38);
            this.frmFilmNameTB.Name = "frmFilmNameTB";
            this.frmFilmNameTB.Size = new System.Drawing.Size(115, 20);
            this.frmFilmNameTB.TabIndex = 3;
            // 
            // addMovie
            // 
            this.addMovie.Location = new System.Drawing.Point(314, 36);
            this.addMovie.Name = "addMovie";
            this.addMovie.Size = new System.Drawing.Size(75, 23);
            this.addMovie.TabIndex = 4;
            this.addMovie.Text = "&Add";
            this.addMovie.UseVisualStyleBackColor = true;
            this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
            // 
            // frmLateFilms
            // 
            this.AcceptButton = this.frmOkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.frmCancelBtn;
            this.ClientSize = new System.Drawing.Size(417, 143);
            this.Controls.Add(this.addMovie);
            this.Controls.Add(this.frmFilmNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmCancelBtn);
            this.Controls.Add(this.frmOkBtn);
            this.Name = "frmLateFilms";
            this.Text = "Late Films";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmOkBtn;
        private System.Windows.Forms.Button frmCancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frmFilmNameTB;
        private System.Windows.Forms.Button addMovie;
    }
}