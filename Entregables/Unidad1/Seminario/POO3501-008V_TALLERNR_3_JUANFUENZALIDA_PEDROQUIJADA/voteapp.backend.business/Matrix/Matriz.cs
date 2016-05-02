using System;
using System.Text;

namespace voteapp.backend.business.Matrix
{
    public class Matriz
    {
        public void MakeStringMatrixByParameter(int[,] inputMatrix)
        {
            if (!inputMatrix.Length.Equals(0))
            {
              
                int rowLength = inputMatrix.GetLength(0);
                int colLength = inputMatrix.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {  
                        Console.Write($"{inputMatrix[i, j]} ");
                    }

                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

                Console.ReadLine();
            }

        }

        public int GetMaxVoteFromArray(int [,] inputMatrix)
        {
            var maxValue = default(int);

            if (!inputMatrix.Length.Equals(0))
            {
                int rowLength = inputMatrix.GetLength(0);
                int colLength = inputMatrix.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        var auxMaxValue = inputMatrix[i, j];

                        if (auxMaxValue > maxValue)
                        {
                            maxValue = auxMaxValue;
                        }
                                                   
                    }
                          
                }

            }

            return maxValue;   
        }

        public int GetSecondPlaceInVotes(int[,] inputMatrix)
        {
            var secondPlace = 0;

            if (!inputMatrix.Length.Equals(0))
            {
                var maxValue = GetMaxVoteFromArray(inputMatrix);
                int rowLength = inputMatrix.GetLength(0);
                int colLength = inputMatrix.GetLength(1);

                if (!maxValue.Equals(0))
                {
                    for (int i = 0; i < rowLength; i++)
                    {
                        for (int j = 0; j < colLength; j++)
                        {
                            var auxMaxValue = inputMatrix[i, j];

                            if (auxMaxValue > secondPlace)
                            {
                                if (!auxMaxValue.Equals(maxValue))
                                {
                                    secondPlace = auxMaxValue;
                                }
                            }

                        }

                    }

                }   
            }

            return secondPlace;
        }

        public string[,] MakeStringArrayWithTitles(int[,] inputMatrix)
        {
            var tempArray = default(string[,]);

            if (!inputMatrix.Length.Equals(0))
            {
                int rowLength = inputMatrix.GetLength(0)+1;
                int colLength = inputMatrix.GetLength(1)+1;
                tempArray     = new string[rowLength, colLength];

                for (var c = 0; c < colLength; c++)
                {  
                    for (var f = 0; f < rowLength; f++)
                    {
                        if (f.Equals(0) && (c+1)<= colLength-1)
                        {
                            tempArray[0, c+1] = $"distrito numero {c+1}"; 
                        }

                        if (c.Equals(0) && (f+1) <= rowLength-1)
                        {
                            tempArray[f+1, 0] = $"candidato numero {f+1}";
                        }
                          
                    }

                } 
            }

            return tempArray;

        }
    }
}
