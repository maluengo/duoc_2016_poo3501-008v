using System;
using System.Linq;
using atr.app.layer.backend.repository.FileReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace atr.app.layer.backend.TDD.FileReader
{
    [TestClass()]
    public class LogInvestigatorTests
    {
        [TestMethod()]
        public void GetFileByPathTest()
        {
            var objTest = new LogInvestigator();

            string path1 = @"adsdadada";
            string path2 = @"D:\Dropbox";
            string path3 = @"D:\Dropbox\oathmalonoexiste";
            string path4 = @"D:\Dropbox\SOURCE-GitHub\poo3501\logs\SystemOut_16.02.12_11.08.49.log";

            var test1 = objTest.GetFileByPath(path1);
            var test2 = objTest.GetFileByPath(path2);
            var test3 = objTest.GetFileByPath(path3);
            var test4 = objTest.GetFileByPath(path4);

            Assert.IsNull(test1);
            Assert.IsNull(test2);
            Assert.IsNull(test3);
            Assert.IsNotNull(test4);

            Assert.IsFalse(string.IsNullOrEmpty(test4.FileName));
            Assert.IsTrue(string.Equals(test4.Extension, ".log", StringComparison.InvariantCulture));
        }

        [TestMethod()]
        public void GetDirectoryByPathTest()
        {
            var objTest = new LogInvestigator();

            string path1 = @"adsdadada";
            string path2 = @"D:\Dropbox";
            string path3 = @"D:\Dropbox\oathmalonoexiste";

            var test1 = objTest.GetDirectoryByPath(path1);
            var test2 = objTest.GetDirectoryByPath(path2);
            var test3 = objTest.GetDirectoryByPath(path3);

            Assert.IsNull(test1);
            Assert.IsNotNull(test2);
            Assert.IsNull(test3);
            Assert.IsTrue(test2.GetFiles().Any());
            ;
        }

        [TestMethod()]
        public void GetAllLogFilesByPathTest()
        {
            var objTest = new LogInvestigator();

            string path1 = @"adsdadada";
            string path2 = @"D:\Dropbox";
            string path3 = @"D:\Dropbox\oathmalonoexiste";
            string path4 = @"D:\Dropbox\SOURCE-GitHub\poo3501\logs";

            var test1 = objTest.GetAllLogFilesByPath(path1);
            var test2 = objTest.GetAllLogFilesByPath(path2);
            var test3 = objTest.GetAllLogFilesByPath(path3);
            var test4 = objTest.GetAllLogFilesByPath(path4);

            Assert.IsTrue(test4.Any());
            Assert.IsFalse(test2.Any());
            Assert.IsNull(test1);
            Assert.IsNull(test3);
        }
    }
}