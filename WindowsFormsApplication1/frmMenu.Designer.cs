namespace WindowsFormsApplication1
{
    partial class frmMenu
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
            this.newReleaseBtn = new System.Windows.Forms.Button();
            this.libraryMoviesBtn = new System.Windows.Forms.Button();
            this.kidsMoviesBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLateFeeM = new System.Windows.Forms.Label();
            this.maintainFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newReleaseBtn
            // 
            this.newReleaseBtn.Location = new System.Drawing.Point(36, 28);
            this.newReleaseBtn.Name = "newReleaseBtn";
            this.newReleaseBtn.Size = new System.Drawing.Size(156, 34);
            this.newReleaseBtn.TabIndex = 0;
            this.newReleaseBtn.Text = "&New Release";
            this.newReleaseBtn.UseVisualStyleBackColor = true;
            this.newReleaseBtn.Click += new System.EventHandler(this.newReleaseBtn_Click);
            // 
            // libraryMoviesBtn
            // 
            this.libraryMoviesBtn.Location = new System.Drawing.Point(36, 84);
            this.libraryMoviesBtn.Name = "libraryMoviesBtn";
            this.libraryMoviesBtn.Size = new System.Drawing.Size(156, 34);
            this.libraryMoviesBtn.TabIndex = 1;
            this.libraryMoviesBtn.Text = "&Library Movie";
            this.libraryMoviesBtn.UseVisualStyleBackColor = true;
            this.libraryMoviesBtn.Click += new System.EventHandler(this.libraryMoviesBtn_Click);
            // 
            // kidsMoviesBtn
            // 
            this.kidsMoviesBtn.Location = new System.Drawing.Point(36, 142);
            this.kidsMoviesBtn.Name = "kidsMoviesBtn";
            this.kidsMoviesBtn.Size = new System.Drawing.Size(156, 34);
            this.kidsMoviesBtn.TabIndex = 2;
            this.kidsMoviesBtn.Text = "&Kids Movie";
            this.kidsMoviesBtn.UseVisualStyleBackColor = true;
            this.kidsMoviesBtn.Click += new System.EventHandler(this.kidsMoviesBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(36, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Late Fee";
            // 
            // totalLateFeeM
            // 
            this.totalLateFeeM.AutoSize = true;
            this.totalLateFeeM.Location = new System.Drawing.Point(140, 249);
            this.totalLateFeeM.Name = "totalLateFeeM";
            this.totalLateFeeM.Size = new System.Drawing.Size(13, 13);
            this.totalLateFeeM.TabIndex = 5;
            this.totalLateFeeM.Text = "0";
            // 
            // maintainFilm
            // 
            this.maintainFilm.Location = new System.Drawing.Point(36, 198);
            this.maintainFilm.Name = "maintainFilm";
            this.maintainFilm.Size = new System.Drawing.Size(156, 33);
            this.maintainFilm.TabIndex = 6;
            this.maintainFilm.Text = "Maintain Films";
            this.maintainFilm.UseVisualStyleBackColor = true;
            this.maintainFilm.Click += new System.EventHandler(this.MaintainFilm_Click);
            // 
            // frmMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 355);
            this.Controls.Add(this.maintainFilm);
            this.Controls.Add(this.totalLateFeeM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.kidsMoviesBtn);
            this.Controls.Add(this.libraryMoviesBtn);
            this.Controls.Add(this.newReleaseBtn);
            this.Name = "frmMenu";
            this.Text = "Late Fee Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newReleaseBtn;
        private System.Windows.Forms.Button libraryMoviesBtn;
        private System.Windows.Forms.Button kidsMoviesBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLateFeeM;
        private System.Windows.Forms.Button maintainFilm;
    }
}

