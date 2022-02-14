using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.Components;
using VotingSystemClasses;
using VotingSystemClasses.Interfaces;

namespace VotingSystem.Forms
{
    public partial class AuditForm : Form
    {
        IVoteHandler handler;

        public AuditForm(IVoteHandler handler)
        {
            this.handler = handler;
            InitializeComponent();

            SetupAuditComponents();
        }

        private void SetupAuditComponents()
        {
            flowLayoutPanel.Controls.Clear();

            flowLayoutPanel.SuspendLayout();

            foreach (Result result in handler.Results)
            {
                flowLayoutPanel.Controls.Add(new AuditComponent(result));
            }

            flowLayoutPanel.ResumeLayout();
        }
    }
}
