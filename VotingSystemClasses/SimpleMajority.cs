using System;
using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
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
