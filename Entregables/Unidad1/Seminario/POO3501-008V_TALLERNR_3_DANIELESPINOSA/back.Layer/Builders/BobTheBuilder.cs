using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace back.Layer.Builders
{
    public class BobTheBuilder
    {
        public Candidate[] VotesMatrixBuilder(Candidate[] candidates)
        {
            Random rand = new Random();
            for(int i=0; i< candidates.Length; i++)
            {
                for(int j=0;j< candidates[i].VotesCount.Length; j++)
                {
                    candidates[i].VotesCount[j] = rand.Next(1,1001);
                }
            }
            return candidates;
        }

        public Candidate[] CandidatesBuilder(int quantity, int districts)
        {
            Candidate[] candidates = new Candidate[quantity];
            for (int i = 0; i < quantity; i++)
            {
                candidates[i] = new Candidate();
                candidates[i].Name = string.Format("Candidato {0}", (i + 1));
                candidates[i].VotesCount = new int[districts];
            }
            return candidates;
        }

        public string PrintVotesMatrix(Candidate[] candidates)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < candidates.Length; i++)
            {
                sb.Append(string.Concat(candidates[i].Name,"\t"));
                for(int j = 0; j < candidates[i].VotesCount.Length; j++)
                {
                    sb.Append(string.Concat(candidates[i].VotesCount[j],"\t"));
                }
                sb.AppendLine(string.Format("Total Votos: {0}", Checks.Verifiers.CountVotes(candidates[i].VotesCount)));
            }
            return sb.ToString();            
        }

    }
}
