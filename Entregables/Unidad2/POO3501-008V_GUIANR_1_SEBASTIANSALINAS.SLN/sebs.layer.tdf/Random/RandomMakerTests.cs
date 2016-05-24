using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.MathCalculation.Random.Tests
{
    [TestClass()]
    public class RandomMakerTests
    {
        RandomMaker rand = new RandomMaker();
        [TestMethod()]
        public void GetRandomValuesByLimitsTest()
        {
            var test1 = "test";
            var test2 = "4";
            var test3 = default(object);
            var test4 = "    ";
            var test5 = default(string);
            var test6 = "4.1";
            var test7 = "1,2";

            var resultTest1 = rand.GetRandomValuesByLimits(test1);
            var resultTest2 = rand.GetRandomValuesByLimits(test2);
            var resultTest3 = rand.GetRandomValuesByLimits(test3 as string);
            var resultTest4 = rand.GetRandomValuesByLimits(test4);
            var resultTest5 = rand.GetRandomValuesByLimits(test5);
            var resultTest6 = rand.GetRandomValuesByLimits(test6);
            var resultTest7 = rand.GetRandomValuesByLimits(test7);

            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.IsInstanceOfType(resultTest2, typeof(int));
            Assert.IsInstanceOfType(resultTest3, typeof(int));
            Assert.IsInstanceOfType(resultTest4, typeof(int));
            Assert.IsInstanceOfType(resultTest5, typeof(int));
            Assert.IsInstanceOfType(resultTest6, typeof(int));
            Assert.IsInstanceOfType(resultTest7, typeof(int));
        }
    }
}