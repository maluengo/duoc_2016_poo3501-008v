using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using back.Layer.Checks;
using back.Layer.Builders;

namespace front.Layer
{
    class Program
    {
        static void Main(string[] args)
        {
            Verifiers verify = new Verifiers();
            BobTheBuilder builder = new BobTheBuilder();
            int opcion = default(int);
            int districts = default(int);
            int candidatesCount = default(int);
            string aux = string.Empty;
            Candidate[] candidates = default(Candidate[]);
            do
            {
                Console.WriteLine(ImprimirMenu());
                aux = Console.ReadLine();
                if (verify.checkIfNumber(aux))
                {
                    opcion = Convert.ToInt32(aux);
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese cantidad de Distritos");
                            aux = Console.ReadLine();
                            if (verify.checkIfNumber(aux))
                            {
                                if (verify.CheckDistrictsCount(Convert.ToInt32(aux)))
                                {
                                    districts = Convert.ToInt32(aux);
                                }
                                else
                                {
                                    Console.WriteLine("La cantidad de distritos debe ser entre 5 a 7.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un valor válido.");
                            }
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Ingrese cantidad de Candidatos");
                            aux = Console.ReadLine();
                            if (verify.checkIfNumber(aux))
                            {
                                if(Convert.ToInt32(aux) >= 3 && Convert.ToInt32(aux) <= 5)
                                {
                                    candidatesCount = Convert.ToInt32(aux);
                                }
                                else
                                {
                                    Console.WriteLine("La cantidad de Candidatos debe ser entre 3 a 5.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Ingrese un valor válido.");
                            }                            
                            Console.WriteLine();
                            break;

                        case 3:
                            if (districts > 0 && candidatesCount > 0)
                            {
                                candidates = builder.CandidatesBuilder(candidatesCount, districts);
                                candidates = builder.VotesMatrixBuilder(candidates);
                                Console.WriteLine("Matriz llenada exitosamente!");
                            } else
                            {
                                Console.WriteLine("La cantidad de Candidatos o la Cantidad de Distritos no han sido asignados correctamente");
                            }
                            Console.WriteLine();
                            break;

                        case 4:
                            if (candidates.Length > 0)
                            {
                                Console.WriteLine(string.Format("El candidato ganador es: {0}", verify.getWinner(candidates).Name));
                            }
                            Console.WriteLine();
                            break;

                        case 5:
                            if (candidates.Length > 0)
                            {
                                Console.WriteLine(string.Format("El candidato en segundo lugar es: {0}", verify.GetSecondPlace(candidates).Name));
                            }
                            Console.WriteLine();
                            break;

                        case 6:
                            Console.WriteLine(builder.PrintVotesMatrix(candidates));
                            break;

                        case 7:
                            Console.WriteLine("Adios!");
                            break;

                        default:
                            Console.WriteLine("Opcíón no valida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no valida.");
                }
                verify.CheckOpcion(opcion);
            } while (opcion != 7);
            Console.WriteLine("Presione una tecla para cerrar....");
            Console.ReadKey();
            
        }

        private static string ImprimirMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("//Bienvenido al Sistema de Votación");
            sb.AppendLine("---------------------------------------");
            sb.AppendLine("Ingrese una opción:");
            sb.AppendLine("1.- Ingresar cantidad de Distritos");
            sb.AppendLine("2.- Ingresar cantidad de Candidatos");
            sb.AppendLine("3.- Generar Votación");
            sb.AppendLine("4.- Obtener Ganador");
            sb.AppendLine("5.- Obtener Segundo Lugar");
            sb.AppendLine("6.- Imprimir Resultados");
            sb.AppendLine("7.- Salir");
            sb.AppendLine("---------------------------------------");
            return sb.ToString();
        }

        


    }
}
