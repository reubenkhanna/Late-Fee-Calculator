namespace WindowsFormsApplication1
{
    partial class frmNewMovie
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
            this.lblNMMno = new System.Windows.Forms.TextBox();
            this.lblNMDesc = new System.Windows.Forms.TextBox();
            this.cbNMRating = new System.Windows.Forms.ComboBox();
            this.btnNMAdd = new System.Windows.Forms.Button();
            this.btnNMClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating";
            // 
            // lblNMMno
            // 
            this.lblNMMno.Location = new System.Drawing.Point(120, 27);
            this.lblNMMno.Name = "lblNMMno";
            this.lblNMMno.Size = new System.Drawing.Size(160, 20);
            this.lblNMMno.TabIndex = 3;
            this.lblNMMno.Tag = "Movie No.";
            // 
            // lblNMDesc
            // 
            this.lblNMDesc.Location = new System.Drawing.Point(120, 60);
            this.lblNMDesc.Name = "lblNMDesc";
            this.lblNMDesc.Size = new System.Drawing.Size(160, 20);
            this.lblNMDesc.TabIndex = 4;
            this.lblNMDesc.Tag = "Description";
            // 
            // cbNMRating
            // 
            this.cbNMRating.FormattingEnabled = true;
            this.cbNMRating.Location = new System.Drawing.Point(120, 93);
            this.cbNMRating.Name = "cbNMRating";
            this.cbNMRating.Size = new System.Drawing.Size(160, 21);
            this.cbNMRating.TabIndex = 5;
            this.cbNMRating.Tag = "Rating";
            // 
            // btnNMAdd
            // 
            this.btnNMAdd.Location = new System.Drawing.Point(120, 136);
            this.btnNMAdd.Name = "btnNMAdd";
            this.btnNMAdd.Size = new System.Drawing.Size(70, 23);
            this.btnNMAdd.TabIndex = 6;
            this.btnNMAdd.Text = "Save";
            this.btnNMAdd.UseVisualStyleBackColor = true;
            this.btnNMAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNMClear
            // 
            this.btnNMClear.Location = new System.Drawing.Point(210, 136);
            this.btnNMClear.Name = "btnNMClear";
            this.btnNMClear.Size = new System.Drawing.Size(70, 23);
            this.btnNMClear.TabIndex = 7;
            this.btnNMClear.Text = "Close";
            this.btnNMClear.UseVisualStyleBackColor = true;
            this.btnNMClear.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 171);
            this.Controls.Add(this.btnNMClear);
            this.Controls.Add(this.btnNMAdd);
            this.Controls.Add(this.cbNMRating);
            this.Controls.Add(this.lblNMDesc);
            this.Controls.Add(this.lblNMMno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewMovie";
            this.Text = "New Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblNMMno;
        private System.Windows.Forms.TextBox lblNMDesc;
        private System.Windows.Forms.ComboBox cbNMRating;
        private System.Windows.Forms.Button btnNMAdd;
        private System.Windows.Forms.Button btnNMClear;
    }
}