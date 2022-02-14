using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VotingSystem.Components;
using VotingSystem.Events;
using VotingSystemClasses;
using VotingSystemClasses.Interfaces;

namespace VotingSystem
{
    public partial class VotingForm : Form
    {
        IVoter voter;

        IVoteHandler voteHandler;

        static Regex UserIdRegex = new("[A-Za-z0-9]{8}");

        public VotingForm(IVoteHandler voteHandler)
        {
            InitializeComponent();
            this.voteHandler = voteHandler;

            InitializeOptions();

            VotingPanel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string voterID = textBox1.Text;

            if (!UserIdRegex.Match(voterID).Success)
            {
                MessageBox.Show("Invalid ID, must be 8 characters long", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            voter = new LocalVoter(voterID);
            VotingPanel.Enabled = true;
        }


        private void InitializeOptions()
        {
            OptionsLayoutPanel.Controls.Clear();

            OptionsLayoutPanel.SuspendLayout();

            foreach (IOption option in voteHandler.GetOptions().Options)
            {
                Vote_Option newOption = new Vote_Option(option);

                newOption.OnVote += new EventHandler<EventArgsOnVote>(OnVote);

                OptionsLayoutPanel.Controls.Add(newOption);
            }

            OptionsLayoutPanel.ResumeLayout();
        }

        private void OnVote(object sender, EventArgsOnVote e)
        {

            DialogResult res = MessageBox.Show($"Are you sure you want to vote for {e.option.Label}", "Confirm Choice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Must confirm voting choice
            if (res != DialogResult.OK)
            {
                return;
            }

            // Multiple selection is not implemented
            if (voteHandler.GetOptions().MaxSelected != 1)
            {
                throw new NotImplementedException();
            }


            // Ordered selection is not implemented
            if (voteHandler.GetOptions().ordered)
            {
                throw new NotImplementedException();
            }

            voteHandler.AddVote(voter, e.option);

            MessageBox.Show("Thanks for voting");

            ResetView();
        }

        private void ResetView()
        {
            VotingPanel.Enabled = false;
            textBox1.Text = "";
        }

        private void VotingForm_Load(object sender, EventArgs e)
        {

        }
    }

}
