using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataManagert;

namespace ValidationTest
{
    [TestClass]
    public class ValidationTest1
    {
        Validation validation = new Validation();

        [TestMethod()]
        public void IsNumericTest()
        {
            var objtest = new Validation();

            var test1 = "perrito";
            var test2 = "4";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);
           

            var resultest1 = objtest.IsNumeric(test1);
            var resultest2 = objtest.IsNumeric(test2);
            var resultest3 = objtest.IsNumeric(test3);
            var resultest4 = objtest.IsNumeric(test4 as string);
            var resultest5 = objtest.IsNumeric(test5);
           

            Assert.IsFalse(resultest1);
            Assert.IsTrue(resultest2);
            Assert.IsFalse(resultest3);
            Assert.IsFalse(resultest4);
            Assert.IsFalse(resultest5);
            
        }

        [TestMethod ()]
        public void RangeNumberTest1()
        {
            var objtest = new Validation();

            var test1 = 1;
            var test2 = 2;
            var test3 = 3;
            var test4 = 4;
            var test5 = 5;
            var test6 = 6;
            var test7 = 7;

            var resultest1 = objtest.RangeNumber(test1, 5, 7);
            var resultest2 = objtest.RangeNumber(test2, 5, 7);
            var resultest3 = objtest.RangeNumber(test3, 5, 7);
            var resultest4 = objtest.RangeNumber(test4, 5, 7);
            var resultest5 = objtest.RangeNumber(test5, 5, 7);
            var resultest6 = objtest.RangeNumber(test6, 5, 7);
            var resultest7 = objtest.RangeNumber(test7, 5, 7);

            Assert.IsFalse(resultest1);
            Assert.IsFalse(resultest2);
            Assert.IsFalse(resultest3);
            Assert.IsFalse(resultest4);
            Assert.IsTrue(resultest5);
            Assert.IsTrue(resultest6);
            Assert.IsTrue(resultest7);



        }
        [TestMethod()]
        public void RangeNumberTest2()
        {
            var objtest = new Validation();


            var test1 = 1;
            var test2 = 2;
            var test3 = 3;
            var test4 = 4;
            var test5 = 5;
            var test6 = 6;
            var test7 = 7;

            var resultest1 = objtest.RangeNumber(test1, 3, 5);
            var resultest2 = objtest.RangeNumber(test2, 3, 5);
            var resultest3 = objtest.RangeNumber(test3, 3, 5);
            var resultest4 = objtest.RangeNumber(test4, 3, 5);
            var resultest5 = objtest.RangeNumber(test5, 3, 5);
            var resultest6 = objtest.RangeNumber(test6, 3, 5);
            var resultest7 = objtest.RangeNumber(test7, 3, 5);

            Assert.IsFalse(resultest1);
            Assert.IsFalse(resultest2);
            Assert.IsTrue(resultest3);
            Assert.IsTrue(resultest4);
            Assert.IsTrue(resultest5);
            Assert.IsTrue(resultest6);
            Assert.IsFalse(resultest7);


        }
    }
}
