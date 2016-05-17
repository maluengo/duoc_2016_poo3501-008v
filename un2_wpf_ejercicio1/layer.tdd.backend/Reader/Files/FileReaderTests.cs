using layer.backend.fakeRepository.Contracts;
using layer.backend.fakeRepository.Reader.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.Fail();
        }
    }
}