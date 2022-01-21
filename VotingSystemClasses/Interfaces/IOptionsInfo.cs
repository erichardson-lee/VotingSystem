namespace VotingSystemClasses.Interfaces
{
    public interface IOptionsInfo
    {
        public IOption[] Options { get; }

        public ushort MaxSelected { get; }

        public bool ordered { get; }
    }
}