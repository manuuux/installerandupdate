namespace InstallerAndUpdate
{
    partial class Readme
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
            this.ReadmeTxt = new System.Windows.Forms.TextBox();
            this.ReadmeLbl = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadmeTxt
            // 
            this.ReadmeTxt.Location = new System.Drawing.Point(12, 44);
            this.ReadmeTxt.Multiline = true;
            this.ReadmeTxt.Name = "ReadmeTxt";
            this.ReadmeTxt.Size = new System.Drawing.Size(554, 142);
            this.ReadmeTxt.TabIndex = 0;
            // 
            // ReadmeLbl
            // 
            this.ReadmeLbl.AutoSize = true;
            this.ReadmeLbl.Location = new System.Drawing.Point(9, 18);
            this.ReadmeLbl.Name = "ReadmeLbl";
            this.ReadmeLbl.Size = new System.Drawing.Size(39, 13);
            this.ReadmeLbl.TabIndex = 1;
            this.ReadmeLbl.Text = "Leeme";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(458, 201);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(108, 23);
            this.AcceptBtn.TabIndex = 2;
            this.AcceptBtn.Text = "Aceptar e Instalar";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            // 
            // Readme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 236);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.ReadmeLbl);
            this.Controls.Add(this.ReadmeTxt);
            this.Name = "Readme";
            this.Text = "Readme";
            this.Load += new System.EventHandler(this.Readme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReadmeTxt;
        private System.Windows.Forms.Label ReadmeLbl;
        private System.Windows.Forms.Button AcceptBtn;
    }
}