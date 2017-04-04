using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Config.Tests
{
    [TestClass()]
    public class ConfiguradorTests
    {
        [TestMethod()]
        public void GetValueByKeyFromConfigTest()
        {
            var objTest = new ConfiguradorTests();

            var test1 = "user";
            var test2 = "pass";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);
            var test6 = "3";

            var resultadoTest1 = objTest.GetValueByKeyFromConfigTest(test1);
            var resultadoTest2 = objTest.GetValueByKeyFromConfigTest(test2);
            var resultadoTest3 = objTest.GetValueByKeyFromConfigTest(test3);
            var resultadoTest4 = objTest.GetValueByKeyFromConfigTest(test4);
            var resultadoTest5 = objTest.GetValueByKeyFromConfigTest(test5);
            var resultadoTest6 = objTest.GetValueByKeyFromConfigTest(test6);

            Assert.IsTrue(resultadoTest1);
            Assert.IsTrue(resultadoTest2);
            Assert.IsFalse(resultadoTest3);
            Assert.IsFalse(resultadoTest4);
            Assert.IsFalse(resultadoTest5);
            Assert.IsFalse(resultadoTest6);
        }
    }
}