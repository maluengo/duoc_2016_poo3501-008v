using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Opertations;
using Backend.Results;

namespace Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Validations vali = new Validations();
            Elections elec = new Elections();
            int opcion = default(int);
            string candidatos = string.Empty;
            string distritos = string.Empty;
            bool opcion3 = default(bool);
            do
            {
                //Console.Clear();
                Console.WriteLine("1.-\tIngresar cantidad de candidatos");
                Console.WriteLine("2.-\tIngresar cantidad de distritos");
                Console.WriteLine("3.-\tEmpezar las elecciones");
                Console.WriteLine("4.-\tMostrar ganador");
                Console.WriteLine("5.-\tMostrar segundo lugar");
                Console.WriteLine("6.-\tSalir\n");
                string op = Console.ReadLine();
                opcion = vali.convertNumber(op);

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese cantidad de candidatos");
                        string auxCand = Console.ReadLine();
                        if (vali.convertNumber(auxCand)>=3 && vali.convertNumber(auxCand)<=5)
                        {
                            candidatos = auxCand;
                            Console.WriteLine("Ingrese una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nDebe ingresar un numero entre 3 y 5");
                            Console.WriteLine("Ingrese una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                      
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese cantidad de distritos");
                        string auxDist = Console.ReadLine();
                        if (vali.convertNumber(auxDist) >= 5 && vali.convertNumber(auxDist) <= 7)
                        {
                            distritos = auxDist;
                            Console.WriteLine("Ingrese una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("\nDebe ingresar un numero entre 5 y 7");
                            Console.WriteLine("Ingrese una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (!string.IsNullOrEmpty(candidatos) && !string.IsNullOrEmpty(distritos))
                        {
                            opcion3 = elec.llenadoMatrix(candidatos, distritos);
                            Console.WriteLine("\nElecciones realizadas con exito");
                            elec.Resultados();
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar los puntos 1 y 2 antes de comenzar las elecciones");
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        if (!string.IsNullOrEmpty(candidatos) && !string.IsNullOrEmpty(distritos) && opcion3)
                        {
                            Console.WriteLine($"El ganador es el candidato numero {elec.Winner() + 1}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Debe pasar los puntos 1, 2 y 3 antes de acceder a esta opcion ");
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 5:
                        if (!string.IsNullOrEmpty(candidatos) && !string.IsNullOrEmpty(distritos) && opcion3)
                        {
                            Console.WriteLine($"El segundo lugar es el candidato numero {elec.SecondPlace() + 1}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Debe pasar los puntos 1, 2 y 3 antes de acceder a esta opcion ");
                            Console.WriteLine("Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
            } while (opcion != 6);

        }
    }
}
