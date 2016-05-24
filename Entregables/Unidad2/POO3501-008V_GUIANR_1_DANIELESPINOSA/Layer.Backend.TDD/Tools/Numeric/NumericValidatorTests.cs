using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Tools.Numeric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer.Backend.MathCalculation.Tools.Numeric.Tests
{
    [TestClass()]
    public class NumericValidatorTests
    {
        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            NumericValidator nv = new NumericValidator();

            var value1 = string.Empty;
            var value2 = DBNull.Value;
            var value3 = "0";
            var value4 = "4";

            var result1 = nv.IsStringNumericConvertible(value1);
            var result2 = nv.IsStringNumericConvertible(value2.ToString());
            var result3 = nv.IsStringNumericConvertible(value3);
            var result4 = nv.IsStringNumericConvertible(value4);

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
            Assert.IsTrue(result4);
        }
    }
}