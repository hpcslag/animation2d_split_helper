namespace animation2d_splite_helper
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
            this.SelectFolderBtn = new System.Windows.Forms.Button();
            this.folderpathlabel = new System.Windows.Forms.Label();
            this.itext1 = new System.Windows.Forms.Label();
            this.processing = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderBtn.Location = new System.Drawing.Point(13, 26);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(135, 37);
            this.SelectFolderBtn.TabIndex = 0;
            this.SelectFolderBtn.Text = "Select Folder";
            this.SelectFolderBtn.UseVisualStyleBackColor = true;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // folderpathlabel
            // 
            this.folderpathlabel.AutoSize = true;
            this.folderpathlabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderpathlabel.Location = new System.Drawing.Point(13, 79);
            this.folderpathlabel.Name = "folderpathlabel";
            this.folderpathlabel.Size = new System.Drawing.Size(49, 14);
            this.folderpathlabel.TabIndex = 1;
            this.folderpathlabel.Text = "C:\\\\AA";
            // 
            // itext1
            // 
            this.itext1.AutoSize = true;
            this.itext1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itext1.Location = new System.Drawing.Point(13, 112);
            this.itext1.Name = "itext1";
            this.itext1.Size = new System.Drawing.Size(248, 36);
            this.itext1.TabIndex = 2;
            this.itext1.Text = "Find 0 image can be splite to \r\nAnimation 2d Sprite.";
            // 
            // processing
            // 
            this.processing.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processing.Location = new System.Drawing.Point(12, 230);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(273, 94);
            this.processing.TabIndex = 4;
            this.processing.Text = "Splite and Save";
            this.processing.UseVisualStyleBackColor = true;
            this.processing.Click += new System.EventHandler(this.processing_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 330);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(297, 361);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.processing);
            this.Controls.Add(this.itext1);
            this.Controls.Add(this.folderpathlabel);
            this.Controls.Add(this.SelectFolderBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFolderBtn;
        private System.Windows.Forms.Label folderpathlabel;
        private System.Windows.Forms.Label itext1;
        private System.Windows.Forms.Button processing;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

