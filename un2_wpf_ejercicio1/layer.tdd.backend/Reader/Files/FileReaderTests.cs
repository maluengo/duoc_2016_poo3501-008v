using System.Linq;
using layer.backend.fakeRepository.Contracts;
using layer.backend.fakeRepository.Reader.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace layer.backend.fakeRepository.Reader.Files.Tests
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void GetFilteredCollectionTest()
        {
            Assert.Fail();
        }
    }
}

namespace layer.tdd.backend.Reader.Files
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void GetAllFilesFromPathTest()
        {
            IFileReaderable objTest = new FileReader();

            var test1 = objTest.GetAllFilesFromPath("invalido");
            var test2 = objTest.GetAllFilesFromPath(null);
            var test3 = objTest.GetAllFilesFromPath(string.Empty);

            Assert.IsNull(test1);
            Assert.IsNull(test2);
            Assert.IsNull(test3);

            var test4 = objTest.GetAllFilesFromPath(@"D:\Dropbox\SOURCE-GitHub\poo3501\logs");





        }

        [TestMethod()]
        public void GetOnlyLogFilesTest()
        {
            IFileReaderable objTest = new FileReader();


            var test1 = objTest.GetOnlyLogFiles(@"D:\Dropbox\SOURCE-GitHub\poo3501\logs");
            var test2 = objTest.GetOnlyLogFiles(null);
            var test3 = objTest.GetOnlyLogFiles(string.Empty);

            Assert.IsNull(test2);
            Assert.IsNull(test3);
            Assert.IsTrue(test1.Count().Equals( 11));


        }
    }
}