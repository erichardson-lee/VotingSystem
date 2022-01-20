using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.Interfaces
{
    interface IVoteHandler
    {
        public Classes.Result[] results { get; }

        public IOptionsInfo getOptions();

        void AddVote(IVoter voter, IOption option);
        void AddVote(IVoter voter, IOption[] options);


    }
}
