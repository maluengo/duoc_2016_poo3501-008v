using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.MathCalculation.Tools.Numeric.Tests
{
    [TestClass()]
    public class NumericValidatorTests
    {
        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            var numericValidator = new NumericValidator();

            var test1 = "ho,la";
            var test2 = "5";
            var test3 = default(object);
            var test4 = "   ";
            var test5 = "44.3";

            var resulTest1 = numericValidator.IsStringNumericConvertible(test1);
            var resulTest2 = numericValidator.IsStringNumericConvertible(test2);
            var resulTest3 = numericValidator.IsStringNumericConvertible(test3 as string);
            var resulTest4 = numericValidator.IsStringNumericConvertible(test4);
            var resulTest5 = numericValidator.IsStringNumericConvertible(test5);

            Assert.IsFalse(resulTest1);
            Assert.IsTrue(resulTest2);
            Assert.IsFalse(resulTest3);
            Assert.IsFalse(resulTest4);
            Assert.IsFalse(resulTest5);
        }
    }
}