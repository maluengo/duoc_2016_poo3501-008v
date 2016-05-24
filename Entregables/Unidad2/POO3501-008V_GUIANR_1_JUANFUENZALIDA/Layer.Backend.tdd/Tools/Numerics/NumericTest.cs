using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Tools.Numeric;

namespace Layer.Backend.tdd.Tools.Numerics
{
    [TestClass()]

    public class NumericTests
    {
        NumericValidator TestClassNumeric = new NumericValidator();

        [TestMethod()]

        public void IsStringNumericConvertibleTest()
        {
            var T1 = "test";
            var T2 = "4";
            var T3 = default(object);
            var T4 = "  ";
            var T5 = "44.3";

            var ResultTest1 = TestClassNumeric.IsStringNumericConvertible(T1);
            var ResultTest2 = TestClassNumeric.IsStringNumericConvertible(T2);
            var ResultTest3 = TestClassNumeric.IsStringNumericConvertible(T3 as string);
            var ResultTest4 = TestClassNumeric.IsStringNumericConvertible(T4);
            var ResultTest5 = TestClassNumeric.IsStringNumericConvertible(T5);

            Assert.IsFalse(ResultTest1);
            Assert.IsTrue(ResultTest2);
            Assert.IsFalse(ResultTest3);
            Assert.IsFalse(ResultTest4);
            Assert.IsFalse(ResultTest5);
        }
    }
}
