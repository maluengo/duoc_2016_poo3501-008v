using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customArray = default(int[,]);

                Random random = new Random();
                int minimo = 1;
                int maximo = 123456;
                int number = random.Next(minimo, maximo);



                int[,] matriz = new int[6, 6];
                for (var fila = 0; fila < 6; fila++)
                {
                    for (var columna = 0; columna < 6; columna++)
                    {
                    matriz[fila, columna] = random.Next();
                    Console.WriteLine(random.Next(number));
                    Console.ReadKey();
                    }


                }
            }
        }
    }
