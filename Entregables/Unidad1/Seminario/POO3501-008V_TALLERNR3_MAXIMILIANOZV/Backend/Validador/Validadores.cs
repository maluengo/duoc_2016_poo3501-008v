using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Backend.Validador
{
    public class Validadores
    {
        /// <summary>
        /// Verifica que el numero ingresado sea numerico con TryParseint
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool CheckNumber(string Value)
        {
            bool result = default(bool);
            int aux = default(int);
            if (!string.IsNullOrEmpty(Value))
            {
                result = int.TryParse(Value, out aux);
            }
            return result;
        }
        /// <summary>
        /// Verifica que el numero ingresado sea mayor o igual a 5 y menor o igual a 7 y que regrese
        /// True o False
        /// </summary>
        /// <param name="districts"></param>
        /// <returns></returns>
        public bool CheckDistritos(int distritos)
        {
            bool resultado = default(bool);
            if (distritos >= 5 && distritos <= 7)
                resultado = true;
            return resultado;
        }

        /// <summary>
        /// Retorna el resultado de la verificacion si cumple con que candidato sea en el rango de 3 a 7
        /// devolviendo un bool tipo true.
        /// </summary>
        /// <param name="canditados"></param>
        /// <returns></returns>
        public bool CheckCandidatos(int canditados)
        {
            bool resultado = default(bool);
            if (canditados >= 3 && canditados <= 5)
                resultado = true;
            return resultado;
        }

        /// <summary>
        /// Verifica que las opciones ingresadas sean entre 1 y 7 
        /// </summary>
        /// <param name="opcion"></param>
        /// <returns></returns>
        public string CheckOpciones(int opcion)
        {
            string message = string.Empty;
            if (opcion <= 0 || opcion > 7)
                message = string.Format("Debe ingresar una opcion válida.");
            return message;
        }

        

        /// <summary>
        /// Obtiene al ganador de los votos.
        /// ///
        /// </summary>
        /// <param name="candidatos"></param>
        /// <returns></returns>
        public Matrix.Matriz.Candidatos getWinner(Matrix.Matriz.Candidatos[] candidatos)
        {
            Matrix.Matriz.Candidatos ganador = new Matrix.Matriz.Candidatos();
            if (!Equals(candidatos, DBNull.Value))
            {
                ganador.CandidatosMatriz = candidatos[0].CandidatosMatriz;
                ganador.ContadorVotos = candidatos[0].ContadorVotos;
                for (int i = 0; i < candidatos.Length; i++)
                {
                    if (CountVotes(candidatos[i].ContadorVotos) > CountVotes(ganador.ContadorVotos))
                    {
                        ganador.CandidatosMatriz = candidatos[i].CandidatosMatriz;
                        ganador.ContadorVotos = candidatos[i].ContadorVotos;
                    }
                }
            }
            return ganador;
        }

        /// <summary>
        /// Obtiene el segundo lugar de los votos.
        /// </summary>
        /// <param name="candidatos"></param>
        /// <returns></returns>
        public Matrix.Matriz.Candidatos segundoLugar(Matrix.Matriz.Candidatos[] candidatos)
        {
            Matrix.Matriz.Candidatos segundoLugar = new Matrix.Matriz.Candidatos();
            if (!Equals(candidatos, DBNull.Value))
            {
                Matrix.Matriz.Candidatos ganador = getWinner(candidatos);
                segundoLugar.CandidatosMatriz = candidatos[0].CandidatosMatriz;
                segundoLugar.ContadorVotos = candidatos[0].ContadorVotos;
                for (int i = 0; i < candidatos.Length; i++)
                {
                    if (CountVotes(candidatos[i].ContadorVotos) > CountVotes(segundoLugar.ContadorVotos) 
                     && CountVotes(candidatos[i].ContadorVotos) < CountVotes(ganador.ContadorVotos))
                    {
                        segundoLugar.CandidatosMatriz = candidatos[i].CandidatosMatriz;
                        segundoLugar.ContadorVotos = candidatos[i].ContadorVotos;
                    }
                }
            }
            return segundoLugar;
        }

        /// <summary>
        /// Contador de votos para comparar al primer y segundo lugar.
        /// </summary>
        /// <param name="VotesPerSector"></param>
        /// <returns></returns>
        public static int CountVotes(int[] VotesPerSector)
        {
            int Votes = default(int);
            for (int i = 0; i < VotesPerSector.Length; i++)
            {
                Votes += VotesPerSector[i];
            }
            return Votes;
        }
    }
}
