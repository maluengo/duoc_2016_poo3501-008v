using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Validators.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void validDistritTest()
        {
            var objTest = new Validator();

            var test1 = "test";
            var test2 = "4";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            //Aserciones o resultados
            var resultTest1 = objTest.validDistrit(test1);
            var resultTest2 = objTest.validDistrit(test2);
            var resultTest3 = objTest.validDistrit(test3);
            var resultTest4 = objTest.validDistrit(test4 as string);
            var resultTest5 = objTest.validDistrit(test5);

            Assert.IsFalse(resultTest1);
            Assert.IsTrue(resultTest2);
            Assert.IsFalse(resultTest3);
            Assert.IsFalse(resultTest4);
            Assert.IsFalse(resultTest5);
        }

        [TestMethod()]
        public void validCandidatesTest()
        {
            var objTest = new Validator();

            var test1 = "test";
            var test2 = "4";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            //Aserciones o resultados
            var resultTest1 = objTest.validCandidates(test1);
            var resultTest2 = objTest.validCandidates(test2);
            var resultTest3 = objTest.validCandidates(test3);
            var resultTest4 = objTest.validCandidates(test4 as string);
            var resultTest5 = objTest.validCandidates(test5);

            Assert.IsFalse(resultTest1);
            Assert.IsTrue(resultTest2);
            Assert.IsFalse(resultTest3);
            Assert.IsFalse(resultTest4);
            Assert.IsFalse(resultTest5);
        }
    }
}