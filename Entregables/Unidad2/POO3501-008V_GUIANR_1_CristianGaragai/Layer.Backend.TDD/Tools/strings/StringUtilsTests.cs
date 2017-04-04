using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Layer.Backend.MathCalculation.Entities.enumerators;
using Layer.Backend.MathCalculation.Tools.strings;

namespace Layer.Backend.TDD.Tools.strings
{
    [TestClass()]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void GetFirstOrLastValueTest()
        {
            StringUtils objTest = new StringUtils();

            EnumeratorStruct.SeparatorOptions test1_value1 = default(EnumeratorStruct.SeparatorOptions);
            var testFirst_value1 = EnumeratorStruct.SeparatorOptions.firstValue;
            EnumeratorStruct.SeparatorOptions testLast_value1 = EnumeratorStruct.SeparatorOptions.lastValue;

            string test1_value2 = String.Empty;
            string test2_value2 = "a,b";
            string test3_value2 = "3,a";
            string test4_value2 = " , ";
            string test5_value2 = "4,123132";

            var resultTest1 = objTest.GetFirstOrLastValue(test1_value1, test5_value2);
            var resultTest2 = objTest.GetFirstOrLastValue(testFirst_value1, test2_value2);
            var resultTest3 = objTest.GetFirstOrLastValue(testLast_value1, test3_value2);
            var resultTest4 = objTest.GetFirstOrLastValue(testFirst_value1, test4_value2);
            var resultTest5 = objTest.GetFirstOrLastValue(testFirst_value1, test5_value2);

            Assert.ReferenceEquals(resultTest1, default(int));
            Assert.ReferenceEquals(resultTest2, default(int));
            Assert.ReferenceEquals(resultTest3, default(int));
            Assert.ReferenceEquals(resultTest4, default(int));
            Assert.IsInstanceOfType(resultTest5, typeof(int));
        }
    }
}