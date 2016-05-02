using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagert
{
    public class GenerationData
    {
        Random ramdom = new Random();
        public int[,] matriz ;
        public int topCandidato = default(int);
        public int topCandidato2 = default(int);
        public int sumMaxVote=default(int);
        public int secondMaxvote= default(int);

        // genera la matris y la llena de nuemeros al azar de 100 a 1000
        public Array GetMatrizData(int columnas, int filas)
        {
            CreateMatriz(columnas, filas);

            for (int c = 0; c < columnas; c++)
            {
               for (int f = 0; f < filas; f++)
              {
                   matriz[c, f] = ramdom.Next(100, 1000);

               }
            }

            return matriz;
        }
        //crea el tamaño que se usara en la matris
        public void CreateMatriz(int columnas, int filas)
        {
           matriz=new int[columnas,filas];
        }
        // imprime la matris 
        public string PrintMatriz(int columnas, int filas)
        {
           StringBuilder text = new StringBuilder();
            for (int c = 0; c < columnas; c++)
            {
                for (int f = 0; f < filas; f++)
                {
                    text.Append(matriz[c, f] + "-");
                }
                text.Append("\n");
            }
            string returnString = text.ToString();
            return returnString;
         }    
        //calcula la suma de las filas en la matris
        public int MaxValueVote(int columnas, int filas)
        {
            int[] arrMaxVote = new int[columnas];
            int MaxVote = default(int);
            for (int c = 0; c < columnas; c++)
            {
                for (int f = 0; f < filas; f++)
                {
                    arrMaxVote[c] = arrMaxVote[c] + matriz[c, f];
                }

            }

            MaxVote = GetTop(arrMaxVote, MaxVote);
            sumMaxVote = MaxVote;
            secondMaxvote = SecondTop(secondMaxvote, arrMaxVote);

            return MaxVote;
        }
        //entrega el valor maximo de la suma de la matris y el candidato con mas votos
        private int GetTop(int[] arrMaxVote, int MaxVote)
        {
            for (int i = 0; i==arrMaxVote.Length; i++)
            {
                if (arrMaxVote[i] > MaxVote)
                {
                    MaxVote = arrMaxVote[i];
                    topCandidato = i;
                }
            }

            return MaxVote;
        }
        //entrega el segundo valor de la suma de la matris y el segundo candidato con mas votos
        private int SecondTop(int secondMaxvote, int[] arrMaxVote)
        {
            for (int i = 0; i < arrMaxVote.Length; i++)
            {
                if (arrMaxVote[i] < secondMaxvote && arrMaxVote[i]< sumMaxVote)
                {
                    secondMaxvote = arrMaxVote[i ];
                    topCandidato2 = i;
                }
               
            }
  
            return secondMaxvote;
        }
    }


    }

