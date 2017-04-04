using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Tools
{
    public class ValueChecker
    {
        /// <summary>
        /// Retorna true or false si el valor ingresado, cadena de caracteres, es numérica o no. 
        /// </summary>
        /// <param name="numeric"></param>
        /// <returns></returns>
        public bool CheckIfValueIsNumeric(string numeric)
        {
            var isNumeric = false;
            var auxInt = 0;

            if (!string.IsNullOrEmpty(numeric))
            {
                isNumeric = int.TryParse(numeric, out auxInt);
            }

            return isNumeric;

        }

    }
}
