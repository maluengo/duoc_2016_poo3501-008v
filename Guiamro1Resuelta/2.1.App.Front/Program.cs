using System;
using _2._1.App.Back.numeric;

namespace _2._1.App.Front
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ejercicio nro 2.1");
            Console.WriteLine("\n Ingrese el valor numerico a validar: ");

            var valueFromConsole = Console.ReadLine();
            Console.ReadKey();

            if (string.IsNullOrEmpty(valueFromConsole))
            {
                Console.WriteLine("El valor esta vacío.  Error. ");
            }
            else
            {
                var numericTool = new NumericTools();

                Console.WriteLine(numericTool.IsNumeric(valueFromConsole)
                    ? $"Prefecto, el valor ingresado {valueFromConsole} pasó la validación."
                    : $"Error, el valor ingresado {valueFromConsole} no es covertible a número.");

                Console.ReadKey();

            }  


        }
    }
}
