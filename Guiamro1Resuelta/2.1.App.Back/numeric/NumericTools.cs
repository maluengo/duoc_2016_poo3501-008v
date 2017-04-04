using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.App.Back.numeric
{
    public class NumericTools
    {

        public bool IsNumeric(string value)
        {
            var isOk = default(bool);

            if (!string.IsNullOrEmpty(value))
            {
                var auxInt = 0;
                isOk = int.TryParse(value, out auxInt);
            }

            return isOk;
        }
             



    }
}
