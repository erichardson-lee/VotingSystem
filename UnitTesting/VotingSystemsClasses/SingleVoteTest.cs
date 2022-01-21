using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingSystemClasses;
using VotingSystemClasses.Interfaces;


namespace UnitTesting
{
    [TestClass]
    public class SingleVoteTest
    {

        static IOption[] Options = new Candidate[2] {
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

        SingleVote singleVote;


        [TestInitialize]
        public void BeforeEach()
        {
            singleVote = new SingleVote(Options);
        }


        /// <summary>
        /// Check the class has been correctly constructed
        /// </summary>
        [TestMethod]
        public void IsConstructed()
        {
            Assert.IsNotNull(singleVote);
        }

        /// <summary>
        /// Check that the vote isn't ordered
        /// (There is only one value)
        /// </summary>
        [TestMethod]
        public void IsNotOrdered()
        {
            Assert.AreEqual(singleVote.ordered, false);
        }

        /// <summary>
        /// Check that only one vote can be selected
        /// </summary>
        [TestMethod]
        public void Max1Selected()
        {
            Assert.AreEqual(singleVote.MaxSelected, 1);
        }
    }
}
