using System;
using _2._1.App.Back.numeric;

namespace _2._2.App.Front
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al ejercicio 2. Debe de construir un menu. \n");
            PrintMenu();

        }

        static void PrintMenu()
        {
            var iWantOut = false;
            var numericHelper = new NumericTools(); //Acá reuso la librería del ejercicio 2.1.

            do
            { 
                Console.WriteLine($"Ingrese la opción del menú: \n");
                var auxOption = Console.ReadLine(); 

                Console.ReadKey();

                if (!numericHelper.IsNumeric(auxOption))
                {
                    Console.WriteLine($"Opción inválida.  La opción {auxOption} no es un tipo válido.\n");
                    Console.WriteLine("Intentelo nuevamente... Presione ENTER. \n");
                    Console.ReadKey();
                }
                else
                {
                    switch (int.Parse(auxOption))
                    {
                        case 1:
                            Console.WriteLine("Ha seleccionado la opción SUMAR. \n");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Ha seleccionado la opción RESTAR. \n");
                            Console.ReadKey();
                            break;


                        case 3:
                            Console.WriteLine("Ha seleccionado la opción MULTIPLICAR.. \n");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.WriteLine("Adios...");
                            Console.ReadKey();
                            iWantOut = true;
                            break;

                        default:
                            Console.WriteLine($"La opción {auxOption} no es reconocida dentro del menú de opciones. \n");
                            Console.WriteLine("inténtelo nuevamente... presione ENTER\n");
                            Console.ReadKey();
                            break;
                    }

                }
                

                
            } while (!iWantOut);
        }
    }
}
