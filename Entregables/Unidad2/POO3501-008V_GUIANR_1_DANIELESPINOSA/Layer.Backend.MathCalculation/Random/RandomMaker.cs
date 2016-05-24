using Layer.Backend.MathCalculation.Entities.enumerators;
using Layer.Backend.MathCalculation.Tools.strings;

namespace Layer.Backend.MathCalculation.Random
{
    public class  RandomMaker
    {
        /// <summary>
        /// ATR - Obtiene parámetros random a través de un string, separado por comas con 
        /// el siguiente formato: '2,4554', donde el primer dígito es el límite inferior, el 
        /// segundo el superior. 
        /// </summary>
        /// <param name="limitsByComa"></param>
        /// <returns></returns>
        public int GetRandomValuesByLimits(string limitsByComa)
        {
            var finalIntRandomValue = default(int);

            if (!string.IsNullOrEmpty(limitsByComa))
            {
                var randomHelper = new System.Random();
                var stringHelper = new StringUtils();

                finalIntRandomValue =
                    randomHelper.Next(
                        stringHelper.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, limitsByComa),
                        stringHelper.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.lastValue, limitsByComa));
            }

            return finalIntRandomValue;
        }
    }
}
