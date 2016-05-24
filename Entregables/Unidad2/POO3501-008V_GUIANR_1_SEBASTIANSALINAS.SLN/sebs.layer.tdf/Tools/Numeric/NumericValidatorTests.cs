using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.MathCalculation.Tools.Numeric.Tests
{
    [TestClass()]
    public class NumericValidatorTests
    {
        NumericValidator num = new NumericValidator();

        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            var test1 = "test";
            var test2 = "4";
            var test3 = default(object);
            var test4 = "  ";
            var test5 = "44.3";
            
            var resultTest1 = num.IsStringNumericConvertible(test1);
            var resultTest2 = num.IsStringNumericConvertible(test2);
            var resultTest3 = num.IsStringNumericConvertible(test3 as string);
            var resultTest4 = num.IsStringNumericConvertible(test4);
            var resultTest5 = num.IsStringNumericConvertible(test5);

            Assert.IsFalse(resultTest1);
            Assert.IsTrue(resultTest2);
            Assert.IsFalse(resultTest3);
            Assert.IsFalse(resultTest4);
            Assert.IsFalse(resultTest5);
        }
    }
}