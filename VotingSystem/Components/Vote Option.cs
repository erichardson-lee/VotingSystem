using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.Events;
using VotingSystemClasses.Interfaces;

namespace VotingSystem.Components
{

    public partial class Vote_Option : UserControl
    {
        IOption option;

        public event EventHandler<EventArgsOnVote> OnVote;

        public Vote_Option(IOption option)
        {
            this.option = option;
            InitializeComponent();

            voteButton.Text = option.Label.ToString();
        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            OnVote.Invoke(this, new EventArgsOnVote()
            {
                option = option
            });
        }
    }
}
