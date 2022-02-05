using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
{
    public class Result
    {
        public IOption Option { get; private set; }

        public int Total { get; private set; }

        public Result(IOption option, int total)
        {
            Option = option;
            Total = total;
        }
    }
}
