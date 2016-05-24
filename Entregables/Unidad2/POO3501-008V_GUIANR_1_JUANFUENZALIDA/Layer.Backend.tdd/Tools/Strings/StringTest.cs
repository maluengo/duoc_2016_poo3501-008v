using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Entities.enumerators;
using Layer.Backend.MathCalculation.Tools.strings;

namespace Layer.Backend.tdd.Tools.Strings
{
    [TestClass()]

    public class StringTests
    {
        StringUtils TestClassString = new StringUtils();

        [TestMethod()]

        public void GetFirstOrLastValueTest()
        {
            var testFirstValues = EnumeratorStruct.SeparatorOptions.firstValue;
            var testLastValues = EnumeratorStruct.SeparatorOptions.lastValue;

            var T1 = default(EnumeratorStruct.SeparatorOptions);
            var T2 = ("x,z");
            var T3 = ("1,v");
            var T4 = (" , ");
            var T5 = ("4,123132");

            var ResultTest1 = TestClassString.GetFirstOrLastValue(T1, T5);
            var ResultTest2 = TestClassString.GetFirstOrLastValue(testFirstValues, T2);
            var ResultTest3 = TestClassString.GetFirstOrLastValue(testLastValues, T3);
            var ResultTest4 = TestClassString.GetFirstOrLastValue(testFirstValues, T4);
            var ResultTest5 = TestClassString.GetFirstOrLastValue(testFirstValues, T5);

            Assert.IsInstanceOfType(ResultTest1, typeof(int));
            Assert.AreEqual(ResultTest2, default(int));
            Assert.AreEqual(ResultTest3, default(int));
            Assert.AreEqual(ResultTest4, default(int));
            Assert.IsInstanceOfType(ResultTest5, typeof(int));
        }
    }
}
