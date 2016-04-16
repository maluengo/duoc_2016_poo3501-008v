using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Backend.MathCalculation.Tools.Numeric
{
    public class NumericValidator
    {
        /// <summary>
        /// ATR: Valida, mediante un boolean, si el número es efectivamente convertible a INT DE 32 bits. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsStringNumericConvertible(string value)
        {
            var isOk = false;

            if (!string.IsNullOrEmpty(value))
            {
                var auxIntParse = default(int);
                isOk = int.TryParse(value, out auxIntParse);

            }

            return isOk;
        }
    }
}
