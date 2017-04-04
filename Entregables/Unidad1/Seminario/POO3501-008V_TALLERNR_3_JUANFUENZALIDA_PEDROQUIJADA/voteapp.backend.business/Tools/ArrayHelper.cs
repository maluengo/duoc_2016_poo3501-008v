﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voteapp.backend.business.Tools
{
    public class ArrayHelper
    {
        public int GetRowsByString(string rowsAndColumn)
        {
            int rows             = default(int);
            var validationHelper = new Validations();

            if (!string.IsNullOrEmpty(rowsAndColumn))
            {
                if (validationHelper.IsMatrixSizeOk(rowsAndColumn))
                {
                    rows = int.Parse(rowsAndColumn.Split(Convert.ToChar(","))[0]);
                }
            }

            return rows;
        }
        
        public int GetColumnByString(string rowsAndColumn)
        {
            int columns = default(int);
            var validationHelper = new Validations();

            if (!string.IsNullOrEmpty(rowsAndColumn))
            {
                if (validationHelper.IsMatrixSizeOk(rowsAndColumn))
                {
                    columns = int.Parse(rowsAndColumn.Split(Convert.ToChar(","))[1]);
                }
            }

            return columns;
        }

    }
}
