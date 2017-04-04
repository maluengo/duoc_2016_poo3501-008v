using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Opertations
{
    public class Validations
    {
        public bool CheckIfIsNumber(string dato)
        {
            bool isNumber = default(bool);
            int auxCheckNumber = default(int);
            if (!string.IsNullOrEmpty(dato))
            {
                isNumber = int.TryParse(dato, out auxCheckNumber);
            }
            return isNumber;
        }
        public int convertNumber(string dato)
        {
            int number = default(int);
            if (CheckIfIsNumber(dato))
            {
                number = int.Parse(dato);
            }
            return number;
        }
    }
}
