using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Operations
{
    public class CountVotes
    {    
        public int recivirDistritos(string distritos)
        {
            var countDistritos = default(int);

            if(!string.IsNullOrEmpty(distritos))
                countDistritos = Convert.ToInt32(distritos);

            return countDistritos;
        }

        public int recivirCandidatos(string candidatos)
        {
            var countCandidatos = default(int);

            if (!string.IsNullOrEmpty(candidatos))
                countCandidatos = Convert.ToInt32(candidatos);

            return countCandidatos;
        }

        public int[,] countVotos(int candidatos, int distritos)
        {
            Random random = new Random();
            int voto = default(int);
            int[,] matriz = new int[candidatos,distritos];
            for (int i = 0; i < candidatos; i++)
            {
                for (int j = 0; j < distritos; j++)
                {
                    voto = random.Next(1,5000);
                    matriz[i , j] = voto;
                }
            }
            return matriz;
        }
    }
    
}
