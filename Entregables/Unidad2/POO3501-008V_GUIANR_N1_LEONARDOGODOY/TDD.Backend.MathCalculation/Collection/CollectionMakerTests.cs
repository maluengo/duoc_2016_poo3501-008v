using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layer.Backend.MathCalculation.Collection.Tests
{
    [TestClass()]
    public class CollectionMakerTests
    {
        [TestMethod()]
        public void GetRandomCollectionByParameterTest()
        {
            var CollectionMaker = new CollectionMaker();

            var testNum1 = default(int);
            var testNum2 = 5;
            var testString = default(string);
            var testString2 = string.Empty;
            var testString3 = default(object);
            var testString4 = "4,8";

            var resulTest1 = CollectionMaker.GetRandomCollectionByParameter(testNum1,testString);
            var resulTest2 = CollectionMaker.GetRandomCollectionByParameter(testNum1, testString2);
            var resulTest3 = CollectionMaker.GetRandomCollectionByParameter(testNum1, testString3 as string);
            var resulTest4 = CollectionMaker.GetRandomCollectionByParameter(testNum1, testString4);
            var resulTest5 = CollectionMaker.GetRandomCollectionByParameter(testNum2, testString);
            var resulTest6 = CollectionMaker.GetRandomCollectionByParameter(testNum2, testString2);
            var resulTest7 = CollectionMaker.GetRandomCollectionByParameter(testNum2, testString3 as string);
            var resulTest8 = CollectionMaker.GetRandomCollectionByParameter(testNum2, testString4);

            Assert.IsNull(resulTest1);
            Assert.IsNull(resulTest2);
            Assert.IsNull(resulTest3);
            Assert.IsNull(resulTest4);
            Assert.IsNull(resulTest5);
            Assert.IsNull(resulTest6);
            Assert.IsNull(resulTest7);
            Assert.IsNotNull(resulTest8);

        }
    }
}