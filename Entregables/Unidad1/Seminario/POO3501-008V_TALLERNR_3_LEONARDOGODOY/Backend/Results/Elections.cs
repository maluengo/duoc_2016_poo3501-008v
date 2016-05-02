using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Matrix;
using Backend.Opertations;
using Backend.ObjectCandidate;

namespace Backend.Results
{
    public class Elections
    {
        Validations vali = new Validations();
        MatrixBuild matrix = new MatrixBuild();
        CandidateMayor[] AuxMatrix; 
        public bool llenadoMatrix(string imputCanditate, string imputDistrics)
        {
            bool itsOk = default(bool);
            int QuantityCandidates = vali.convertNumber(imputCanditate);
            int QuantityDistrics = vali.convertNumber(imputDistrics);
            if (QuantityCandidates!=0&&QuantityDistrics!=0)
            {
                AuxMatrix = matrix.CreateCandidates(QuantityCandidates, QuantityDistrics);
                for (int i = 0; i < QuantityCandidates; i++)
                {
                    for (int j = 0; j < QuantityDistrics; j++)
                    {
                        AuxMatrix[i].VotesDistrics[j] = matrix.DistricsVotes(QuantityCandidates, QuantityDistrics)[i, j];
                    }
                }
                itsOk = true;
            }
            return itsOk;
        }

        int VotesCount(int numberCandidate)
        {
            int votesCount = default(int);
            for (int i = 0; i < AuxMatrix[0].VotesDistrics.Length; i++)
            {
                votesCount +=  AuxMatrix[numberCandidate].VotesDistrics[i];
            }

            return votesCount;
        }
        public int Winner()
        {
            int posicion = default(int);
            int votosGanador = VotesCount(0);
            for (int i = 0; i < AuxMatrix.Length; i++)
            {
                for (int j = 0; j < AuxMatrix.Length; j++)
                {
                    if (votosGanador < VotesCount(j))
                    {
                        votosGanador = VotesCount(j);
                        posicion = j;
                    }
                }
            }
            return posicion;
        }
        public int SecondPlace()
        {
            int winner = VotesCount(Winner());
            int votesSecondPlace = VotesCount(0);
            int secondPlace = default(int);

            for (int i = 0; i < AuxMatrix.Length; i++)
            {
                for (int j = 0; j < AuxMatrix.Length; j++)
                {
                    if (votesSecondPlace < VotesCount(j))
                    {
                        if (VotesCount(j) !=winner)
                        {
                            votesSecondPlace = VotesCount(j);
                            secondPlace = j;
                        }
                    }
                }
            }
            return secondPlace;

        }
        public void Resultados()
        {
            for (int i = 0; i < AuxMatrix.Length; i++)
            {
                for (int j = 0; j < AuxMatrix[0].VotesDistrics.Length; j++)
                {
                    if (i==0 && j==0)
                    {
                        Console.Write($"Candidato 0{i+1}\t{AuxMatrix[i].VotesDistrics[j]}\t");
                    }
                    Console.Write($"{AuxMatrix[i].VotesDistrics[j]}\t");
                }
                Console.WriteLine();
            }
        }

    }
}
