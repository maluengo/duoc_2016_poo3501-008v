using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Operations.Tests
{
    [TestClass()]
    public class ManejoStringTests
    {
        [TestMethod()]
        public void agregarEspaciosTest()
        {
            var objTest = new ManejoString();

            var test1_1 = "test";
            var test2_1 = "4";
            var test3_1 = string.Empty;
            var test4_1 = default(object);
            var test5_1 = default(string);

            var test1_2 = default(int);
            var test2_2 = 10;
            var test3_2 = 3;

            var test1_3 = default(int);
            var test2_3 = 4;

            //Aserciones o resultados
            var resultTest01 = objTest.agregarEspacios(test1_1,test1_2,test1_3);
            var resultTest02 = objTest.agregarEspacios(test1_1, test1_2, test2_3);
            var resultTest03 = objTest.agregarEspacios(test1_1, test2_2, test1_3);
            var resultTest04 = objTest.agregarEspacios(test1_1, test2_2, test2_3);
            var resultTest05 = objTest.agregarEspacios(test1_1, test3_2, test1_3);
            var resultTest06 = objTest.agregarEspacios(test1_1, test3_2, test2_3);

            var resultTest07 = objTest.agregarEspacios(test2_1, test1_2, test1_3);
            var resultTest08 = objTest.agregarEspacios(test2_1, test1_2, test2_3);
            var resultTest09 = objTest.agregarEspacios(test2_1, test2_2, test1_3);
            var resultTest10 = objTest.agregarEspacios(test2_1, test2_2, test2_3);
            var resultTest11 = objTest.agregarEspacios(test2_1, test3_2, test1_3);
            var resultTest12 = objTest.agregarEspacios(test2_1, test3_2, test2_3);

            var resultTest13 = objTest.agregarEspacios(test3_1, test1_2, test1_3);
            var resultTest14 = objTest.agregarEspacios(test3_1, test1_2, test2_3);
            var resultTest15 = objTest.agregarEspacios(test3_1, test2_2, test1_3);
            var resultTest16 = objTest.agregarEspacios(test3_1, test2_2, test2_3);
            var resultTest17 = objTest.agregarEspacios(test3_1, test3_2, test1_3);
            var resultTest18 = objTest.agregarEspacios(test3_1, test3_2, test2_3);

            var resultTest19 = objTest.agregarEspacios(test4_1 as string, test1_2, test1_3);
            var resultTest20 = objTest.agregarEspacios(test4_1 as string, test1_2, test2_3);
            var resultTest21 = objTest.agregarEspacios(test4_1 as string, test2_2, test1_3);
            var resultTest22 = objTest.agregarEspacios(test4_1 as string, test2_2, test2_3);
            var resultTest23 = objTest.agregarEspacios(test4_1 as string, test3_2, test1_3);
            var resultTest24 = objTest.agregarEspacios(test4_1 as string, test3_2, test2_3);

            var resultTest25 = objTest.agregarEspacios(test5_1, test1_2, test1_3);
            var resultTest26 = objTest.agregarEspacios(test5_1, test1_2, test2_3);
            var resultTest27 = objTest.agregarEspacios(test5_1, test2_2, test1_3);
            var resultTest28 = objTest.agregarEspacios(test5_1, test2_2, test2_3);
            var resultTest29 = objTest.agregarEspacios(test5_1, test3_2, test1_3);
            var resultTest30 = objTest.agregarEspacios(test5_1, test3_2, test2_3);

            Assert.IsInstanceOfType(resultTest01,typeof(string));
            Assert.IsInstanceOfType(resultTest02, typeof(string));
            Assert.IsInstanceOfType(resultTest03, typeof(string));
            Assert.IsInstanceOfType(resultTest04, typeof(string));
            Assert.IsInstanceOfType(resultTest05, typeof(string));
            Assert.IsInstanceOfType(resultTest06, typeof(string));
            Assert.IsInstanceOfType(resultTest07, typeof(string));
            Assert.IsInstanceOfType(resultTest08, typeof(string));
            Assert.IsInstanceOfType(resultTest09, typeof(string));
            Assert.IsInstanceOfType(resultTest10, typeof(string));
            Assert.IsInstanceOfType(resultTest11, typeof(string));
            Assert.IsInstanceOfType(resultTest12, typeof(string));
            Assert.IsInstanceOfType(resultTest13, typeof(string));
            Assert.IsInstanceOfType(resultTest14, typeof(string));
            Assert.IsInstanceOfType(resultTest15, typeof(string));
            Assert.IsInstanceOfType(resultTest16, typeof(string));
            Assert.IsInstanceOfType(resultTest17, typeof(string));
            Assert.IsInstanceOfType(resultTest18, typeof(string));
            Assert.IsInstanceOfType(resultTest19, typeof(string));
            Assert.IsInstanceOfType(resultTest20, typeof(string));
            Assert.IsInstanceOfType(resultTest21, typeof(string));
            Assert.IsInstanceOfType(resultTest22, typeof(string));
            Assert.IsInstanceOfType(resultTest23, typeof(string));
            Assert.IsInstanceOfType(resultTest24, typeof(string));
            Assert.IsInstanceOfType(resultTest25, typeof(string));
            Assert.IsInstanceOfType(resultTest26, typeof(string));
            Assert.IsInstanceOfType(resultTest27, typeof(string));
            Assert.IsInstanceOfType(resultTest28, typeof(string));
            Assert.IsInstanceOfType(resultTest29, typeof(string));
            Assert.IsInstanceOfType(resultTest30, typeof(string));

        }
    }
}