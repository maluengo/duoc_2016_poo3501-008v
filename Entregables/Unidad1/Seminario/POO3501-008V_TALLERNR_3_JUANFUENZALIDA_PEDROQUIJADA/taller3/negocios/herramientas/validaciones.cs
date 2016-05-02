using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios.herramientas
{
    class validaciones
    {
        /// <summary>
        /// Valida si es número o no.
        /// </summary>
        /// <param name="valueToCheck"></param>
        /// <returns>True si es número</returns>
        public bool IsNumeric(string valueToCheck)
        {
            var isOk = false;

            if (!string.IsNullOrEmpty(valueToCheck))
            {
                var auxInt = default(int);
                isOk = int.TryParse(valueToCheck, out auxInt);
            }

            return isOk;
        }

        /// <summary>
        /// Valida si se le envía el correcto formato del tamaño del arreglo, en strings.
        /// Ejemplo: tamaño de la matriz (filas x columnas) = '4,3'
        /// </summary>
        /// <param name="rowsAndColumnsDimensions"></param>
        /// <returns></returns>
        public bool IsMatrixSizeOk(string rowsAndColumnsDimensions)
        {
            var isOk = false;

            if (!string.IsNullOrEmpty(rowsAndColumnsDimensions))
            {
                if (rowsAndColumnsDimensions.Contains(","))
                {
                    var auxArrayRows = rowsAndColumnsDimensions.Split(Convert.ToChar(","))[0];
                    var auxArrayColumns = rowsAndColumnsDimensions.Split(Convert.ToChar(","))[1];

                    isOk = !string.IsNullOrEmpty(auxArrayRows) && !string.IsNullOrEmpty(auxArrayColumns) &&
                           IsNumeric(auxArrayRows) && IsNumeric(auxArrayColumns);

                }

            }


            return isOk;

        }
    }
}
