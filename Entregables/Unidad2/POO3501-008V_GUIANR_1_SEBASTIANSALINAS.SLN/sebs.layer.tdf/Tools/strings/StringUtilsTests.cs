using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Entities.enumerators;

namespace Layer.Backend.MathCalculation.Tools.strings.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        StringUtils testString = new StringUtils();
        [TestMethod()]
        public void GetFirstOrLastValueTest()
        {
            var testFirstValues = EnumeratorStruct.SeparatorOptions.firstValue;
            var testLastValues = EnumeratorStruct.SeparatorOptions.lastValue;

            var test1 = default(EnumeratorStruct.SeparatorOptions);
            var test2 = ("x,z");
            var test3 = ("1,v");
            var test4 = (" , ");
            var test5 = ("4,123132");

            var resultTest1 = testString.GetFirstOrLastValue(test1, test5);
            var resultTest2 = testString.GetFirstOrLastValue(testFirstValues, test2);
            var resultTest3 = testString.GetFirstOrLastValue(testLastValues, test3);
            var resultTest4 = testString.GetFirstOrLastValue(testFirstValues, test4);
            var resultTest5 = testString.GetFirstOrLastValue(testFirstValues, test5);

            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.AreEqual(resultTest2, default(int));
            Assert.AreEqual(resultTest3, default(int));
            Assert.AreEqual(resultTest4, default(int));
            Assert.IsInstanceOfType(resultTest5,typeof(int));
        }
    }
}