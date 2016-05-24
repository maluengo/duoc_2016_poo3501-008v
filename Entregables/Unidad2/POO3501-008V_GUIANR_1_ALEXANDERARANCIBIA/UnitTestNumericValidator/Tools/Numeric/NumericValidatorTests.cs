using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Tools.Numeric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Backend.MathCalculation.Tools.Numeric.Tests
{
    [TestClass()]
    public class NumericValidatorTests
    {
        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            var objTest = new NumericValidator();

            var test1 = "sdkljh,-sd";
            var test2 = 654;
            var test3 = string.Empty;
            var test4 = "    ";
            var test5 = "44,3";


        }
    }
}