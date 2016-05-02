using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagert
{
     public class Validation
    {
        // valida que un parametro ingresado se Numerico 
        public bool IsNumeric(string inputData)
        {
            bool istrue = false;
            var number = default(int);
            if (!string.IsNullOrEmpty(inputData))
            {
                if (int.TryParse(inputData, out number))
                {
                    istrue = true;
                }   
            }
            return istrue;
        }
        // valida que un parametro de tipo Numero este dentro de un rago
        public bool RangeNumber(int value,int min,int max)
        {
            bool istrue = false;
            if (value>=min && value<=max)
            {
                istrue = true;

            }

            return istrue;
        }


    }
}
