using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using _2._3.App.Back.AppConfig;
using _2._3.App.Back.StringUtils;

namespace _2._3.App.Front
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al ejercicio 2.3 El contador de caracteres \n");
            ExecuteCounter();
        }

        static void ExecuteCounter()
        {
            var configReader  = new AppConfigReader();
            var counterHelper = default(StringCounter);

            var parameter = configReader.GetValueFromKey("parameter");

            Console.WriteLine($"El parámetro a ser buscado en el STRING es {parameter}");
            Console.WriteLine("\nIngrese el String...: ");

            var stringFromConsole = Console.ReadLine();
            Console.ReadKey();

            var isValueOk = false;

            do
            {
                if (string.IsNullOrEmpty(stringFromConsole))
                {
                    Console.WriteLine("\nDebe de ingresar un valor distinto de VACIO o NULL");
                }
                else
                {
                    isValueOk = true;
                    counterHelper = new StringCounter();

                    Console.WriteLine($"\nSe han encontrado {counterHelper.CounteHowManyCharsInStringMethod2(stringFromConsole, parameter).ToString()} veces en el String {stringFromConsole}");
                    Console.ReadKey();  
                }

            } while (!isValueOk); 
            
        }

    }
}
