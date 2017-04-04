using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Backend.Matrix
{
    public class Matriz
    {

        public class Candidatos
        {
            public string CandidatosMatriz { get; set; }
            public int[] ContadorVotos { get; set; }
        }

        public Candidatos[] CandidatosContador(int cantidad, int distritos)
        {
            Candidatos[] candidatos = new Candidatos[cantidad];
            for (int i = 0; i<cantidad; i++)
            {
                candidatos[i] = new Candidatos();
                candidatos[i].CandidatosMatriz = string.Format("Candidato {0}",(i + 1),"\n");
                candidatos[i].ContadorVotos = new int[distritos];
            }
            return candidatos;
        }

        public Candidatos[] VotesMatrixBuilder(Candidatos[] candidatos)
        {
            Random random = new Random();
            for (int i = 0; i < candidatos.Length; i++)
            {
                for (int j = 0; j < candidatos[i].ContadorVotos.Length; j++)
                {
                    candidatos[i].ContadorVotos[j] = random.Next(1, 5010);
                }
            }
            return candidatos;
        }

        public string ResultadoVotos(Candidatos[] candidatos)
        {
            StringBuilder stringbuilder = new StringBuilder();
            for (int i = 0; i < candidatos.Length; i++)
            {
                stringbuilder.Append(string.Concat(candidatos[i].CandidatosMatriz, " \a"));
                for (int j = 0; j < candidatos[i].ContadorVotos.Length; j++)
                {
                    stringbuilder.Append(string.Concat(candidatos[i].ContadorVotos[j], " \a"));
                }
                stringbuilder.AppendLine(string.Format("Total Votos: {0} ",Validador.Validadores.CountVotes(candidatos[i].ContadorVotos)));
            }
            return stringbuilder.ToString();
        }       

    }

}
