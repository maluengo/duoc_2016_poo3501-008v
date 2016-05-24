using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.MathCalculation.Random.Tests
{
    [TestClass()]
    public class RandomMakerTests
    {
        [TestMethod()]
        public void GetRandomValuesByLimitsTest()
        {
            var RandomMaker = new RandomMaker();

            var testString = default(string);
            var testString2 = string.Empty;
            var testString3 = default(object);
            var testString4 = "4,8";
            var testString5 = "4.5";

            var resulTest = RandomMaker.GetRandomValuesByLimits(testString);
            var resulTest2 = RandomMaker.GetRandomValuesByLimits(testString2);
            var resulTest3 = RandomMaker.GetRandomValuesByLimits(testString3 as string);
            var resulTest4 = RandomMaker.GetRandomValuesByLimits(testString4);
            var resulTest5 = RandomMaker.GetRandomValuesByLimits(testString5);

            Assert.AreEqual(0, resulTest);
            Assert.AreEqual(0, resulTest2);
            Assert.AreEqual(0, resulTest3);
            Assert.AreEqual(4,8, resulTest4);
            Assert.AreEqual(0, resulTest5);

        }
    }
}