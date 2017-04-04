using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.AppConfigManager;
using Backend.Functions;

namespace ConsoleTaller2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se inicializan las principales variables de la aplicación. 
            var userName         = string.Empty;
            var functionSelected = string.Empty;
            var finalResult  = string.Empty;

            //Genero las isntancias de mis clases de Backend, que encapsulan la logica de lectura
            //del archivo App.Confi y de las operaciones matematicas respectivamente. 
            var configReaderHelper = new AppConfigReader();

            //Se muestra el mensaje de bienvenida al usuario, obteniendo el usuario a partir del archivo App.Config. 
            userName = configReaderHelper.GetValueFromKeyInAppConfig("usuario");
            ShowUserName(userName);

            //Muestra la opcion / operación establecida en el archivo App.Config.
            functionSelected = configReaderHelper.GetValueFromKeyInAppConfig("operacion");
            ShowFunctionsMessage(functionSelected);

            //Se llama a la funcion que encapsula la lógica de ingresar los números por pantalla y desplegar resultado. 
            finalResult = PlayArithmeticFunctions(functionSelected);

            Console.WriteLine($"El resultado de la operacion es: {finalResult}");
            Console.ReadKey();     

        }

        /// <summary>
        /// Método que encapsula la lógica de desplegar el mensaje de bienvenida al usuario, por pantalla. 
        /// </summary>
        /// <param name="userName"></param>
        static void ShowUserName(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                //Acá, en vez de usar string.format, estoy usando un nuevo feature de la última versión dle lenguaje
                //llamado String Interpolation (pueden usar string.format si así lo desean). 
                Console.WriteLine($"Bienvenido al taller nro 1 alumno: {userName}");
            }
            
        }

        /// <summary>
        /// Método que encapsula la lógica de mostrar las opciones válidas disponibles para ejecutar (Suma o resta según corresponda). 
        /// </summary>
        static void ShowFunctionsMessage(string functionSelected)
        {
            if (!string.IsNullOrEmpty(functionSelected))
            {
                Console.WriteLine($"La opcion disponible es: {functionSelected}");
            }

            
        }

        static string PlayArithmeticFunctions(string functionSelected)
        {
            //Se incializan las variables y el objeto instanciado de la clase ArithmeticOperations, para poder usar sus opciones
            //de validacion de operaciones aritméticas y ejecutarlas propiamente tal. 
            var operationHelper = new ArithmeticOperations();
            var valorNro1       = string.Empty;
            var valorNro2       = string.Empty;
            var isNumeric       = false;
            var result          = string.Empty;



            //Comprobamos si el valor ingresado para el primer número es numérico, de lo contrario, se le pedirá 
            //un valor válido hasta que el usuario lo ingrese.
            do
            {
                Console.WriteLine($"Ingrese el valor nro 1, presione una tecla para continuar: ");
                //Acá, estamos leyendo lo que el usuario ingresó por pantalla. 
                valorNro1 = Console.ReadLine();
                Console.ReadKey();

                //Acá, validamos si es numérico el valor o no.  Si no es numérico, se le pedirá ingresar nuevamente el valor. 
                isNumeric = operationHelper.CheckIfIsNumericValue(valorNro1);

                //Si el booleano IsNumeric sigue siendo falso, quiere decir que el usuario ingresó un valor por pantalla
                //no convertible a número, en consecuencia, se 'limpia' la variable.
                if (!isNumeric)
                {
                    Console.WriteLine("\nel valor ingresado no es un valor numérico válido. Presiona una tecla para intentarlo nuevamente");
                    valorNro1 = string.Empty;
                    Console.ReadKey();
                }

            } while (!isNumeric);

            isNumeric = false;

            do
            {
                Console.WriteLine($"Ingrese el valor nro 2, presione una tecla para continuar: ");
                valorNro2 = Console.ReadLine();
                Console.ReadKey();

                //Acá, validamos si es numérico el valor o no.  Si no es numérico, se le pedirá ingresar nuevamente el valor. 
                isNumeric = operationHelper.CheckIfIsNumericValue(valorNro2);

                if (!isNumeric)
                {
                    Console.WriteLine("\nel valor ingresado no es un valor numérico válido. Presiona una tecla para intentarlo nuevamente");
                    valorNro2 = string.Empty;
                    Console.ReadKey();
                }

            } while (!isNumeric);
            

            //En este punto, ya sabemos que los valores ingresados por pantalla son numericos.
            //Solo resta mostrar el resultado ;)

            if (!string.IsNullOrEmpty(functionSelected))
            {
                if (string.Equals(functionSelected, "Suma"))
                {
                    result = operationHelper.Sum(valorNro1, valorNro2);
                }
                else
                {
                    if (string.Equals(functionSelected, "Resta"))
                    {
                        result = operationHelper.Substraction(valorNro1, valorNro2);
                    }
                }
            }

            return result;

        }

    }
}
