namespace VotingSystem.Components
{
    partial class Vote_Option
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voteButton
            // 
            this.voteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voteButton.Location = new System.Drawing.Point(3, 3);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(641, 144);
            this.voteButton.TabIndex = 0;
            this.voteButton.Text = "VOTE FOR ++++++";
            this.voteButton.UseVisualStyleBackColor = true;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // Vote_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.voteButton);
            this.Name = "Vote_Option";
            this.Size = new System.Drawing.Size(647, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voteButton;
    }
}
