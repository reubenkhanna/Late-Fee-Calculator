namespace WindowsFormsApplication1
{
    partial class frmRentalMaintenance
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
            this.listMovieBox = new System.Windows.Forms.ListBox();
            this.btnRMAdd = new System.Windows.Forms.Button();
            this.btnRMdel = new System.Windows.Forms.Button();
            this.btnRMClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMovieBox
            // 
            this.listMovieBox.FormattingEnabled = true;
            this.listMovieBox.Location = new System.Drawing.Point(13, 13);
            this.listMovieBox.Name = "listMovieBox";
            this.listMovieBox.Size = new System.Drawing.Size(412, 290);
            this.listMovieBox.TabIndex = 0;
            // 
            // btnRMAdd
            // 
            this.btnRMAdd.Location = new System.Drawing.Point(431, 13);
            this.btnRMAdd.Name = "btnRMAdd";
            this.btnRMAdd.Size = new System.Drawing.Size(108, 23);
            this.btnRMAdd.TabIndex = 1;
            this.btnRMAdd.Text = "Add Movie";
            this.btnRMAdd.UseVisualStyleBackColor = true;
            this.btnRMAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRMdel
            // 
            this.btnRMdel.Location = new System.Drawing.Point(432, 63);
            this.btnRMdel.Name = "btnRMdel";
            this.btnRMdel.Size = new System.Drawing.Size(107, 23);
            this.btnRMdel.TabIndex = 2;
            this.btnRMdel.Text = "Delete Movie";
            this.btnRMdel.UseVisualStyleBackColor = true;
            this.btnRMdel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRMClose
            // 
            this.btnRMClose.Location = new System.Drawing.Point(432, 113);
            this.btnRMClose.Name = "btnRMClose";
            this.btnRMClose.Size = new System.Drawing.Size(107, 23);
            this.btnRMClose.TabIndex = 3;
            this.btnRMClose.Text = "Close";
            this.btnRMClose.UseVisualStyleBackColor = true;
            this.btnRMClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRentalMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 323);
            this.Controls.Add(this.btnRMClose);
            this.Controls.Add(this.btnRMdel);
            this.Controls.Add(this.btnRMAdd);
            this.Controls.Add(this.listMovieBox);
            this.Name = "frmRentalMaintenance";
            this.Text = "Rental Maintenance";
            this.Load += new System.EventHandler(this.FrmRentalMaintenance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMovieBox;
        private System.Windows.Forms.Button btnRMAdd;
        private System.Windows.Forms.Button btnRMdel;
        private System.Windows.Forms.Button btnRMClose;
    }
}