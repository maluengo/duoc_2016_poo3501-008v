using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Validador;
using Backend.Matrix;




namespace LayerFrontend
{
    class Program
    {
        /// <summary>
        /// Menu principal que sera mostrado por pantalla.
        /// </summary>
        /// <returns></returns>
        public static string menuOpcion()
        {
            StringBuilder index = new StringBuilder();

            index.Append("<<Bienvenido al Sistema de Votacion>>\n");
            index.Append("---------------Menu---------------\n");
            Console.WriteLine("\n");
            index.AppendLine("1: Ingrese la cantidad de distritos \n");
            index.AppendLine("   el rango de 5 minimo y 7 maximo :\n");
            index.Append("------------------------------------ \n");
            index.AppendLine("2: Ingrese la cantidad de Candidatos \n");
            index.AppendLine("   el rango de 3 Minimo y 5 Maximo :\n");
            index.Append("------------------------------------ \n");
            index.Append("3: Generar Votos : \n");
            index.Append("------------------------------------ \n");
            index.Append("4: Obtener al Ganador por Votos : \n");
            index.Append("------------------------------------ \n");
            index.Append("5: Obtener Segundo lugar de Votos : \n");
            index.Append("------------------------------------\n");
            index.Append("6: Ver Resultados : \n");
            index.Append("------------------------------------\n");
            index.Append("7: Salir.\n");
            index.Append("------------------------------------\n");

            return index.ToString();

        }

        static void Main(string[] args)
        {
            Validadores verificar = new Validadores();
            Matriz matriz = new Matriz();
            Matriz.Candidatos[] candidatos = default(Matriz.Candidatos[]);
            int opcion = default(int);
            string aux = string.Empty;
            int distritos = default(int);
            int candidatosCount = default(int);

            do
            {
                Console.WriteLine(menuOpcion());
                aux = Console.ReadLine();
                if (verificar.CheckNumber(aux))
                {
                    opcion = Convert.ToInt32(aux);
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la cantidad de distritos");
                            aux = Console.ReadLine();
                            if (verificar.CheckNumber(aux))
                            {
                                if (verificar.CheckDistritos(Convert.ToInt32(aux)))
                                {
                                    distritos = Convert.ToInt32(aux);
                                }
                                else
                                {
                                    Console.WriteLine("El Ingreso de distritos debe ser mayor o igual a 5 y menor o igual a 7");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresa Numeros.");
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Ingresa la cantidad de candidatos");
                            aux = Console.ReadLine();
                            if (verificar.CheckNumber(aux))
                            {
                                if ((Convert.ToInt32(aux) >= 3 && (Convert.ToInt32(aux)<=5)))
                                {
                                    candidatosCount = Convert.ToInt32(aux);
                                }
                                else
                                {
                                    Console.WriteLine("El Ingreso de canditados es entre 3 y 5");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresa numeros.");
                            }
                            Console.WriteLine();
                            break;                    
                        case 3:
                            if(distritos> 0 && candidatosCount>0)
                            {
                                candidatos = matriz.CandidatosContador(candidatosCount, distritos);
                                candidatos = matriz.VotesMatrixBuilder(candidatos);
                                Console.WriteLine("Generando Votos.");
                            }                            
                            Console.WriteLine();
                    break;
                        case 4:
                            if (candidatos.Length > 0)
                            {
                                Console.WriteLine(string.Format("El ganador es {0}", verificar.getWinner(candidatos).CandidatosMatriz));
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Faltan datos para verificar el primer lugar."));
                            }
                            Console.WriteLine();
                            break;
                        case 5:
                            if ( candidatos.Length >0)
                            {
                                Console.WriteLine(string.Format("El segundo lugar es {0}", verificar.segundoLugar(candidatos).CandidatosMatriz));
                            }
                            else
                            {
                                Console.WriteLine(string.Format("Faltan datos para verificar el segundo lugar."));
                            }
                            Console.WriteLine();
                            break;
                        case 6:
                            if (candidatos.Length > 0)
                            {
                                Console.WriteLine(matriz.ResultadoVotos(candidatos));
                                
                            }
                            else {
                                Console.WriteLine("Dato Invalido, ingrese candidatos primero.");
                                }
                            break;

                    }
                    verificar.CheckOpciones(opcion);
                }

            } while (opcion != 7);
            Console.WriteLine("Presione cualquier tecla para terminar.");
            Console.ReadKey();
        }
    }
}
    