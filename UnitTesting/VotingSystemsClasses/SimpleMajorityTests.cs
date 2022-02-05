using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingSystemClasses;
using System.Linq;

namespace UnitTesting
{
    [TestClass]
    public class SimpleMajorityTests
    {
        SimpleMajority simpleMajority;


        [TestInitialize]
        public void BeforeEach()
        {
            simpleMajority = new SimpleMajority(TestData.singleVote);
        }


        /// <summary>
        /// Check the class has been correctly constructed
        /// </summary>
        [TestMethod]
        public void IsConstructed()
        {
            Assert.IsNotNull(this.simpleMajority);
        }


        /// <summary>
        /// Test if a single vote is added, the rusult will be correct
        /// </summary>
        [TestMethod]
        public void SingleVoter()
        {

            simpleMajority.AddVote(TestData.Voters[0], TestData.Candinates[0]);

            // Select the total for the first candinate
            int Total = simpleMajority.Results
                .Where(result => result.Option == TestData.Candinates[0])
                .Select(result => result.Total)
                .FirstOrDefault();

            Assert.AreEqual(1, Total);
        }

        /// <summary>
        /// Test if a multiple votes are added, the rusult will be correct
        /// </summary>
        [TestMethod]
        public void MultipleVotersSameOption()
        {
            simpleMajority.AddVote(TestData.Voters[0], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[1], TestData.Candinates[0]);

            // Select the total for the first candinate
            int Total = simpleMajority.Results
                .Where(result => result.Option == TestData.Candinates[0])
                .Select(result => result.Total)
                .FirstOrDefault();

            Assert.AreEqual(2, Total);
        }

        /// <summary>
        /// Test if a multiple votes are added, the rusult will be correct
        /// </summary>
        [TestMethod]
        public void MultipleVotersDifferentOption()
        {
            simpleMajority.AddVote(TestData.Voters[0], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[1], TestData.Candinates[1]);

            // Select the total for the first candinate
            int Total1 = simpleMajority.Results
                .Where(result => result.Option == TestData.Candinates[0])
                .Select(result => result.Total)
                .FirstOrDefault();

            // Select the total for the second candinate
            int Total2 = simpleMajority.Results
                .Where(result => result.Option == TestData.Candinates[1])
                .Select(result => result.Total)
                .FirstOrDefault();

            Assert.AreEqual(1, Total1);
            Assert.AreEqual(1, Total2);
        }

        /// <summary>
        /// Test if the getWinner Method returns the most popular option
        /// </summary>
        [TestMethod]
        public void WinnerWorks()
        {
            // 6 votes for candidate 0
            simpleMajority.AddVote(TestData.Voters[0], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[1], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[2], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[3], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[4], TestData.Candinates[0]);
            simpleMajority.AddVote(TestData.Voters[5], TestData.Candinates[0]);

            // 4 votes for candidate 1
            simpleMajority.AddVote(TestData.Voters[6], TestData.Candinates[1]);
            simpleMajority.AddVote(TestData.Voters[7], TestData.Candinates[1]);
            simpleMajority.AddVote(TestData.Voters[8], TestData.Candinates[1]);
            simpleMajority.AddVote(TestData.Voters[9], TestData.Candinates[1]);

            Assert.AreEqual(simpleMajority.GetWinner(), TestData.Candinates[0]);
        }
    }
}
