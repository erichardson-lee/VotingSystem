
namespace VotingSystem
{
    partial class VotingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authenticateBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VotingPanel = new System.Windows.Forms.Panel();
            this.OptionsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.votingLabel = new System.Windows.Forms.Label();
            this.VotingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // authenticateBtn
            // 
            this.authenticateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authenticateBtn.Location = new System.Drawing.Point(680, 9);
            this.authenticateBtn.Name = "authenticateBtn";
            this.authenticateBtn.Size = new System.Drawing.Size(86, 23);
            this.authenticateBtn.TabIndex = 0;
            this.authenticateBtn.Text = "Authenticate";
            this.authenticateBtn.UseVisualStyleBackColor = true;
            this.authenticateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(506, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "8 Character User ID";
            // 
            // VotingPanel
            // 
            this.VotingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VotingPanel.Controls.Add(this.OptionsLayoutPanel);
            this.VotingPanel.Enabled = false;
            this.VotingPanel.Location = new System.Drawing.Point(12, 39);
            this.VotingPanel.Name = "VotingPanel";
            this.VotingPanel.Size = new System.Drawing.Size(754, 464);
            this.VotingPanel.TabIndex = 3;
            // 
            // OptionsLayoutPanel
            // 
            this.OptionsLayoutPanel.AutoScroll = true;
            this.OptionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OptionsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsLayoutPanel.Name = "OptionsLayoutPanel";
            this.OptionsLayoutPanel.Size = new System.Drawing.Size(754, 464);
            this.OptionsLayoutPanel.TabIndex = 0;
            this.OptionsLayoutPanel.WrapContents = false;
            // 
            // votingLabel
            // 
            this.votingLabel.AutoSize = true;
            this.votingLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.votingLabel.Location = new System.Drawing.Point(12, 3);
            this.votingLabel.Name = "votingLabel";
            this.votingLabel.Size = new System.Drawing.Size(242, 30);
            this.votingLabel.TabIndex = 4;
            this.votingLabel.Text = "SBMM E-Voting System";
            // 
            // VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 515);
            this.Controls.Add(this.votingLabel);
            this.Controls.Add(this.VotingPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.authenticateBtn);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "VotingForm";
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.VotingForm_Load);
            this.VotingPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authenticateBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel VotingPanel;
        private System.Windows.Forms.FlowLayoutPanel OptionsLayoutPanel;
        private System.Windows.Forms.Label votingLabel;
    }
}

