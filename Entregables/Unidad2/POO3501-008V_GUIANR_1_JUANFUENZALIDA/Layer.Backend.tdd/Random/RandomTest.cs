using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Layer.Backend.MathCalculation.Random;

namespace Layer.Backend.tdd.Random
{
    [TestClass()]

    public class RandomTests
    {
        RandomMaker TestClassRandom = new RandomMaker();

        [TestMethod()]

        public void GetRandomValuesByLimitsTest()
        {
            var T1 = "test";
            var T2 = "4";
            var T3 = default(object);
            var T4 = "    ";
            var T5 = default(string);
            var T6 = "4.1";
            var T7 = "1,2";

            var ResultTest1 = TestClassRandom.GetRandomValuesByLimits(T1);
            var ResultTest2 = TestClassRandom.GetRandomValuesByLimits(T2);
            var ResultTest3 = TestClassRandom.GetRandomValuesByLimits(T3 as string);
            var ResultTest4 = TestClassRandom.GetRandomValuesByLimits(T4);
            var ResultTest5 = TestClassRandom.GetRandomValuesByLimits(T5);
            var ResultTest6 = TestClassRandom.GetRandomValuesByLimits(T6);
            var ResultTest7 = TestClassRandom.GetRandomValuesByLimits(T7);

            Assert.IsInstanceOfType(ResultTest1, typeof(int));
            Assert.IsInstanceOfType(ResultTest2, typeof(int));
            Assert.IsInstanceOfType(ResultTest3, typeof(int));
            Assert.IsInstanceOfType(ResultTest4, typeof(int));
            Assert.IsInstanceOfType(ResultTest5, typeof(int));
            Assert.IsInstanceOfType(ResultTest6, typeof(int));
            Assert.IsInstanceOfType(ResultTest7, typeof(int));
        }
    }
}
