using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Functions
{

    public class ArithmeticOperations
    {

        /// <summary>
        /// Se recibiran strings y se retornaran strings, se trabajaran las validaciones internamente.
        /// </summary>
        /// <param name="numFromConsole1"></param>
        /// <param name="numFromConsole2"></param>
        /// <returns></returns>
        public string Sum(string numFromConsole1, string numFromConsole2)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(numFromConsole1) && !string.IsNullOrEmpty(numFromConsole2))
            {
                if (CheckIfIsNumericValue(numFromConsole1) && CheckIfIsNumericValue(numFromConsole2))
                {
                    //Acá, una vez que sabemos que los valores son idóneos para ser usados en cálculos aritméticos.
                    //convertimos cada valor originalmente ingresado como string a valores enteros. Los sumamos...
                    //y lo re-convertimos a strings, dado que el método plantea como retorno un STRING. 
                    result = ((int.Parse(numFromConsole1)) + (int.Parse(numFromConsole2))).ToString();
                }
            }
            
            return result;

        }

        /// <summary>
        /// Se reciben dos cadenas strings, se aplicará la conversación a enteros y se restarán. 
        /// </summary>
        /// <param name="numFromConsole1"></param>
        /// <param name="numFromConsole2"></param>
        /// <returns></returns>
        public string Substraction(string numFromConsole1, string numFromConsole2)
        {
            var result = string.Empty;

            if (!string.IsNullOrEmpty(numFromConsole1) && !string.IsNullOrEmpty(numFromConsole2))
            {
                if (CheckIfIsNumericValue(numFromConsole1) && CheckIfIsNumericValue(numFromConsole2))
                {
                    //Acá, una vez que sabemos que los valores son idóneos para ser usados en cálculos aritméticos.
                    //convertimos cada valor originalmente ingresado como string a valores enteros. Los restamos...
                    //y lo re-convertimos a strings, dado que el método plantea como retorno un STRING. 
                    result = ((int.Parse(numFromConsole1)) - (int.Parse(numFromConsole2))).ToString();
                }
            }

            return result;

        }

        /// <summary>
        /// CHequea y comprueba si un número, ingresado como cadena de caracteres (string) es un valor numérico
        /// válido para ser usado en alguna operación aritmética. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckIfIsNumericValue(string num)
        {
            var isNumeric = default(bool);

            if (!string.IsNullOrEmpty(num))
            {
                var auxIntValue = 0;
                isNumeric = int.TryParse(num, out auxIntValue);
            }

            return isNumeric;
        }

    }
}
