using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemClasses;
using VotingSystemClasses.Interfaces;

namespace VotingSystem.Forms
{
    public partial class SetupForm : Form
    {
        VotingForm menuForm;
        AuditForm auditForm;

        IVoteHandler handler = new SimpleMajority(
                new SingleVote(
                    new[] {
                        new Candidate() { ID="1", FirstName = "Robert", LastName = "Lara" },
                        new Candidate() { ID="2", FirstName = "Alexander", LastName = "Lindsey" },
                        new Candidate() { ID="3", FirstName = "Frank", LastName = "Spires" }
                    }
                )
            );


        public SetupForm()
        {
            InitializeComponent();
        }

        private void StartSystem(object sender, EventArgs e)
        {

            menuForm = new VotingForm(handler);
            menuForm.ShowDialog();
        }

        private void AuditVote()
        {
            auditForm = new AuditForm(handler);
            auditForm.ShowDialog();
        }

        private void AuditVoteBtn_Click(object sender, EventArgs e)
        {
            AuditVote();
        }
    }
}
