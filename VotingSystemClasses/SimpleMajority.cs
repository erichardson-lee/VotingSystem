using System;
using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
{
    public class SimpleMajority : IVoteHandler
    {

        public readonly IOptionsInfo optionsInfo;

        public SimpleMajority(IOptionsInfo optionsInfo) => this.optionsInfo = optionsInfo;

        public IOption GetWinner()
        {
            throw new NotImplementedException();
        }

        public Result[] Results => throw new NotImplementedException();

        public void AddVote(IVoter voter, IOption option)
        {
            throw new NotImplementedException();
        }

        public void AddVote(IVoter voter, IOption[] options)
        {
            throw new NotImplementedException();
        }

        public IOptionsInfo GetOptions()
        {
            throw new NotImplementedException();
        }

    }
}
