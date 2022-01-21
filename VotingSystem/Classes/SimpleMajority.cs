using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Interfaces;

namespace VotingSystem.Classes
{
    class SimpleMajority : IVoteHandler
    {
        public Result[] results => throw new NotImplementedException();

        public void AddVote(IVoter voter, IOption option)
        {
            throw new NotImplementedException();
        }

        public void AddVote(IVoter voter, IOption[] options)
        {
            throw new NotImplementedException();
        }

        public IOptionsInfo getOptions()
        {
            throw new NotImplementedException();
        }
    }
}
