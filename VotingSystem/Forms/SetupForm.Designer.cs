namespace VotingSystem.Forms
{
    partial class SetupForm
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
            this.StartSystemBtn = new System.Windows.Forms.Button();
            this.AuditVoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartSystemBtn
            // 
            this.StartSystemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSystemBtn.Location = new System.Drawing.Point(12, 12);
            this.StartSystemBtn.Name = "StartSystemBtn";
            this.StartSystemBtn.Size = new System.Drawing.Size(265, 70);
            this.StartSystemBtn.TabIndex = 0;
            this.StartSystemBtn.Text = "Start System";
            this.StartSystemBtn.UseVisualStyleBackColor = true;
            this.StartSystemBtn.Click += new System.EventHandler(this.StartSystem);
            // 
            // AuditVoteBtn
            // 
            this.AuditVoteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditVoteBtn.Location = new System.Drawing.Point(12, 88);
            this.AuditVoteBtn.Name = "AuditVoteBtn";
            this.AuditVoteBtn.Size = new System.Drawing.Size(265, 41);
            this.AuditVoteBtn.TabIndex = 1;
            this.AuditVoteBtn.Text = "Audit Vote";
            this.AuditVoteBtn.UseVisualStyleBackColor = true;
            this.AuditVoteBtn.Click += new System.EventHandler(this.AuditVoteBtn_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 141);
            this.Controls.Add(this.AuditVoteBtn);
            this.Controls.Add(this.StartSystemBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartSystemBtn;
        private System.Windows.Forms.Button AuditVoteBtn;
    }
}