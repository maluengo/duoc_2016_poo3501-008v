using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios.votos
{
    class autovotos
    {
        public int[,] GenerateRandomIntVotes(string rowsAndColumn)
        {
            var customArray = default(int[,]);

            if (!string.IsNullOrEmpty(rowsAndColumn))
            {
                var auxRandom = new Random();
                var validationHelper = new Validations();
                int min = 1;
                int max = 1232145;

                if (validationHelper.IsMatrixSizeOk(rowsAndColumn))
                {
                    var arrayHelper = new ArrayHelper();
                    var fixedColumn = arrayHelper.GetColumnByString(rowsAndColumn);
                    var fixedRows = arrayHelper.GetRowsByString(rowsAndColumn);

                    customArray = new int[fixedRows, fixedColumn];

                    for (var c = 0; c < fixedColumn; c++)
                    {

                        for (var i = 0; i < fixedRows; i++)
                        {
                            customArray[i, c] = auxRandom.Next(min, max);
                        }

                    }
                }

            }
            return customArray;
        }
    }
}
