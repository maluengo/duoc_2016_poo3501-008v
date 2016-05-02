using Microsoft.VisualStudio.TestTools.UnitTesting;
using back.Layer.Checks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.Layer.Checks.Tests
{
    [TestClass()]
    public class VerifiersTests
    {
        [TestMethod()]
        public void checkIfNumberTest()
        {
            var objTest = new Verifiers();

            var test1 = "testing";
            var test2 = "4";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            //Aserciones o resultados.
            var resultTes1 = objTest.checkIfNumber(test1);
            var resultTes2 = objTest.checkIfNumber(test2);
            var resultTes3 = objTest.checkIfNumber(test3);
            var resultTes4 = objTest.checkIfNumber(test4 as string);
            var resultTes5 = objTest.checkIfNumber(test5);

            Assert.IsFalse(resultTes1);
            Assert.IsTrue(resultTes2);
            Assert.IsFalse(resultTes3);
            Assert.IsFalse(resultTes4);
            Assert.IsFalse(resultTes5);
        }

        [TestMethod()]
        public void getWinnerTest()
        {

        }

        [TestMethod()]
        public void GetSecondPlaceTest()
        {

        }

        [TestMethod()]
        public void CountVotesTest()
        {
            var test1 = new int[] {1,2,3,4,5,6};
            var test2 = new int[3];

            var resultTes1 = Verifiers.CountVotes(test1);
            var resultTest2 = Verifiers.CountVotes(test2);

            Assert.AreEqual(21, resultTes1);
            Assert.AreEqual(0, resultTest2);
        }

        [TestMethod()]
        public void CheckOpcionTest()
        {
            var objTest = new Verifiers();

            var test1 = 1;
            var test2 = 2;
            var test3 = 6;
            var test4 = 8;
            var test5 = default(int);

            var resultTes1 = objTest.CheckOpcion(test1);
            var resultTes2 = objTest.CheckOpcion(test2);
            var resultTes3 = objTest.CheckOpcion(test3);
            var resultTes4 = objTest.CheckOpcion(test4);
            var resultTes5 = objTest.CheckOpcion(test5);

            Assert.AreEqual(string.Empty, resultTes1);
            Assert.AreEqual(string.Empty, resultTes2);
            Assert.AreEqual(string.Empty, resultTes3);
            Assert.AreEqual(string.Format("Debe ingresar una opcion válida."), resultTes4);
            Assert.AreEqual(string.Format("Debe ingresar una opcion válida."), resultTes5);
        }

        [TestMethod()]
        public void CheckDistrictsCountTest()
        {
            var objTest = new Verifiers();

            var test1 = 1;
            var test2 = 2;
            var test3 = 6;
            var test4 = 8;
            var test5 = default(int);

            var resultTes1 = objTest.CheckDistrictsCount(test1);
            var resultTes2 = objTest.CheckDistrictsCount(test2);
            var resultTes3 = objTest.CheckDistrictsCount(test3);
            var resultTes4 = objTest.CheckDistrictsCount(test4);
            var resultTes5 = objTest.CheckDistrictsCount(test5);

            Assert.IsFalse(resultTes1);
            Assert.IsFalse(resultTes2);
            Assert.IsTrue(resultTes3);
            Assert.IsFalse(resultTes4);
            Assert.IsFalse(resultTes5);
        }
    }
}