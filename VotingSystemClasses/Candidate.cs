using VotingSystemClasses.Interfaces;


namespace VotingSystemClasses
{
    public class Candidate : IOption
    {
        public string Label
        {
            get => $"{FirstName} {LastName}";
        }

        string IOption.Value => this.ID;

        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
