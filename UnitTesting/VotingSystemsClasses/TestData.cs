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
    }
}
