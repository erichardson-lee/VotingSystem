using System;
using System.Collections.Generic;
using VotingSystemClasses.Interfaces;

namespace VotingSystemClasses
{
    public class SimpleMajority : IVoteHandler
    {
        public readonly IOptionsInfo optionsInfo;
        private Dictionary<IVoter, IOption[]> votes;

        public SimpleMajority(IOptionsInfo optionsInfo)
        {
            this.optionsInfo = optionsInfo;

            this.votes = new Dictionary<IVoter, IOption[]>();
        }

        public IOption GetWinner()
        {
            Result[] results = this.Results;

            IOption max = null;
            int maxCount = 0;


            // O(n) check of the results
            foreach (Result result in results)
            {
                if (result.Total > maxCount)
                {
                    max = result.Option;
                    maxCount = result.Total;
                }
            }

            return max;
        }

        public Result[] Results
        {
            get
            {
                Dictionary<IOption, int> resultDict = new();

                var vals = votes.Values.GetEnumerator();

                while (vals.MoveNext())
                {
                    var options = vals.Current;

                    foreach (var option in options)
                    {
                        resultDict[option] = resultDict.GetValueOrDefault(option) + 1;
                    }
                }

                vals.Dispose();

                List<Result> results = new List<Result>();

                var kv = resultDict.GetEnumerator();

                while (kv.MoveNext())
                {
                    results.Add(new Result(kv.Current.Key, kv.Current.Value));
                }

                return results.ToArray();

            }

        }


        public void AddVote(IVoter voter, IOption option)
        {
            AddVote(voter, new IOption[] { option });
        }

        public void AddVote(IVoter voter, IOption[] options)
        {
            if (options.Length > optionsInfo.MaxSelected)
            {
                throw new ArgumentException($"Too many Options selected, you can only select up to {optionsInfo.MaxSelected}");
            }

            votes[voter] = options;
        }

        public IOptionsInfo GetOptions()
        {
            throw new NotImplementedException();
        }

    }
}
