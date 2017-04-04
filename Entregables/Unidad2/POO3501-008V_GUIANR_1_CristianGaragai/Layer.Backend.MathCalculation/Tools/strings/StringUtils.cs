using System;
using Layer.Backend.MathCalculation.Entities.enumerators;
using Layer.Backend.MathCalculation.Tools.Numeric;

namespace Layer.Backend.MathCalculation.Tools.strings
{
    public class StringUtils
    {

        /// <summary>
        /// Obtiene, por parámetro, y a partir de una cadena con formato 'x,y', los límites
        /// superiores e inferiores para definir valores numéricos aleatorios. 
        /// </summary>
        /// <param name="valueOptions"></param>
        /// <param name="inputByComa"></param>
        /// <returns></returns>
        public int GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions valueOptions, string inputByComa)
        {
            var finalResult = 0;

            switch (valueOptions)
            {
                case EnumeratorStruct.SeparatorOptions.firstValue:
                    finalResult = GetFirstLimitValue(inputByComa);

                    break;
                case EnumeratorStruct.SeparatorOptions.lastValue:
                    finalResult = GetLastLimitValue(inputByComa);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(valueOptions), valueOptions, null);
            }

            return finalResult;
        }


        /// <summary>
        /// ATR: Obtiene el valor inferior, a partir de un string con formato: '3,94875'
        /// </summary>
        /// <param name="valuesByComa"></param>
        /// <returns></returns>
        private int GetFirstLimitValue(string valuesByComa)
        {
            var firstLimit = default(int);

            if (!string.IsNullOrEmpty(valuesByComa))
            {
                if (valuesByComa.Contains(","))
                {
                    var auxFirstValue = valuesByComa.Split(Convert.ToChar(","))[0];

                    //Valida antes si el valor, del primer dígito ante de la coma, es convertible a número.

                    if (new NumericValidator().IsStringNumericConvertible(auxFirstValue))
                    {
                        firstLimit = int.Parse(auxFirstValue);
                    }
                }
            }

            return firstLimit;
        }

        /// <summary>
        /// ATR: Obtiene el límite superior a partir de un string con formato: '2,2342'
        /// </summary>
        /// <param name="valuesByComa"></param>
        /// <returns></returns>
        private int GetLastLimitValue(string valuesByComa)
        {
            var firstLimit = default(int);

            if (!string.IsNullOrEmpty(valuesByComa))
            {
                if (valuesByComa.Contains(","))
                {
                    var auxFirstValue = valuesByComa.Split(Convert.ToChar(","))[1];

                    //Valida antes si el valor, del primer dígito ante de la coma, es convertible a número.

                    if (new NumericValidator().IsStringNumericConvertible(auxFirstValue))
                    {
                        firstLimit = int.Parse(auxFirstValue);
                    }
                }
            }

            return firstLimit;
        }
    }
}
