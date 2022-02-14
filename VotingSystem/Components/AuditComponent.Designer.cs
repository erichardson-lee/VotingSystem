namespace VotingSystem.Components
{
    partial class AuditComponent
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
            this.OptionLabel = new System.Windows.Forms.Label();
            this.OptionCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionLabel
            // 
            this.OptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionLabel.AutoSize = true;
            this.OptionLabel.Location = new System.Drawing.Point(108, 0);
            this.OptionLabel.Name = "OptionLabel";
            this.OptionLabel.Size = new System.Drawing.Size(72, 30);
            this.OptionLabel.TabIndex = 0;
            this.OptionLabel.Text = "OptionLabel";
            this.OptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OptionCount
            // 
            this.OptionCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OptionCount.AutoSize = true;
            this.OptionCount.Location = new System.Drawing.Point(186, 0);
            this.OptionCount.Name = "OptionCount";
            this.OptionCount.Size = new System.Drawing.Size(77, 30);
            this.OptionCount.TabIndex = 1;
            this.OptionCount.Text = "OptionCount";
            this.OptionCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.OptionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OptionCount, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 30);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AuditComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AuditComponent";
            this.Size = new System.Drawing.Size(372, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OptionLabel;
        private System.Windows.Forms.Label OptionCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
