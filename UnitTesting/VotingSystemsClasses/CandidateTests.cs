using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingSystemClasses;

namespace UnitTesting
{
    [TestClass]
    public class CandidateTests
    {
        Candidate candidate;

        [TestInitialize]
        public void BeforeEach()
        {
            candidate = new Candidate
            {
                ID = "ABC123",
                FirstName = "John",
                LastName = "Smith"
            };
        }


        /// <summary>
        /// Test if the class can be instantiated
        /// </summary>
        [TestMethod]
        public void IsCreated()
        {
            Assert.IsNotNull(candidate);
        }


        /// <summary>
        /// Check if the class has valid information from initialization
        /// </summary>
        [TestMethod]
        public void HasValidInfo()
        {
            Assert.AreEqual(candidate.ID, "ABC123");
            Assert.AreEqual(candidate.FirstName, "John");
            Assert.AreEqual(candidate.LastName, "Smith");
        }

        /// <summary>
        /// Check if the correct label is generated for the candidate
        /// </summary>
        [TestMethod]
        public void GeneratesValidLabel()
        {
            Assert.AreEqual(candidate.Label, "John Smith");
        }

    }
}
