using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemClasses.Interfaces;

namespace VotingSystem.Events
{
    public class EventArgsOnVote : EventArgs
    {
        public IOption option;
    }
}
