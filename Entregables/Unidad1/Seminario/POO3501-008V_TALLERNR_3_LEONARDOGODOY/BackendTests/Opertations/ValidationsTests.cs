using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend.Opertations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Opertations.Tests
{
    [TestClass()]
    public class ValidationsTests
    {
        [TestMethod()]
        public void CheckIfIsNumberTest()
        {
            var validar = new Validations();

            var test1 = "gato";
            var test2 = "5";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            var resulTest1 = validar.CheckIfIsNumber(test1);
            var resulTest2 = validar.CheckIfIsNumber(test2);
            var resulTest3 = validar.CheckIfIsNumber(test3);
            var resulTest4 = validar.CheckIfIsNumber(test4 as string);
            var resulTest5 = validar.CheckIfIsNumber(test5);

            Assert.IsFalse(resulTest1);
            Assert.IsTrue(resulTest2);
            Assert.IsFalse(resulTest3);
            Assert.IsFalse(resulTest4);
            Assert.IsFalse(resulTest5);
        }

        [TestMethod()]
        public void convertNumberTest()
        {
            var validar = new Validations();

            var test1 = "gato";
            var test2 = "5";
            var test3 = string.Empty;
            var test4 = default(object);
            var test5 = default(string);

            var resulTest1 = validar.convertNumber(test1);
            var resulTest2 = validar.convertNumber(test2);
            var resulTest3 = validar.convertNumber(test3);
            var resulTest4 = validar.convertNumber(test4 as string);
            var resulTest5 = validar.convertNumber(test5);

            Assert.AreEqual(resulTest1, 0);
            Assert.AreEqual(resulTest2, 5);
            Assert.AreEqual(resulTest3, 0);
            Assert.AreEqual(resulTest4, 0);
            Assert.AreEqual(resulTest5, 0);
        }
    }
}