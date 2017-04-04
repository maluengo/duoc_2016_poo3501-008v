using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Entities.enumerators;

namespace Layer.Backend.MathCalculation.Tools.strings.Tests
{
    [TestClass()]
    public class StringUtilsTests
    {
        [TestMethod()]
        public void GetFirstOrLastValueTest()
        {
            var stringUtils = new StringUtils();
            var Enumerator = new EnumeratorStruct.SeparatorOptions();

            var test1 = default(object);
            var test2 = "a,b";
            var test3 = "2,c";
            var test4 = " , ";
            var test5 = "4,123132";

            var resulTest1 = stringUtils.GetFirstOrLastValue(Enumerator,test1 as string);
            var resulTest2 = stringUtils.GetFirstOrLastValue(Enumerator,test2);
            var resulTest3 = stringUtils.GetFirstOrLastValue(Enumerator, test3);
            var resulTest4 = stringUtils.GetFirstOrLastValue(Enumerator, test4);
            var resulTest5 = stringUtils.GetFirstOrLastValue(Enumerator, test5);

            Assert.AreEqual(0,resulTest1);
            Assert.AreEqual(0,resulTest2);
            Assert.AreEqual(2,resulTest3);
            Assert.AreEqual(0,resulTest4);
            Assert.AreEqual(4,resulTest5);

            var resulTest6 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, test1 as string);
            var resulTest7 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, test2);
            var resulTest8 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.lastValue, test2);
            var resulTest9 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.lastValue, test3);
            var resulTest10 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, test3);
            var resulTest11 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, test4);
            var resulTest12 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.lastValue, test4);
            var resulTest13 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.firstValue, test5);
            var resulTest14 = stringUtils.GetFirstOrLastValue(EnumeratorStruct.SeparatorOptions.lastValue, test5);

            Assert.AreEqual(0, resulTest6);
            Assert.AreEqual(0, resulTest7);
            Assert.AreEqual(0, resulTest8);
            Assert.AreEqual(0, resulTest9);
            Assert.AreEqual(2, resulTest10);
            Assert.AreEqual(0, resulTest11);
            Assert.AreEqual(0, resulTest12);
            Assert.AreEqual(4, resulTest13);
            Assert.AreEqual(123132, resulTest14);
        }
    }
}