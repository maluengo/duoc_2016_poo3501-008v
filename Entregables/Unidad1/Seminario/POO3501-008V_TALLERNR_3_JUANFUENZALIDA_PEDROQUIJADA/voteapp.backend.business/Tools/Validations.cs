using System;
using voteapp.backend.entities.Enums;

namespace voteapp.backend.business.Tools
{
    public class  Validations
    {
        
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
