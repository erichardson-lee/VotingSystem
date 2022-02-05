namespace VotingSystemClasses.Interfaces
{
    interface IVoteHandler
    {
        public IOption GetWinner();

        public Result[] Results { get; }

        public IOptionsInfo GetOptions();

        void AddVote(IVoter voter, IOption option);
        void AddVote(IVoter voter, IOption[] options);


    }
}
