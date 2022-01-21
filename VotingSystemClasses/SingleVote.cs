using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
{
    public class SingleVote : IOptionsInfo
    {
        public IOption[] Options { get; private set; }

        public ushort MaxSelected { get => 1; }

        public bool ordered { get => false; }

        public SingleVote(IOption[] options)
        {
            Options = options;
        }
    }
}