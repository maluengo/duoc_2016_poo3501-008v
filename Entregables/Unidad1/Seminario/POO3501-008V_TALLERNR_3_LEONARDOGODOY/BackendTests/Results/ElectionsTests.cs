using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Results.Tests
{
    [TestClass()]
    public class ElectionsTests
    {
        [TestMethod()]
        public void llenadoMatrixTest()
        {
            var elecciones = new Elections();
            var test1 = "gato";
            var test2 = "5";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            var resulTest1 = elecciones.llenadoMatrix(test1, test1);
            var resulTest2 = elecciones.llenadoMatrix(test2, test2);
            var resulTest3 = elecciones.llenadoMatrix(test3, test3);
            var resulTest4 = elecciones.llenadoMatrix(test4 as string, test4 as string);
            var resulTest5 = elecciones.llenadoMatrix(test5, test5);

            Assert.IsFalse(resulTest1);
            Assert.IsTrue(resulTest2);
            Assert.IsFalse(resulTest3);
            Assert.IsFalse(resulTest4);
            Assert.IsFalse(resulTest5);
        }

        [TestMethod()]
        public void WinnerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SecondPlaceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ResultadosTest()
        {
            Assert.Fail();
        }
    }
}