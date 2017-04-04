using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Tools.strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Layer.Backend.MathCalculation.Entities.enumerators;

namespace Layer.Backend.MathCalculation.Tools.strings.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void GetFirstOrLastValueTest()
        {
            StringUtils su = new StringUtils();

            var value1 = DBNull.Value;
            var value2 = string.Empty;
            var value3 = "0";
            var value4 = "2,1";
            var value5 = "0,1";

            var result1 = su.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, value1.ToString());
            var result2 = su.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, value2);
            var result3 = su.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, value3);
            var result4 = su.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, value4);
            var result5 = su.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, value5);

            Assert.AreEqual(default(int), result1);
            Assert.AreEqual(default(int), result2);
            Assert.AreEqual(default(int), result3);
            Assert.AreNotEqual(default(int), result4);
            Assert.AreEqual(default(int), result5);
        }
    }
}