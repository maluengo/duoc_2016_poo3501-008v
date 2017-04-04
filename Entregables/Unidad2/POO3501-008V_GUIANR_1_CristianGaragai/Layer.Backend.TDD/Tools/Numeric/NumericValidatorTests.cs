using Layer.Backend.MathCalculation.Tools.Numeric;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.TDD.Tools.Numeric
{
    [TestClass()]
    public class NumericValidatorTests
    {
        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            NumericValidator objTest = new NumericValidator();

            var test1 = "noNumerico";
            var test2 = "30";
            var test3 = default(object);
            var test4 = "   ";
            var test5 = "44.3";

            var resulTest1 = objTest.IsStringNumericConvertible(test1);
            var resulTest2 = objTest.IsStringNumericConvertible(test2);
            var resulTest3 = objTest.IsStringNumericConvertible(test3 as string);
            var resulTest4 = objTest.IsStringNumericConvertible(test4);
            var resulTest5 = objTest.IsStringNumericConvertible(test5);

            Assert.IsFalse(resulTest1);
            Assert.IsTrue(resulTest2);
            Assert.IsFalse(resulTest3);
            Assert.IsFalse(resulTest4);
            Assert.IsFalse(resulTest5);
        }
    }
}