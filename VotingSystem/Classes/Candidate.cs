using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Interfaces;

namespace VotingSystem.Classes
{
    class Candidate : IOption
    {
        string IOption.Label
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        string IOption.Value => this.ID;

        public string ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }
    }
}
