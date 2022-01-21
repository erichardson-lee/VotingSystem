using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
{
    class SingleVote : IOptionsInfo
    {
        public IOption[] Options { get; private set; }

        public ushort MaxSelected { get => 1; }

        public bool ordered { get => false; }

        SingleVote(IOption[] options)
        {
            this.Options = options;
        }
    }
}