using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Interfaces;

namespace VotingSystem.Classes
{
    class SingleVote : IOptionsInfo
    {
        public IOption[] Options { get; private set; }

        public ushort MaxSelected { get => 1; }

        public bool ordered { get => false; }

        SingleVote(IOption[] options)
        {
            this.Options = options;
        }
    }
}