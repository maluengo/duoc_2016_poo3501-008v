using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.ObjectCandidate;
using Backend.Opertations;

namespace Backend.Matrix
{
    public class MatrixBuild
    {
        Validations check = new Validations();   
        public CandidateMayor[] CreateCandidates(int quantityCandidates, int quantityDistrics)
        {
            CandidateMayor[] candidates = new CandidateMayor[quantityCandidates];
            for (int i = 0; i < quantityCandidates; i++)
            {
                candidates[i] = new CandidateMayor();
                candidates[i].name = string.Format("Cantidadte {0}", i + 1);
                candidates[i].VotesDistrics = new int[quantityDistrics];

            }
            return candidates;
        }
        public int [,] DistricsVotes(int x, int y)
        {
            int[,] votesForDistric = new int[x, y];
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    votesForDistric[i, j] = random.Next(1, 500);
                }
            }
            return votesForDistric;
        }
    
        
    }
}
