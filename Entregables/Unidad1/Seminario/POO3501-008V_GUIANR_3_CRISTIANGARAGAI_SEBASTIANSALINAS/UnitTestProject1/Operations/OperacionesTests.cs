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
    public class OperacionesTests
    {
        [TestMethod()]
        public void getMayorDeArregloTest()
        {
            var objTest = new Operaciones();

            //Generar contexto
            var test1 = default(int[]);
            var test2 = new int[5]{1,2,3,4,5};
            var test3 = new int[5] { 1, 2, 3, 4, default(int) };

            //Aserciones o resultados
            var resultTest1 = objTest.getMayorDeArreglo(test1);
            var resultTest2 = objTest.getMayorDeArreglo(test2);
            var resultTest3 = objTest.getMayorDeArreglo(test3);



            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.IsInstanceOfType(resultTest2, typeof(int));
            Assert.IsInstanceOfType(resultTest3, typeof(int));
        }

        [TestMethod()]
        public void getSegundoDeArregloTest()
        {
            var objTest = new Operaciones();

            //Generar contexto
            var test1 = default(int[]);
            var test2 = new int[5] { 1, 2, 3, 4, 5 };
            var test3 = new int[5] { 1, 2, 3, 4, default(int) };

            //Aserciones o resultados
            var resultTest1 = objTest.getMayorDeArreglo(test1);
            var resultTest2 = objTest.getMayorDeArreglo(test2);
            var resultTest3 = objTest.getMayorDeArreglo(test3);

            Assert.IsInstanceOfType(resultTest1, typeof(int));
            Assert.IsInstanceOfType(resultTest2, typeof(int));
            Assert.IsInstanceOfType(resultTest3, typeof(int));
        }
    }
}