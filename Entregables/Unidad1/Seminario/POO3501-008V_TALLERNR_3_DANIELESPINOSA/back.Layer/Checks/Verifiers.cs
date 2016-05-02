using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace back.Layer.Checks
{
    public class Verifiers
    {
        public bool checkIfNumber(string Value)
        {
            bool result = default(bool);
            int aux = default(int);
            if (!string.IsNullOrEmpty(Value))
            {
                result = int.TryParse(Value, out aux);
            }
            return result;
        }

        public Candidate getWinner(Candidate[] candidates)
        {
            Candidate Winner = new Candidate();
            if (!Candidate.Equals(candidates, DBNull.Value))
            {
                Winner.Name = candidates[0].Name;
                Winner.VotesCount = candidates[0].VotesCount;
                for (int i = 0; i < candidates.Length; i++)
                {
                    if(CountVotes(candidates[i].VotesCount)>CountVotes(Winner.VotesCount))
                    {
                        Winner.Name = candidates[i].Name;
                        Winner.VotesCount = candidates[i].VotesCount;
                    }
                }
            }
            return Winner;
        }

        public Candidate GetSecondPlace(Candidate[] candidates)
        {
            Candidate SecondPlace = new Candidate();
            if (!Candidate.Equals(candidates, DBNull.Value))
            {
                Candidate Winner = getWinner(candidates);
                SecondPlace.Name = candidates[0].Name;
                SecondPlace.VotesCount = candidates[0].VotesCount;
                for (int i = 0; i < candidates.Length; i++)
                {
                    if (CountVotes(candidates[i].VotesCount) > CountVotes(SecondPlace.VotesCount) && CountVotes(candidates[i].VotesCount) < CountVotes(Winner.VotesCount))
                    {
                        SecondPlace.Name = candidates[i].Name;
                        SecondPlace.VotesCount = candidates[i].VotesCount;
                    }
                }
            }
            return SecondPlace;
        }

        public static int CountVotes(int[] VotesPerSector)
        {
            int Votes = default(int);
            for (int i = 0; i < VotesPerSector.Length; i++)
            {
                Votes += VotesPerSector[i];
            }
            return Votes;
        }

        public string CheckOpcion(int opcion)
        {
            string message = string.Empty;
            if (opcion <= 0 || opcion > 7)
                message = string.Format("Debe ingresar una opcion válida.");
            return message;
        }

        public bool CheckDistrictsCount(int districts)
        {
            bool result = default(bool);
            if (districts >= 5 && districts <= 7)
                result = true;
            return result;
        }
    }
}