using VotingSystemClasses;
using VotingSystemClasses.Interfaces;

namespace UnitTesting
{
    class TestData
    {
        public static IOption[] Candinates = new Candidate[2] {
            new Candidate()
            {
                FirstName = "John",
                LastName = "Smith",
                ID = "ABC123",
            },
            new Candidate()
            {
                FirstName = "Carl",
                LastName = "Berg",
                ID = "123ABC",
            }
        };


        public static IVoter[] Voters = new IVoter[10] {
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter(),
            new LocalVoter()
        };


        public static SingleVote singleVote = new SingleVote(Candinates);
    }
}
