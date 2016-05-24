using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Random;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Layer.Backend.MathCalculation.Random.Tests
{
    [TestClass()]
    public class RandomMakerTests
    {
        [TestMethod()]
        public void GetRandomValuesByLimitsTest()
        {
            RandomMaker rm = new RandomMaker();

            var value1 = string.Empty;
            var value2 = DBNull.Value;
            var value3 = "0";
            var value4 = "5";
            var value5 = "1,10";

            var result1 = rm.GetRandomValuesByLimits(value1);
            var result2 = rm.GetRandomValuesByLimits(value2.ToString());
            var result3 = rm.GetRandomValuesByLimits(value3);
            var result4 = rm.GetRandomValuesByLimits(value4);
            var result5 = rm.GetRandomValuesByLimits(value5);

            Assert.AreEqual(default(int), result1);
            Assert.AreEqual(default(int), result2);
            Assert.AreEqual(default(int), result3);
            Assert.AreEqual(default(int), result4);
            Assert.AreNotEqual(default(int), result5);
        }
    }
}