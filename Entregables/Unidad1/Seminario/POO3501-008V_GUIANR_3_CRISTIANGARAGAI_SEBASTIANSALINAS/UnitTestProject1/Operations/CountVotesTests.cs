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
    public class CountVotesTests
    {
        [TestMethod()]
        public void recivirDistritosTest()
        {
            var objTest = new CountVotes();

            var test1 = "4";
            var test2 = string.Empty;
            var test3 = default(object);
            var test4 = default(string);

            //Aserciones o resultados
            var resultTest1 = objTest.recivirDistritos(test1);
            var resultTest2 = objTest.recivirDistritos(test2);
            var resultTest3 = objTest.recivirDistritos(test3 as string);
            var resultTest4 = objTest.recivirDistritos(test4);

            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.IsInstanceOfType(resultTest2, typeof(int));
            Assert.IsInstanceOfType(resultTest3, typeof(int));
            Assert.IsInstanceOfType(resultTest4, typeof(int));
        }

        [TestMethod()]
        public void recivirCandidatosTest()
        {
            var objTest = new CountVotes();

            var test1 = "4";
            var test2 = string.Empty;
            var test3 = default(object);
            var test4 = default(string);

            //Aserciones o resultados
            var resultTest1 = objTest.recivirCandidatos(test1);
            var resultTest2 = objTest.recivirCandidatos(test2);
            var resultTest3 = objTest.recivirCandidatos(test3 as string);
            var resultTest4 = objTest.recivirCandidatos(test4);

            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.IsInstanceOfType(resultTest2, typeof(int));
            Assert.IsInstanceOfType(resultTest3, typeof(int));
            Assert.IsInstanceOfType(resultTest4, typeof(int));
        }

        [TestMethod()]
        public void countVotosTest()
        {
            var objTest = new CountVotes();

            var test1_1 = default(int);
            var test2_1 = 0;
            var test3_1 = 3;

            var test1_2 = default(int);
            var test2_2 = 0;
            var test3_2 = 3;

            var resultTest1 = objTest.countVotos(test1_1, test1_2);
            var resultTest2 = objTest.countVotos(test1_1, test2_2);
            var resultTest3 = objTest.countVotos(test1_1, test3_2);

            var resultTest4 = objTest.countVotos(test2_1, test1_2);
            var resultTest5 = objTest.countVotos(test2_1, test2_2);
            var resultTest6 = objTest.countVotos(test2_1, test3_2);

            var resultTest7 = objTest.countVotos(test3_1, test1_2);
            var resultTest8 = objTest.countVotos(test3_1, test2_2);
            var resultTest9 = objTest.countVotos(test3_1, test3_2);

            Assert.IsInstanceOfType(resultTest1, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest2, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest3, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest4, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest5, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest6, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest7, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest8, typeof(int[,]));
            Assert.IsInstanceOfType(resultTest9, typeof(int[,]));

        }
    }
}