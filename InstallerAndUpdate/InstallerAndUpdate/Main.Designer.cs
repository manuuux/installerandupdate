namespace InstallerAndUpdate
{
    partial class Main
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
            this.Closebutton = new System.Windows.Forms.Button();
            this.loadertxt = new System.Windows.Forms.Label();
            this.DownloadPgr = new System.Windows.Forms.ProgressBar();
            this.DownloadLbl = new System.Windows.Forms.Label();
            this.FilenameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installer\'n Update";
            // 
            // Closebutton
            // 
            this.Closebutton.FlatAppearance.BorderSize = 0;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Location = new System.Drawing.Point(475, -2);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(24, 24);
            this.Closebutton.TabIndex = 1;
            this.Closebutton.Text = "X";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // loadertxt
            // 
            this.loadertxt.AutoSize = true;
            this.loadertxt.Location = new System.Drawing.Point(222, 154);
            this.loadertxt.Name = "loadertxt";
            this.loadertxt.Size = new System.Drawing.Size(53, 13);
            this.loadertxt.TabIndex = 2;
            this.loadertxt.Text = "Cargando";
            // 
            // DownloadPgr
            // 
            this.DownloadPgr.Location = new System.Drawing.Point(16, 77);
            this.DownloadPgr.Name = "DownloadPgr";
            this.DownloadPgr.Size = new System.Drawing.Size(460, 20);
            this.DownloadPgr.TabIndex = 3;
            // 
            // DownloadLbl
            // 
            this.DownloadLbl.AutoSize = true;
            this.DownloadLbl.Location = new System.Drawing.Point(16, 54);
            this.DownloadLbl.Name = "DownloadLbl";
            this.DownloadLbl.Size = new System.Drawing.Size(80, 13);
            this.DownloadLbl.TabIndex = 4;
            this.DownloadLbl.Text = "Descargando...";
            // 
            // FilenameLbl
            // 
            this.FilenameLbl.AutoSize = true;
            this.FilenameLbl.Location = new System.Drawing.Point(16, 110);
            this.FilenameLbl.Name = "FilenameLbl";
            this.FilenameLbl.Size = new System.Drawing.Size(66, 13);
            this.FilenameLbl.TabIndex = 5;
            this.FilenameLbl.Text = "Filename.ext";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 176);
            this.ControlBox = false;
            this.Controls.Add(this.FilenameLbl);
            this.Controls.Add(this.DownloadLbl);
            this.Controls.Add(this.DownloadPgr);
            this.Controls.Add(this.loadertxt);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Label loadertxt;
        private System.Windows.Forms.ProgressBar DownloadPgr;
        private System.Windows.Forms.Label DownloadLbl;
        private System.Windows.Forms.Label FilenameLbl;
    }
}

