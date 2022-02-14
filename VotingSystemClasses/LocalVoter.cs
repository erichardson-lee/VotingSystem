using System;
using VotingSystemClasses.Interfaces;


namespace VotingSystemClasses
{
    public class LocalVoter : IVoter
    {
        private string _id;

        public string getId()
        {
            return _id;
        }

        public LocalVoter(string ID)
        {
            _id = ID;
        }
    }

}
