using Layer.Backend.MathCalculation.Entities.enumerators;
using Layer.Backend.MathCalculation.Tools.Numeric;
using Layer.Backend.MathCalculation.Tools.strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ValidationTest
{
    [TestClass]
    public class ValidationTest1
    {
                

        [TestMethod]
        public void GetFirstOrLastValueTest()
        {
            StringUtils objToTest = new StringUtils();

            EnumeratorStruct.SeparatorOptions value1 = default(EnumeratorStruct.SeparatorOptions);

            var value2 = EnumeratorStruct.SeparatorOptions.firstValue;

            EnumeratorStruct.SeparatorOptions value3 = EnumeratorStruct.SeparatorOptions.lastValue;

            string testv1 = System.String.Empty;
            string testv2 = "a,b";
            string testv3 = "3,a";
            string testv4 = " , ";
            string testv5 = "4,123132";

            var test2121 = objToTest.GetFirstOrLastValue(value1, testv1);
            var test2122 = objToTest.GetFirstOrLastValue(value2, testv2);
            var test2123 = objToTest.GetFirstOrLastValue(value3, testv3);
            var test2124 = objToTest.GetFirstOrLastValue(value2, testv4);
            var test2125 = objToTest.GetFirstOrLastValue(value2, testv5);

            Assert.ReferenceEquals(test2121, default(int));
            Assert.ReferenceEquals(test2122, default(int));
            Assert.ReferenceEquals(test2123, default(int));
            Assert.ReferenceEquals(test2124, default(int));
            Assert.IsInstanceOfType(test2125, typeof(int));
            
        }

        [TestMethod()]
        public void IsStringNumericConvertibleTest()
        {
            NumericValidator objTest = new NumericValidator();

            var test1 = "noNumerico";
            var test2 = "30";
            var test3 = default(object);
            var test4 = "   ";
            var test5 = "44.3";

            var test2131 = objTest.IsStringNumericConvertible(test1);
            var test2132 = objTest.IsStringNumericConvertible(test2);
            var test2133 = objTest.IsStringNumericConvertible(test3 as string);
            var test2134 = objTest.IsStringNumericConvertible(test4);
            var test2135 = objTest.IsStringNumericConvertible(test5);

            Assert.IsFalse(test2131);
            Assert.IsTrue(test2132);
            Assert.IsFalse(test2133);
            Assert.IsFalse(test2134);
            Assert.IsFalse(test2135);
        }

    }
}
