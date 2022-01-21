namespace VotingSystemClasses.Interfaces
{
    interface IVoteHandler
    {
        public Result[] results { get; }

        public IOptionsInfo getOptions();

        void AddVote(IVoter voter, IOption option);
        void AddVote(IVoter voter, IOption[] options);


    }
}
