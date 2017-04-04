using System;
using System.Linq;
using atr.app.layer.backend.domain.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace atr.app.layer.backend.TDD.Source
{
    [TestClass()]
    public class DataLoaderTests
    {
        [TestMethod()]
        public void LoadAllDataTest()
        {
            var objTest = new DataLoader();

            Assert.IsNull(objTest.LoadAllData("pathinvalido"));
            Assert.IsNull(objTest.LoadAllData(""));
            Assert.IsNull(objTest.LoadAllData(string.Empty));
            Assert.IsNull(objTest.LoadAllData(default(string)));
            Assert.IsNull(objTest.LoadAllData(null));

            Assert.IsNotNull(objTest.LoadAllData(@"D:\Dropbox\SOURCE-GitHub\poo3501\logs"));
            Assert.IsTrue(objTest.LoadAllData(@"D:\Dropbox\SOURCE-GitHub\poo3501\logs").Any());

        }
    }
}